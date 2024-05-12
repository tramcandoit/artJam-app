﻿namespace Server
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.label_room_count = new System.Windows.Forms.Label();
            this.textBox_room_count = new System.Windows.Forms.TextBox();
            this.button_start_server = new System.Windows.Forms.Button();
            this.button_stop_server = new System.Windows.Forms.Button();
            this.textBox_server_local_IP = new System.Windows.Forms.TextBox();
            this.listView_log = new System.Windows.Forms.ListView();
            this.button_get_server_IP = new System.Windows.Forms.Button();
            this.label_user_count = new System.Windows.Forms.Label();
            this.textBox_user_count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_room_count
            // 
            this.label_room_count.AutoSize = true;
            this.label_room_count.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_room_count.ForeColor = System.Drawing.Color.IndianRed;
            this.label_room_count.Location = new System.Drawing.Point(195, 421);
            this.label_room_count.Name = "label_room_count";
            this.label_room_count.Size = new System.Drawing.Size(132, 23);
            this.label_room_count.TabIndex = 0;
            this.label_room_count.Text = "Available rooms";
            // 
            // textBox_room_count
            // 
            this.textBox_room_count.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_room_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_room_count.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_room_count.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox_room_count.Location = new System.Drawing.Point(333, 419);
            this.textBox_room_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_room_count.Name = "textBox_room_count";
            this.textBox_room_count.ReadOnly = true;
            this.textBox_room_count.Size = new System.Drawing.Size(71, 30);
            this.textBox_room_count.TabIndex = 1;
            // 
            // button_start_server
            // 
            this.button_start_server.BackColor = System.Drawing.Color.IndianRed;
            this.button_start_server.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start_server.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start_server.ForeColor = System.Drawing.Color.White;
            this.button_start_server.Location = new System.Drawing.Point(22, 60);
            this.button_start_server.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_start_server.Name = "button_start_server";
            this.button_start_server.Size = new System.Drawing.Size(151, 53);
            this.button_start_server.TabIndex = 2;
            this.button_start_server.Text = "Start";
            this.button_start_server.UseVisualStyleBackColor = false;
            this.button_start_server.Click += new System.EventHandler(this.button_start_server_Click);
            // 
            // button_stop_server
            // 
            this.button_stop_server.BackColor = System.Drawing.Color.IndianRed;
            this.button_stop_server.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_stop_server.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop_server.ForeColor = System.Drawing.Color.White;
            this.button_stop_server.Location = new System.Drawing.Point(22, 134);
            this.button_stop_server.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_stop_server.Name = "button_stop_server";
            this.button_stop_server.Size = new System.Drawing.Size(151, 53);
            this.button_stop_server.TabIndex = 3;
            this.button_stop_server.Text = "Stop";
            this.button_stop_server.UseVisualStyleBackColor = false;
            this.button_stop_server.Click += new System.EventHandler(this.button_stop_server_Click);
            // 
            // textBox_server_local_IP
            // 
            this.textBox_server_local_IP.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_server_local_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_server_local_IP.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_server_local_IP.Location = new System.Drawing.Point(22, 360);
            this.textBox_server_local_IP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_server_local_IP.Name = "textBox_server_local_IP";
            this.textBox_server_local_IP.ReadOnly = true;
            this.textBox_server_local_IP.Size = new System.Drawing.Size(151, 30);
            this.textBox_server_local_IP.TabIndex = 4;
            // 
            // listView_log
            // 
            this.listView_log.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_log.HideSelection = false;
            this.listView_log.Location = new System.Drawing.Point(199, 13);
            this.listView_log.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_log.Name = "listView_log";
            this.listView_log.Size = new System.Drawing.Size(571, 398);
            this.listView_log.TabIndex = 4;
            this.listView_log.UseCompatibleStateImageBehavior = false;
            this.listView_log.View = System.Windows.Forms.View.List;
            // 
            // button_get_server_IP
            // 
            this.button_get_server_IP.BackColor = System.Drawing.Color.IndianRed;
            this.button_get_server_IP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_get_server_IP.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_get_server_IP.ForeColor = System.Drawing.Color.White;
            this.button_get_server_IP.Location = new System.Drawing.Point(22, 282);
            this.button_get_server_IP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_get_server_IP.Name = "button_get_server_IP";
            this.button_get_server_IP.Size = new System.Drawing.Size(151, 61);
            this.button_get_server_IP.TabIndex = 5;
            this.button_get_server_IP.Text = "Get server\'s IP address";
            this.button_get_server_IP.UseVisualStyleBackColor = false;
            this.button_get_server_IP.Click += new System.EventHandler(this.button_get_server_IP_Click);
            // 
            // label_user_count
            // 
            this.label_user_count.AutoSize = true;
            this.label_user_count.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_count.ForeColor = System.Drawing.Color.IndianRed;
            this.label_user_count.Location = new System.Drawing.Point(487, 421);
            this.label_user_count.Name = "label_user_count";
            this.label_user_count.Size = new System.Drawing.Size(113, 23);
            this.label_user_count.TabIndex = 6;
            this.label_user_count.Text = "Existing users";
            // 
            // textBox_user_count
            // 
            this.textBox_user_count.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_user_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_user_count.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user_count.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox_user_count.Location = new System.Drawing.Point(606, 419);
            this.textBox_user_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_user_count.Name = "textBox_user_count";
            this.textBox_user_count.ReadOnly = true;
            this.textBox_user_count.Size = new System.Drawing.Size(71, 30);
            this.textBox_user_count.TabIndex = 7;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.textBox_user_count);
            this.Controls.Add(this.label_user_count);
            this.Controls.Add(this.button_get_server_IP);
            this.Controls.Add(this.textBox_server_local_IP);
            this.Controls.Add(this.listView_log);
            this.Controls.Add(this.button_stop_server);
            this.Controls.Add(this.button_start_server);
            this.Controls.Add(this.textBox_room_count);
            this.Controls.Add(this.label_room_count);
            this.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_room_count;
        private System.Windows.Forms.TextBox textBox_room_count;
        private System.Windows.Forms.Button button_start_server;
        private System.Windows.Forms.Button button_stop_server;
        private System.Windows.Forms.TextBox textBox_server_local_IP;
        private System.Windows.Forms.ListView listView_log;
        private System.Windows.Forms.Button button_get_server_IP;
        private System.Windows.Forms.Label label_user_count;
        private System.Windows.Forms.TextBox textBox_user_count;
    }
}

