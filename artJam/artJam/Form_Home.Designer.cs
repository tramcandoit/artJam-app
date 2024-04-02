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
            this.SuspendLayout();
            // 
            // button_create_room
            // 
            this.button_create_room.Location = new System.Drawing.Point(267, 53);
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
            this.button_join_room.Location = new System.Drawing.Point(434, 53);
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
            this.richTextBox_nickname.Location = new System.Drawing.Point(267, 131);
            this.richTextBox_nickname.Name = "richTextBox_nickname";
            this.richTextBox_nickname.Size = new System.Drawing.Size(272, 43);
            this.richTextBox_nickname.TabIndex = 3;
            this.richTextBox_nickname.Text = "";
            this.richTextBox_nickname.Visible = false;
            // 
            // richTextBox_code_room
            // 
            this.richTextBox_code_room.Location = new System.Drawing.Point(267, 230);
            this.richTextBox_code_room.Name = "richTextBox_code_room";
            this.richTextBox_code_room.Size = new System.Drawing.Size(272, 43);
            this.richTextBox_code_room.TabIndex = 3;
            this.richTextBox_code_room.Text = "";
            this.richTextBox_code_room.Visible = false;
            // 
            // label_nickname
            // 
            this.label_nickname.AutoSize = true;
            this.label_nickname.Location = new System.Drawing.Point(175, 158);
            this.label_nickname.Name = "label_nickname";
            this.label_nickname.Size = new System.Drawing.Size(68, 16);
            this.label_nickname.TabIndex = 5;
            this.label_nickname.Text = "Nickname";
            this.label_nickname.Visible = false;
            // 
            // label_code_room
            // 
            this.label_code_room.AutoSize = true;
            this.label_code_room.Location = new System.Drawing.Point(176, 257);
            this.label_code_room.Name = "label_code_room";
            this.label_code_room.Size = new System.Drawing.Size(67, 16);
            this.label_code_room.TabIndex = 6;
            this.label_code_room.Text = "Mã phòng";
            this.label_code_room.Visible = false;
            // 
            // button_go_join_room
            // 
            this.button_go_join_room.Location = new System.Drawing.Point(493, 279);
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
            this.button_go_create_room.Location = new System.Drawing.Point(493, 180);
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
            this.button_start.Location = new System.Drawing.Point(365, 191);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 8;
            this.button_start.Text = "Bắt đầu";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

