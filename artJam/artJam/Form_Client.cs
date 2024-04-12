using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using System.Text;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace artJam
{
    public partial class Form_Client : Form
    {
        // Khởi tạo các giá trị cho bảng vẽ
        private static Graphics graphics;
        private Boolean cursorMoving = false;
        private Pen cursorPen;
        private int cursorX = -1;
        private int cursorY = -1;
        private Point p = new Point();

        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private Packet this_client_info;

        int thickness = 5;

        public Form_Client(int code, string username, string roomID)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            // Tạo bảng vẽ và bút
            graphics = panel_canvas.CreateGraphics();
            cursorPen = new Pen(Color.Black, thickness);
            PenOptimizer();

            this_client_info = new Packet()
            {
                Code = code,
                Username = username,
                RoomID = roomID,
            };
        }

        private void Form_Client_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 9999);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            NetworkStream stream = client.GetStream();
            reader = new StreamReader(stream, System.Text.Encoding.UTF8);
            writer = new StreamWriter(stream, System.Text.Encoding.UTF8);

            sendToServer(this_client_info);
            textBox_room_code.Text = "Mã phòng: " + this_client_info.RoomID;
            textBox_username.Text = "Nickname: " + this_client_info.Username;
            graphics.DrawLine(cursorPen, 0, 0, 100, 100);

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
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
                            draw_graphics_handler(response);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                client.Close();
            }
        }

        void generate_room_status(Packet response)
        {
            this_client_info.RoomID = response.RoomID;
            textBox_room_code.Invoke(new Action(() =>
            {
                textBox_room_code.Text = "Mã phòng: " + this_client_info.RoomID;
            }));
        }

        void join_room_status(Packet response)
        {

        }

        //SynchronizationContext context = SynchronizationContext.Current ?? new SynchronizationContext();
        //context.Send(s =>
        //    {

        //    }, null);

        void draw_graphics_handler(Packet response)
        {
            Pen p = new Pen(Color.FromName(response.PenColor), thickness);

            int length = response.Points_1.ToArray().Length;

            for (int i = 0; i < length; i++)
            {
                graphics.DrawLine(p, response.Points_1[i], response.Points_2[i]);
            }
        }

        private void pictureBox_black_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            cursorPen.Color = color.BackColor;
            PenOptimizer();
        }

        private void panel_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            cursorMoving = true;
            cursorX = e.X;
            cursorY = e.Y;
        }

        // List của 2 point truyền vào graphics.DrawLine()
        static List<Point> points_1 = new List<Point>();
        static List<Point> points_2 = new List<Point>();

        private void panel_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && cursorMoving == true)
            {
                p = e.Location;

                points_1.Add(new Point(cursorX, cursorY));
                points_2.Add(p);

                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), p);

                cursorX = e.X;
                cursorY = e.Y;
            }
        }

        private void panel_canvas_MouseUp(object sender, MouseEventArgs e)
        {
            cursorMoving = false;
            cursorX = -1;
            cursorY = -1;

            Packet messsage = new Packet
            {
                Code = 2,
                Username = this_client_info.Username,
                RoomID = this_client_info.RoomID,
                PenColor = cursorPen.Color.Name,
                Points_1 = points_1,
                Points_2 = points_2
            };
            sendToServer(messsage);

            points_1.Clear();
            points_2.Clear();
        }

        private void PenOptimizer()
        {
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void sendToServer(Packet message)
        {
            string messageInJson = JsonConvert.SerializeObject(message);
            try
            {
                writer.WriteLine(messageInJson);
                writer.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
            Application.OpenForms["Form_Home"].Close();
        }
    }
}