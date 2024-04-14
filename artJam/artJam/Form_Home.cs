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
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace artJam
{
    public partial class Form_Home : Form
    {
        private bool isOffline;
        public Form_Home()
        {
            InitializeComponent();

        }
        #region Khởi tạo giao diện
        private void button_start_Click(object sender, EventArgs e)
        {
            this.button_start.Visible = false;
            this.button_go_create_canvas.Visible = true;
            this.panel_left.Visible = true;
            this.button_mode_offline.Visible = true;
            this.button_mode_LAN.Visible = true;
            this.isOffline = true;
        }

        private void button_mode_offline_Click(object sender, EventArgs e)
        {
            this.button_create_room.Visible = false;
            this.button_join_room.Visible = false;
            this.button_go_create_room.Visible = false;
            this.button_go_join_room.Visible = false;
            this.richTextBox_code_room.Visible = false;
            this.richTextBox_nickname.Visible = false;
            this.label_code_room.Visible = false;
            this.label_nickname.Visible = false;

            this.button_go_create_canvas.Visible = true;
            this.label_type_server_IP.Visible = false;
            this.textBox_server_IP.Visible = false;
            this.textBox_server_IP.Clear();
            this.isOffline = true;
        }

        private void button_mode_LAN_Click(object sender, EventArgs e)
        {
            this.button_create_room.Visible = true;
            this.button_join_room.Visible = true;
            this.button_go_create_room.Visible = true;
            this.richTextBox_nickname.Visible = true;
            this.label_nickname.Visible = true;

            this.button_go_create_canvas.Visible = false;

            this.label_type_server_IP.Visible = true;
            this.textBox_server_IP.Visible = true;
            this.textBox_server_IP.Text = "127.0.0.1";
            this.isOffline = false;
        }

        private void button_join_room_Click(object sender, EventArgs e)
        {
            this.button_go_create_room.Visible = false;
            this.button_go_join_room.Visible = true;
            this.richTextBox_code_room.Visible = true;
            this.label_code_room.Visible = true;
        }

        private void button_create_room_Click(object sender, EventArgs e)
        {
            this.button_go_create_room.Visible = true;
            this.button_go_join_room.Visible = false;
            this.richTextBox_code_room.Visible = false;
            this.label_code_room.Visible = false;
        }
        #endregion

        private void button_go_create_canvas_Click(object sender, EventArgs e)
        {
            Form_Client canvas = new Form_Client(isOffline, "", 0, "", "");
            canvas.Show();
        }

        private void button_go_create_room_Click(object sender, EventArgs e)
        {
            if (richTextBox_nickname.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nickname!");
                return;
            }
            if (!IPv4IsValid(textBox_server_IP.Text))
            {
                MessageBox.Show("Vui lòng nhập IPv4 hợp lệ!");
                return;
            }

            this.Hide();

            string username = richTextBox_nickname.Text;
            string serverIP = textBox_server_IP.Text;
            go_to_canvas(serverIP, 0, username);
        }

        private void button_go_join_room_Click(object sender, EventArgs e)
        {
            if (richTextBox_nickname.Text == "" || richTextBox_code_room.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nickname và mã phòng!");
                return;
            }
            if (!IPv4IsValid(textBox_server_IP.Text))
            {
                MessageBox.Show("Vui lòng nhập IPv4 hợp lệ!");
                return;
            }

            this.Hide();

            string username = richTextBox_nickname.Text;
            string roomID = richTextBox_code_room.Text;
            string serverIP = textBox_server_IP.Text;
            go_to_canvas(serverIP, 1, username, roomID);
        }

        private void go_to_canvas(string serverIP, int code, string username,  string roomID = "")
        {
            Form_Client canvas = new Form_Client(isOffline, serverIP, code, username, roomID);
            canvas.Show();
        }

        public bool IPv4IsValid(string ipv4)
        {
            if (String.IsNullOrWhiteSpace(ipv4)) return false;

            string[] splitValues = ipv4.Split('.');
            if (splitValues.Length != 4) return false;
            
            byte posNum;
            return splitValues.All(i => byte.TryParse(i, out posNum));
        }
    }
}