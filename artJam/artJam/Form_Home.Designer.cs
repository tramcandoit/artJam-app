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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
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
            this.button_go_create_canvas = new System.Windows.Forms.Button();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_create_room
            // 
            this.button_create_room.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_create_room.BackColor = System.Drawing.Color.LightSalmon;
            this.button_create_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_create_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_room.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create_room.ForeColor = System.Drawing.Color.White;
            this.button_create_room.Location = new System.Drawing.Point(292, 70);
            this.button_create_room.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_create_room.Name = "button_create_room";
            this.button_create_room.Size = new System.Drawing.Size(169, 44);
            this.button_create_room.TabIndex = 2;
            this.button_create_room.Text = "Create new room";
            this.button_create_room.UseVisualStyleBackColor = false;
            this.button_create_room.Visible = false;
            this.button_create_room.Click += new System.EventHandler(this.button_create_room_Click);
            // 
            // button_join_room
            // 
            this.button_join_room.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_join_room.BackColor = System.Drawing.Color.LightSalmon;
            this.button_join_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_join_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_join_room.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_join_room.ForeColor = System.Drawing.Color.White;
            this.button_join_room.Location = new System.Drawing.Point(501, 70);
            this.button_join_room.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_join_room.Name = "button_join_room";
            this.button_join_room.Size = new System.Drawing.Size(169, 44);
            this.button_join_room.TabIndex = 2;
            this.button_join_room.Text = "Join room";
            this.button_join_room.UseVisualStyleBackColor = false;
            this.button_join_room.Visible = false;
            this.button_join_room.Click += new System.EventHandler(this.button_join_room_Click);
            // 
            // richTextBox_nickname
            // 
            this.richTextBox_nickname.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_nickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_nickname.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_nickname.Location = new System.Drawing.Point(456, 164);
            this.richTextBox_nickname.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox_nickname.Name = "richTextBox_nickname";
            this.richTextBox_nickname.Size = new System.Drawing.Size(194, 31);
            this.richTextBox_nickname.TabIndex = 3;
            this.richTextBox_nickname.Text = "";
            this.richTextBox_nickname.Visible = false;
            // 
            // richTextBox_code_room
            // 
            this.richTextBox_code_room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_code_room.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_code_room.Location = new System.Drawing.Point(456, 224);
            this.richTextBox_code_room.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox_code_room.Name = "richTextBox_code_room";
            this.richTextBox_code_room.Size = new System.Drawing.Size(194, 30);
            this.richTextBox_code_room.TabIndex = 3;
            this.richTextBox_code_room.Text = "";
            this.richTextBox_code_room.Visible = false;
            // 
            // label_nickname
            // 
            this.label_nickname.AutoSize = true;
            this.label_nickname.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nickname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_nickname.Location = new System.Drawing.Point(345, 165);
            this.label_nickname.Name = "label_nickname";
            this.label_nickname.Size = new System.Drawing.Size(87, 23);
            this.label_nickname.TabIndex = 5;
            this.label_nickname.Text = "Nickname";
            this.label_nickname.Visible = false;
            // 
            // label_code_room
            // 
            this.label_code_room.AutoSize = true;
            this.label_code_room.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_code_room.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_code_room.Location = new System.Drawing.Point(334, 225);
            this.label_code_room.Name = "label_code_room";
            this.label_code_room.Size = new System.Drawing.Size(98, 23);
            this.label_code_room.TabIndex = 6;
            this.label_code_room.Text = "Room code";
            this.label_code_room.Visible = false;
            // 
            // button_go_join_room
            // 
            this.button_go_join_room.BackColor = System.Drawing.Color.LightSalmon;
            this.button_go_join_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_go_join_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_go_join_room.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_go_join_room.ForeColor = System.Drawing.Color.White;
            this.button_go_join_room.Location = new System.Drawing.Point(456, 279);
            this.button_go_join_room.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_go_join_room.Name = "button_go_join_room";
            this.button_go_join_room.Size = new System.Drawing.Size(194, 40);
            this.button_go_join_room.TabIndex = 7;
            this.button_go_join_room.Text = "Start";
            this.button_go_join_room.UseVisualStyleBackColor = false;
            this.button_go_join_room.Visible = false;
            this.button_go_join_room.Click += new System.EventHandler(this.button_go_join_room_Click);
            // 
            // button_go_create_room
            // 
            this.button_go_create_room.BackColor = System.Drawing.Color.LightSalmon;
            this.button_go_create_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_go_create_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_go_create_room.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_go_create_room.ForeColor = System.Drawing.Color.White;
            this.button_go_create_room.Location = new System.Drawing.Point(456, 278);
            this.button_go_create_room.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_go_create_room.Name = "button_go_create_room";
            this.button_go_create_room.Size = new System.Drawing.Size(194, 40);
            this.button_go_create_room.TabIndex = 7;
            this.button_go_create_room.Text = "Start";
            this.button_go_create_room.UseVisualStyleBackColor = false;
            this.button_go_create_room.Visible = false;
            this.button_go_create_room.Click += new System.EventHandler(this.button_go_create_room_Click);
            // 
            // button_start
            // 
            this.button_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_start.BackColor = System.Drawing.Color.LightSalmon;
            this.button_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.Color.White;
            this.button_start.Location = new System.Drawing.Point(292, 178);
            this.button_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(136, 52);
            this.button_start.TabIndex = 8;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_mode_offline
            // 
            this.button_mode_offline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_mode_offline.BackColor = System.Drawing.Color.LightSalmon;
            this.button_mode_offline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_mode_offline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mode_offline.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mode_offline.ForeColor = System.Drawing.Color.Transparent;
            this.button_mode_offline.Location = new System.Drawing.Point(72, 121);
            this.button_mode_offline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_mode_offline.Name = "button_mode_offline";
            this.button_mode_offline.Size = new System.Drawing.Size(127, 55);
            this.button_mode_offline.TabIndex = 9;
            this.button_mode_offline.Text = "Offline";
            this.button_mode_offline.UseVisualStyleBackColor = false;
            this.button_mode_offline.Visible = false;
            this.button_mode_offline.Click += new System.EventHandler(this.button_mode_offline_Click);
            // 
            // button_mode_LAN
            // 
            this.button_mode_LAN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_mode_LAN.BackColor = System.Drawing.Color.LightSalmon;
            this.button_mode_LAN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_mode_LAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mode_LAN.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mode_LAN.ForeColor = System.Drawing.Color.White;
            this.button_mode_LAN.Location = new System.Drawing.Point(72, 200);
            this.button_mode_LAN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_mode_LAN.Name = "button_mode_LAN";
            this.button_mode_LAN.Size = new System.Drawing.Size(127, 55);
            this.button_mode_LAN.TabIndex = 11;
            this.button_mode_LAN.Text = "LAN";
            this.button_mode_LAN.UseVisualStyleBackColor = false;
            this.button_mode_LAN.Visible = false;
            this.button_mode_LAN.Click += new System.EventHandler(this.button_mode_LAN_Click);
            // 
            // label_type_server_IP
            // 
            this.label_type_server_IP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_type_server_IP.AutoSize = true;
            this.label_type_server_IP.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type_server_IP.ForeColor = System.Drawing.Color.White;
            this.label_type_server_IP.Location = new System.Drawing.Point(54, 300);
            this.label_type_server_IP.Name = "label_type_server_IP";
            this.label_type_server_IP.Size = new System.Drawing.Size(195, 23);
            this.label_type_server_IP.TabIndex = 12;
            this.label_type_server_IP.Text = "Enter server\'s IP address";
            this.label_type_server_IP.Visible = false;
            // 
            // textBox_server_IP
            // 
            this.textBox_server_IP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_server_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_server_IP.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_server_IP.Location = new System.Drawing.Point(63, 338);
            this.textBox_server_IP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_server_IP.Name = "textBox_server_IP";
            this.textBox_server_IP.Size = new System.Drawing.Size(145, 31);
            this.textBox_server_IP.TabIndex = 13;
            this.textBox_server_IP.Visible = false;
            // 
            // panel_left
            // 
            this.panel_left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_left.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel_left.Controls.Add(this.button_mode_LAN);
            this.panel_left.Controls.Add(this.textBox_server_IP);
            this.panel_left.Controls.Add(this.button_mode_offline);
            this.panel_left.Controls.Add(this.label_type_server_IP);
            this.panel_left.Location = new System.Drawing.Point(-29, -51);
            this.panel_left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(252, 534);
            this.panel_left.TabIndex = 14;
            this.panel_left.Visible = false;
            // 
            // button_go_create_canvas
            // 
            this.button_go_create_canvas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_go_create_canvas.BackColor = System.Drawing.Color.LightSalmon;
            this.button_go_create_canvas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_go_create_canvas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_go_create_canvas.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_go_create_canvas.ForeColor = System.Drawing.Color.White;
            this.button_go_create_canvas.Location = new System.Drawing.Point(388, 165);
            this.button_go_create_canvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_go_create_canvas.Name = "button_go_create_canvas";
            this.button_go_create_canvas.Size = new System.Drawing.Size(188, 78);
            this.button_go_create_canvas.TabIndex = 15;
            this.button_go_create_canvas.Text = "Create your own drawing board";
            this.button_go_create_canvas.UseVisualStyleBackColor = false;
            this.button_go_create_canvas.Visible = false;
            this.button_go_create_canvas.Click += new System.EventHandler(this.button_go_create_canvas_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(742, 433);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_go_create_canvas);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.button_go_create_room);
            this.Controls.Add(this.button_go_join_room);
            this.Controls.Add(this.label_code_room);
            this.Controls.Add(this.richTextBox_nickname);
            this.Controls.Add(this.label_nickname);
            this.Controls.Add(this.richTextBox_code_room);
            this.Controls.Add(this.button_join_room);
            this.Controls.Add(this.button_create_room);
            this.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Home";
            this.Text = "artJam";
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
        private System.Windows.Forms.Button button_go_create_canvas;
    }
}

