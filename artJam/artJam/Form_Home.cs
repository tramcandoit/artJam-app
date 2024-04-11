using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace artJam
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }
        #region Khởi tạo giao diện
        private void button_start_Click(object sender, EventArgs e)
        {
            this.button_start.Visible = false;
            this.button_create_room.Visible = true;
            this.button_join_room.Visible = true;
            this.button_go_create_room.Visible = true;          
            this.richTextBox_nickname.Visible = true;
            this.label_nickname.Visible = true;
        }

        private void button_join_room_Click(object sender, EventArgs e)
        {
            this.button_create_room.Visible = true;
            this.button_join_room.Visible = true;
            this.button_go_create_room.Visible = false;
            this.button_go_join_room.Visible = true;
            this.richTextBox_nickname.Visible = true;
            this.richTextBox_code_room.Visible = true;
            this.label_nickname.Visible = true;
            this.label_code_room.Visible = true;
        }

        private void button_create_room_Click(object sender, EventArgs e)
        {
            this.button_create_room.Visible = true;
            this.button_join_room.Visible = true;
            this.button_go_create_room.Visible = true;
            this.button_go_join_room.Visible = false;
            this.richTextBox_nickname.Visible = true;
            this.richTextBox_code_room.Visible = false;
            this.label_nickname.Visible = true;
            this.label_code_room.Visible = false;
        }
        #endregion

        private void button_go_create_room_Click(object sender, EventArgs e)
        {
            if (richTextBox_nickname.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nickname");
                return;
            }

            this.Hide();

            string username = richTextBox_nickname.Text;
            go_to_canvas(0, username);
        }

        private void button_go_join_room_Click(object sender, EventArgs e)
        {
            if (richTextBox_nickname.Text == "" || richTextBox_code_room.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nickname và mã phòng");
                return;
            }

            this.Hide();

            string username = richTextBox_nickname.Text;
            string roomID = richTextBox_code_room.Text;
            go_to_canvas(1, username, roomID);
        }

        void go_to_canvas(int code, string username,  string roomID = "")
        {
            Form_Client canvas = new Form_Client(code, username, roomID);
            canvas.Show();
        }
    }
}
