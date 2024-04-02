using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace artJam
{
    public partial class Form_Client : Form
    {
        // Khởi tạo các giá trị cho bảng vẽ
        Graphics graphics;
        Boolean cursorMoving = false;
        Pen cursorPen;
        int cursorX = -1;
        int cursorY = -1;
        Point p = new Point();

        public Form_Client()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            Connect();

            // Tạo bảng vẽ và bút
            graphics = panel_canvas.CreateGraphics();
            cursorPen = new Pen(Color.Black, 7);
            PenOptimizer();
        }

        public void PenOptimizer()
        {
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
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

            // Gọi hàm gửi 2 points và reset giá trị cho event MouseMove tiếp theo
            Send(points_1, points_2);
            points_1.Clear();
            points_2.Clear();
        }

        IPEndPoint IP;
        Socket client;

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void Send(List<Point> points_1, List<Point> points_2)
        {
            // chọn 2 thuộc tính Color và Width của Pen để gửi
            object penDataObject = new object[] { cursorPen.Color, cursorPen.Width };

            // 3 object -> pen, point, point -> tuple -> string -> byte 
            var combinedObject = Tuple.Create(penDataObject, points_1, points_2);
            string json = JsonConvert.SerializeObject(combinedObject); // seriallize Tuple sang Json

            client.Send(Serialize(json));  // Seriallize Json sang byte
        }

        // Tạo class PenInfo để nhận giá trị Deserialized
        public class PenInfo
        {
            public IList<string> Item1 { get; set; }
            public IList<string> Item2 { get; set; }
            public IList<string> Item3 { get; set; }
        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string str0 = (string)Deserialize(data);                        // Deseriallize byte sang string
                    string str1 = JsonConvert.DeserializeObject(str0).ToString();   // Deseriallize string sang Json
                    string json = string.Format(@"{0}", str1);
                    PenInfo info = JsonConvert.DeserializeObject<PenInfo>(json);    // Deseriallize Json sang PenInfo

                    // Nhận các thuộc tính của Pen và khởi tạo Pen mới
                    float penWidth = 0;
                    float.TryParse(info.Item1[1], out penWidth);
                    Pen p = new Pen(Color.FromName(info.Item1[0]), penWidth);

                    // Vẽ tất cả các điểm có trong 2 list được truyền vào
                    int length = info.Item2.ToArray().Length;
                    for (int i = 0; i < length; i++)
                    {
                        string[] coords = info.Item2[i].Split(',');
                        Point p1 = new Point(int.Parse(coords[0]), int.Parse(coords[1]));

                        coords = info.Item3[i].Split(',');
                        Point p2 = new Point(int.Parse(coords[0]), int.Parse(coords[1]));

                        graphics.DrawLine(p, p1, p2);
                    }
                }
            }
            catch
            {
                client.Close();
            }
        }
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void Form_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }
    }
}
