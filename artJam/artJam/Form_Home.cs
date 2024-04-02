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
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }
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

        private void button_go_create_room_Click(object sender, EventArgs e)
        {
            if (richTextBox_nickname.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nickname");
                return;
            }
            else
            {
                this.Hide();
                Form_Client Client = new Form_Client();
                Client.ShowDialog();
            } 
        }

        private void button_go_join_room_Click(object sender, EventArgs e)
        {
            if (richTextBox_nickname.Text == "" || richTextBox_code_room.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nickname và mã phòng");
                return;
            }
            else
            {
                this.Hide();
                Form_Client Client = new Form_Client();
                Client.ShowDialog();
            }
        }
    }
}
