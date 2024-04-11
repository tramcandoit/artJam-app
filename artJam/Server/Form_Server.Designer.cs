namespace Server
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
            this.label_room_count = new System.Windows.Forms.Label();
            this.textBox_room_count = new System.Windows.Forms.TextBox();
            this.button_start_server = new System.Windows.Forms.Button();
            this.button_stop_server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_room_count
            // 
            this.label_room_count.AutoSize = true;
            this.label_room_count.Location = new System.Drawing.Point(438, 59);
            this.label_room_count.Name = "label_room_count";
            this.label_room_count.Size = new System.Drawing.Size(111, 16);
            this.label_room_count.TabIndex = 0;
            this.label_room_count.Text = "Số phòng hiện có";
            // 
            // textBox_room_count
            // 
            this.textBox_room_count.Location = new System.Drawing.Point(586, 59);
            this.textBox_room_count.Name = "textBox_room_count";
            this.textBox_room_count.Size = new System.Drawing.Size(100, 22);
            this.textBox_room_count.TabIndex = 1;
            // 
            // button_start_server
            // 
            this.button_start_server.Location = new System.Drawing.Point(211, 146);
            this.button_start_server.Name = "button_start_server";
            this.button_start_server.Size = new System.Drawing.Size(75, 23);
            this.button_start_server.TabIndex = 2;
            this.button_start_server.Text = "Start";
            this.button_start_server.UseVisualStyleBackColor = true;
            this.button_start_server.Click += new System.EventHandler(this.button_start_server_Click);
            // 
            // button_stop_server
            // 
            this.button_stop_server.Location = new System.Drawing.Point(211, 203);
            this.button_stop_server.Name = "button_stop_server";
            this.button_stop_server.Size = new System.Drawing.Size(75, 23);
            this.button_stop_server.TabIndex = 3;
            this.button_stop_server.Text = "Stop";
            this.button_stop_server.UseVisualStyleBackColor = true;
            this.button_stop_server.Click += new System.EventHandler(this.button_stop_server_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_stop_server);
            this.Controls.Add(this.button_start_server);
            this.Controls.Add(this.textBox_room_count);
            this.Controls.Add(this.label_room_count);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_room_count;
        private System.Windows.Forms.TextBox textBox_room_count;
        private System.Windows.Forms.Button button_start_server;
        private System.Windows.Forms.Button button_stop_server;
    }
}

