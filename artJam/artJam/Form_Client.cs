using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artJam
{
    public partial class Form_Client : Form
    {
        // khởi tạo các giá trị cho bảng vẽ
        Graphics graphics;
        Boolean cursorMoving = false;
        Pen cursorPen;
        int cursorX = -1;
        int cursorY = -1;
        Point p = new Point();

        public Form_Client()
        {
            InitializeComponent();

            // tạo bảng vẽ và bút
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

        private void panel_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && cursorMoving == true)
            {
                p = e.Location;

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
        }
    }
}
