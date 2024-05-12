using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Drawing.Imaging;

namespace artJam
{
    public partial class Form_Client : Form
    {
        // Khởi tạo các giá trị cho bảng vẽ
        private Bitmap bitmap;
        private Graphics graphics;
        private Boolean cursorMoving = false;
        private Pen cursorPen;
        private int cursorX = -1;
        private int cursorY = -1;
        private Point p = new Point();
        private Color stateColor;
        private int shapeTag = 10;

        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private Packet this_client_info;
        private IPEndPoint serverIP;
        private Manager Manager;
        private bool isOffline;
        private bool isNew;

        private SynchronizationContext context = SynchronizationContext.Current ?? new SynchronizationContext();

        public Form_Client(bool mode, string _serverIP, int code, string username, string roomID)
        {
            InitializeComponent();

            // Tạo bảng vẽ và bút
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Canvas.Image = bitmap;
            stateColor = Color.Black;
            cursorPen = new Pen(stateColor, 2);
            PenOptimizer(cursorPen);
            this.ActiveControl = null;

            this_client_info = new Packet()
            {
                Code = code,
                Username = username,
                RoomID = roomID,
            };

            isNew = true;
            isOffline = mode;
            if (!isOffline)
            {
                textBox_room_code.Visible = true;
                serverIP = new IPEndPoint(IPAddress.Parse(_serverIP), 9999);
            }

            Manager = new Manager(listView_room_users, textBox_room_code);
        }

        private void Form_Client_Load(object sender, EventArgs e)
        {
            if (!isOffline)
            {
                try
                {
                    client = new TcpClient();
                    client.Connect(serverIP);
                }
                catch
                {
                    Manager.ShowError("Can not connect to the server!");
                    this.Close();
                    return;
                }
                NetworkStream stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);

                sendToServer(this_client_info);
                Manager.UpdateRoomID(this_client_info.RoomID);
                Manager.AddToUserListView(this_client_info.Username + " (you)");

                Thread listen = new Thread(Receive);
                listen.IsBackground = true;
                listen.Start();
            }
        }

        private void Receive()
        {
            try
            {
                string responseInJson = string.Empty;
                while (true)
                {
                    responseInJson = reader.ReadLine();

                    Packet response = JsonConvert.DeserializeObject<Packet>(responseInJson);

                    switch (response.Code)
                    {
                        case 0:
                            generate_room_status(response);
                            break;
                        case 1:
                            join_room_status(response);
                            break;
                        case 2:
                            sync_bitmap_status(response);
                            break;
                        case 3:
                            draw_bitmap_handler(response);
                            break;
                        case 4:
                            draw_graphics_handler(response);
                            break;
                    }
                }
            }
            catch
            {
                client.Close();
            }
        }

        void generate_room_status(Packet response)
        {
            this_client_info.RoomID = response.RoomID;
            Manager.UpdateRoomID(this_client_info.RoomID);
        }

        void join_room_status(Packet response)
        {
            if (isNew)
            {
                sendToServer(new Packet
                {
                    Code = 2,
                    RoomID = response.RoomID,
                });
                isNew = false;
            }

            if (response.Username == "err:thisroomdoesnotexist")
            {
                Manager.ShowError("The room you requested does not exist");
                client.Close();
                this.Close();
                return;
            }

            if (response.Username.Contains('!'))
            {
                Manager.RemoveFromUserListView(response.Username.Substring(1));
            }
            else
            {
                List<string> list = response.Username.Split(',').ToList();
                foreach (string username in list)
                {
                    if (username == this_client_info.Username)
                    {
                        list.Remove(username);
                        break;
                    }
                }
                Manager.ClearUserListView();
                foreach (string username in list)
                {
                    Manager.AddToUserListView(username);
                }
            }
        }

        private void sync_bitmap_status(Packet respone)
        {
            Packet message = new Packet
            {
                Code = 3,
                RoomID = respone.RoomID,
                BitmapString = Manager.BitmapToString(bitmap),
            };
            sendToServer(message);
        }

        private void draw_bitmap_handler(Packet response)
        {
            Bitmap _bitmap = Manager.StringToBitmap(response.BitmapString);
            bitmap = _bitmap;
            graphics = Graphics.FromImage(bitmap);
            Canvas.Image = bitmap;
            context.Send(s =>
            {
                Canvas.Refresh();
            }, null);
        }

        void draw_graphics_handler(Packet response)
        {
            Pen p = new Pen(Color.FromName(response.PenColor), response.PenWidth);
            PenOptimizer(p);
            int cursorX = 0, cursorY = 0;
            float w = 0, h = 0;

            if (response.ShapeTag == 10)
            {
                int length = response.Points_1.ToArray().Length;

                for (int i = 0; i < length; i++)
                {
                    context.Send(s =>
                    {
                        graphics.DrawLine(p, response.Points_1[i], response.Points_2[i]);
                    }, null);
                }
            }
            else
            {
                cursorX = (int)response.Position[0];
                cursorY = (int)response.Position[1];
                w = response.Position[2];
                h = response.Position[3];
            }
            if (response.ShapeTag == 11)
            {
                context.Send(s =>
                {
                    graphics.DrawLine(p, cursorX, cursorY, w + cursorX, h + cursorY);
                }, null);
            }
            if (response.ShapeTag == 12)
            {
                context.Send(s =>
                {
                    graphics.DrawRectangle(p, cursorX, cursorY, w, h);
                }, null);
            }
            if (response.ShapeTag == 13)
            {
                context.Send(s =>
                {
                    graphics.DrawEllipse(p, cursorX, cursorY, w, h);
                }, null);
            }
            context.Send(s =>
            {
                Canvas.Refresh();
            }, null);
        }
        
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            cursorMoving = true;
            cursorX = e.X;
            cursorY = e.Y;
        }

        // List của 2 point truyền vào graphics.DrawLine()
        static List<Point> points_1 = new List<Point>();
        static List<Point> points_2 = new List<Point>();

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && cursorMoving == true && (shapeTag == 10))
            {
                p = e.Location;

                points_1.Add(new Point(cursorX, cursorY));
                points_2.Add(p);

                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), p);

                cursorX = e.X;
                cursorY = e.Y;
            }
            context.Send(s =>
            {
                Canvas.Refresh();
            }, null);
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            float w = e.Location.X - cursorX;
            float h = e.Location.Y - cursorY;

            if (shapeTag == 11)
            {
                graphics.DrawLine(cursorPen, cursorX, cursorY, w + cursorX, h + cursorY);
            }
            if (shapeTag == 12)
            {
                graphics.DrawRectangle(cursorPen, cursorX, cursorY, w, h);
            }
            if (shapeTag == 13)
            {
                graphics.DrawEllipse(cursorPen, cursorX, cursorY, w, h);
            }
            context.Send(s =>
            {
                Canvas.Refresh();
            }, null);

            float[] pos = new float[] { cursorX, cursorY, w, h };

            Packet messsage = new Packet
            {
                Code = 4,
                Username = this_client_info.Username,
                RoomID = this_client_info.RoomID,
                PenColor = cursorPen.Color.Name,
                PenWidth = cursorPen.Width,
                ShapeTag = shapeTag,
                Points_1 = points_1,
                Points_2 = points_2,
                Position = pos
            };

            if (!isOffline)
            {
                sendToServer(messsage);
            }

            cursorMoving = false;
            cursorX = -1;
            cursorY = -1;
            points_1.Clear();
            points_2.Clear();
        }

        private void sendToServer(Packet message)
        {
            string messageInJson = JsonConvert.SerializeObject(message);
            try
            {
                writer.WriteLine(messageInJson);
                writer.Flush();
            }
            catch
            {
                Manager.ShowError("Failed to send data to server!");
            }
        }

        private void pictureBox_black_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            cursorPen.Color = color.BackColor;
            if (color.BackColor != Color.White)
            {
                stateColor = color.BackColor;
            }
            else
            {
                shapeTag = 10;
            }
            pictureBox_picking_color.BackColor = stateColor;
        }

        private void button_pen_width_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            cursorPen.Width = Convert.ToInt32(button.Tag);
        }

        private void button_shapes_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            shapeTag = Convert.ToInt32(button.Tag);
            cursorPen.Color = stateColor;
        }

        private void PenOptimizer(Pen pen)
        {
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image (*.png) |*.png| (*.*) |*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bitmap.Clone(new Rectangle(0, 0, Canvas.Width, Canvas.Height), bitmap.PixelFormat);
                btm.Save(saveFile.FileName, ImageFormat.Png);
            }
        }

        int _temp = 0;
        private void textBox_room_code_Click(object sender, EventArgs e)
        {
            _temp++;
            if (_temp % 2 == 0)
            {
                listView_room_users.Visible = false;
            }
            else
            {
                listView_room_users.Visible = true;
            }
        }

        private void Form_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isOffline)
            {
                client.Close();
            }
            Application.OpenForms["Form_Home"].Close();
        }
    }
}