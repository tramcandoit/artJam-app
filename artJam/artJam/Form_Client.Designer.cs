namespace artJam
{
    partial class Form_Client
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
            this.panel_canvas = new System.Windows.Forms.Panel();
            this.textBox_room_code = new System.Windows.Forms.TextBox();
            this.panel_color = new System.Windows.Forms.Panel();
            this.pictureBox_lime = new System.Windows.Forms.PictureBox();
            this.pictureBox_black = new System.Windows.Forms.PictureBox();
            this.pictureBox_cyan = new System.Windows.Forms.PictureBox();
            this.pictureBox_red = new System.Windows.Forms.PictureBox();
            this.pictureBox_yellow = new System.Windows.Forms.PictureBox();
            this.pictureBox_blue = new System.Windows.Forms.PictureBox();
            this.pictureBox_orange = new System.Windows.Forms.PictureBox();
            this.pictureBox_fuchsia = new System.Windows.Forms.PictureBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_canvas.SuspendLayout();
            this.panel_color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fuchsia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_canvas
            // 
            this.panel_canvas.BackColor = System.Drawing.Color.White;
            this.panel_canvas.Controls.Add(this.panel_color);
            this.panel_canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_canvas.Location = new System.Drawing.Point(0, 0);
            this.panel_canvas.Name = "panel_canvas";
            this.panel_canvas.Size = new System.Drawing.Size(882, 553);
            this.panel_canvas.TabIndex = 0;
            this.panel_canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_canvas_MouseDown);
            this.panel_canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_canvas_MouseMove);
            this.panel_canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_canvas_MouseUp);
            // 
            // textBox_room_code
            // 
            this.textBox_room_code.Enabled = false;
            this.textBox_room_code.Location = new System.Drawing.Point(373, 44);
            this.textBox_room_code.Name = "textBox_room_code";
            this.textBox_room_code.ReadOnly = true;
            this.textBox_room_code.Size = new System.Drawing.Size(127, 22);
            this.textBox_room_code.TabIndex = 1;
            // 
            // panel_color
            // 
            this.panel_color.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_color.Controls.Add(this.label1);
            this.panel_color.Controls.Add(this.listView1);
            this.panel_color.Controls.Add(this.textBox_username);
            this.panel_color.Controls.Add(this.textBox_room_code);
            this.panel_color.Controls.Add(this.pictureBox_lime);
            this.panel_color.Controls.Add(this.pictureBox_black);
            this.panel_color.Controls.Add(this.pictureBox_cyan);
            this.panel_color.Controls.Add(this.pictureBox_red);
            this.panel_color.Controls.Add(this.pictureBox_yellow);
            this.panel_color.Controls.Add(this.pictureBox_blue);
            this.panel_color.Controls.Add(this.pictureBox_orange);
            this.panel_color.Controls.Add(this.pictureBox_fuchsia);
            this.panel_color.Location = new System.Drawing.Point(3, 3);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(876, 73);
            this.panel_color.TabIndex = 0;
            // 
            // pictureBox_lime
            // 
            this.pictureBox_lime.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_lime.Location = new System.Drawing.Point(3, 38);
            this.pictureBox_lime.Name = "pictureBox_lime";
            this.pictureBox_lime.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_lime.TabIndex = 7;
            this.pictureBox_lime.TabStop = false;
            this.pictureBox_lime.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_black
            // 
            this.pictureBox_black.BackColor = System.Drawing.Color.Black;
            this.pictureBox_black.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_black.Name = "pictureBox_black";
            this.pictureBox_black.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_black.TabIndex = 6;
            this.pictureBox_black.TabStop = false;
            this.pictureBox_black.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_cyan
            // 
            this.pictureBox_cyan.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox_cyan.Location = new System.Drawing.Point(39, 38);
            this.pictureBox_cyan.Name = "pictureBox_cyan";
            this.pictureBox_cyan.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_cyan.TabIndex = 5;
            this.pictureBox_cyan.TabStop = false;
            this.pictureBox_cyan.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_red
            // 
            this.pictureBox_red.BackColor = System.Drawing.Color.Red;
            this.pictureBox_red.Location = new System.Drawing.Point(39, 3);
            this.pictureBox_red.Name = "pictureBox_red";
            this.pictureBox_red.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_red.TabIndex = 4;
            this.pictureBox_red.TabStop = false;
            this.pictureBox_red.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_yellow
            // 
            this.pictureBox_yellow.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox_yellow.Location = new System.Drawing.Point(111, 3);
            this.pictureBox_yellow.Name = "pictureBox_yellow";
            this.pictureBox_yellow.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_yellow.TabIndex = 3;
            this.pictureBox_yellow.TabStop = false;
            this.pictureBox_yellow.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_blue
            // 
            this.pictureBox_blue.BackColor = System.Drawing.Color.Blue;
            this.pictureBox_blue.Location = new System.Drawing.Point(75, 38);
            this.pictureBox_blue.Name = "pictureBox_blue";
            this.pictureBox_blue.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_blue.TabIndex = 2;
            this.pictureBox_blue.TabStop = false;
            this.pictureBox_blue.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_orange
            // 
            this.pictureBox_orange.BackColor = System.Drawing.Color.Orange;
            this.pictureBox_orange.Location = new System.Drawing.Point(75, 3);
            this.pictureBox_orange.Name = "pictureBox_orange";
            this.pictureBox_orange.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_orange.TabIndex = 1;
            this.pictureBox_orange.TabStop = false;
            this.pictureBox_orange.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_fuchsia
            // 
            this.pictureBox_fuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox_fuchsia.Location = new System.Drawing.Point(111, 38);
            this.pictureBox_fuchsia.Name = "pictureBox_fuchsia";
            this.pictureBox_fuchsia.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_fuchsia.TabIndex = 0;
            this.pictureBox_fuchsia.TabStop = false;
            this.pictureBox_fuchsia.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Enabled = false;
            this.textBox_username.Location = new System.Drawing.Point(373, 9);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.ReadOnly = true;
            this.textBox_username.Size = new System.Drawing.Size(127, 22);
            this.textBox_username.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(650, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(217, 65);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Online";
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panel_canvas);
            this.MaximizeBox = false;
            this.Name = "Form_Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Client_FormClosed);
            this.Load += new System.EventHandler(this.Form_Client_Load);
            this.panel_canvas.ResumeLayout(false);
            this.panel_color.ResumeLayout(false);
            this.panel_color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fuchsia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_canvas;
        private System.Windows.Forms.Panel panel_color;
        private System.Windows.Forms.PictureBox pictureBox_fuchsia;
        private System.Windows.Forms.PictureBox pictureBox_lime;
        private System.Windows.Forms.PictureBox pictureBox_black;
        private System.Windows.Forms.PictureBox pictureBox_cyan;
        private System.Windows.Forms.PictureBox pictureBox_red;
        private System.Windows.Forms.PictureBox pictureBox_yellow;
        private System.Windows.Forms.PictureBox pictureBox_blue;
        private System.Windows.Forms.PictureBox pictureBox_orange;
        private System.Windows.Forms.TextBox textBox_room_code;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}