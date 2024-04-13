namespace artJam
{
    partial class Form_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_create_room = new System.Windows.Forms.Button();
            this.button_join_room = new System.Windows.Forms.Button();
            this.richTextBox_nickname = new System.Windows.Forms.RichTextBox();
            this.richTextBox_code_room = new System.Windows.Forms.RichTextBox();
            this.label_nickname = new System.Windows.Forms.Label();
            this.label_code_room = new System.Windows.Forms.Label();
            this.button_go_join_room = new System.Windows.Forms.Button();
            this.button_go_create_room = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_mode_offline = new System.Windows.Forms.Button();
            this.button_mode_LAN = new System.Windows.Forms.Button();
            this.label_type_server_IP = new System.Windows.Forms.Label();
            this.textBox_server_IP = new System.Windows.Forms.TextBox();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_create_room
            // 
            this.button_create_room.Location = new System.Drawing.Point(381, 84);
            this.button_create_room.Name = "button_create_room";
            this.button_create_room.Size = new System.Drawing.Size(101, 25);
            this.button_create_room.TabIndex = 2;
            this.button_create_room.Text = "Tạo phòng";
            this.button_create_room.UseVisualStyleBackColor = true;
            this.button_create_room.Visible = false;
            this.button_create_room.Click += new System.EventHandler(this.button_create_room_Click);
            // 
            // button_join_room
            // 
            this.button_join_room.Location = new System.Drawing.Point(548, 84);
            this.button_join_room.Name = "button_join_room";
            this.button_join_room.Size = new System.Drawing.Size(101, 25);
            this.button_join_room.TabIndex = 2;
            this.button_join_room.Text = "Tham gia phòng";
            this.button_join_room.UseVisualStyleBackColor = true;
            this.button_join_room.Visible = false;
            this.button_join_room.Click += new System.EventHandler(this.button_join_room_Click);
            // 
            // richTextBox_nickname
            // 
            this.richTextBox_nickname.Location = new System.Drawing.Point(381, 162);
            this.richTextBox_nickname.Name = "richTextBox_nickname";
            this.richTextBox_nickname.Size = new System.Drawing.Size(272, 43);
            this.richTextBox_nickname.TabIndex = 3;
            this.richTextBox_nickname.Text = "";
            this.richTextBox_nickname.Visible = false;
            // 
            // richTextBox_code_room
            // 
            this.richTextBox_code_room.Location = new System.Drawing.Point(381, 261);
            this.richTextBox_code_room.Name = "richTextBox_code_room";
            this.richTextBox_code_room.Size = new System.Drawing.Size(272, 43);
            this.richTextBox_code_room.TabIndex = 3;
            this.richTextBox_code_room.Text = "";
            this.richTextBox_code_room.Visible = false;
            // 
            // label_nickname
            // 
            this.label_nickname.AutoSize = true;
            this.label_nickname.Location = new System.Drawing.Point(289, 189);
            this.label_nickname.Name = "label_nickname";
            this.label_nickname.Size = new System.Drawing.Size(68, 16);
            this.label_nickname.TabIndex = 5;
            this.label_nickname.Text = "Nickname";
            this.label_nickname.Visible = false;
            // 
            // label_code_room
            // 
            this.label_code_room.AutoSize = true;
            this.label_code_room.Location = new System.Drawing.Point(290, 288);
            this.label_code_room.Name = "label_code_room";
            this.label_code_room.Size = new System.Drawing.Size(67, 16);
            this.label_code_room.TabIndex = 6;
            this.label_code_room.Text = "Mã phòng";
            this.label_code_room.Visible = false;
            // 
            // button_go_join_room
            // 
            this.button_go_join_room.Location = new System.Drawing.Point(607, 310);
            this.button_go_join_room.Name = "button_go_join_room";
            this.button_go_join_room.Size = new System.Drawing.Size(114, 34);
            this.button_go_join_room.TabIndex = 7;
            this.button_go_join_room.Text = "Tham gia";
            this.button_go_join_room.UseVisualStyleBackColor = true;
            this.button_go_join_room.Visible = false;
            this.button_go_join_room.Click += new System.EventHandler(this.button_go_join_room_Click);
            // 
            // button_go_create_room
            // 
            this.button_go_create_room.Location = new System.Drawing.Point(607, 211);
            this.button_go_create_room.Name = "button_go_create_room";
            this.button_go_create_room.Size = new System.Drawing.Size(114, 34);
            this.button_go_create_room.TabIndex = 7;
            this.button_go_create_room.Text = "Tạo phòng";
            this.button_go_create_room.UseVisualStyleBackColor = true;
            this.button_go_create_room.Visible = false;
            this.button_go_create_room.Click += new System.EventHandler(this.button_go_create_room_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(328, 189);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(136, 44);
            this.button_start.TabIndex = 8;
            this.button_start.Text = "Bắt đầu";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_mode_offline
            // 
            this.button_mode_offline.Location = new System.Drawing.Point(48, 101);
            this.button_mode_offline.Name = "button_mode_offline";
            this.button_mode_offline.Size = new System.Drawing.Size(127, 46);
            this.button_mode_offline.TabIndex = 9;
            this.button_mode_offline.Text = "Offline";
            this.button_mode_offline.UseVisualStyleBackColor = true;
            this.button_mode_offline.Visible = false;
            this.button_mode_offline.Click += new System.EventHandler(this.button_mode_offline_Click);
            // 
            // button_mode_LAN
            // 
            this.button_mode_LAN.Location = new System.Drawing.Point(48, 179);
            this.button_mode_LAN.Name = "button_mode_LAN";
            this.button_mode_LAN.Size = new System.Drawing.Size(127, 46);
            this.button_mode_LAN.TabIndex = 11;
            this.button_mode_LAN.Text = "LAN";
            this.button_mode_LAN.UseVisualStyleBackColor = true;
            this.button_mode_LAN.Visible = false;
            this.button_mode_LAN.Click += new System.EventHandler(this.button_mode_LAN_Click);
            // 
            // label_type_server_IP
            // 
            this.label_type_server_IP.AutoSize = true;
            this.label_type_server_IP.Location = new System.Drawing.Point(41, 269);
            this.label_type_server_IP.Name = "label_type_server_IP";
            this.label_type_server_IP.Size = new System.Drawing.Size(144, 16);
            this.label_type_server_IP.TabIndex = 12;
            this.label_type_server_IP.Text = "Vui lòng nhập IP server";
            this.label_type_server_IP.Visible = false;
            // 
            // textBox_server_IP
            // 
            this.textBox_server_IP.Location = new System.Drawing.Point(40, 299);
            this.textBox_server_IP.Name = "textBox_server_IP";
            this.textBox_server_IP.Size = new System.Drawing.Size(145, 22);
            this.textBox_server_IP.TabIndex = 13;
            this.textBox_server_IP.Visible = false;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_left.Controls.Add(this.button_mode_LAN);
            this.panel_left.Controls.Add(this.textBox_server_IP);
            this.panel_left.Controls.Add(this.button_mode_offline);
            this.panel_left.Controls.Add(this.label_type_server_IP);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(227, 450);
            this.panel_left.TabIndex = 14;
            this.panel_left.Visible = false;
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_go_create_room);
            this.Controls.Add(this.button_go_join_room);
            this.Controls.Add(this.label_code_room);
            this.Controls.Add(this.label_nickname);
            this.Controls.Add(this.richTextBox_code_room);
            this.Controls.Add(this.richTextBox_nickname);
            this.Controls.Add(this.button_join_room);
            this.Controls.Add(this.button_create_room);
            this.Name = "Form_Home";
            this.Text = "appJam";
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_create_room;
        private System.Windows.Forms.Button button_join_room;
        private System.Windows.Forms.RichTextBox richTextBox_nickname;
        private System.Windows.Forms.RichTextBox richTextBox_code_room;
        private System.Windows.Forms.Label label_nickname;
        private System.Windows.Forms.Label label_code_room;
        private System.Windows.Forms.Button button_go_join_room;
        private System.Windows.Forms.Button button_go_create_room;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_mode_offline;
        private System.Windows.Forms.Button button_mode_LAN;
        private System.Windows.Forms.Label label_type_server_IP;
        private System.Windows.Forms.TextBox textBox_server_IP;
        private System.Windows.Forms.Panel panel_left;
    }
}

