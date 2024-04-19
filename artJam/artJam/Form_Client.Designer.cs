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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Client));
            this.panel_main = new System.Windows.Forms.Panel();
            this.textBox_room_code = new System.Windows.Forms.TextBox();
            this.listView_room_users = new System.Windows.Forms.ListView();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.pictureBox_picking_color = new System.Windows.Forms.PictureBox();
            this.pictureBox_eraser = new System.Windows.Forms.PictureBox();
            this.button_pen = new System.Windows.Forms.Button();
            this.label_tools = new System.Windows.Forms.Label();
            this.label_shapes = new System.Windows.Forms.Label();
            this.button_shape_circle = new System.Windows.Forms.Button();
            this.button_shape_line = new System.Windows.Forms.Button();
            this.label_pen_size = new System.Windows.Forms.Label();
            this.button_shape_rectangle = new System.Windows.Forms.Button();
            this.label_colors = new System.Windows.Forms.Label();
            this.button_pen_width_3 = new System.Windows.Forms.Button();
            this.button_pen_width_2 = new System.Windows.Forms.Button();
            this.button_pen_width_1 = new System.Windows.Forms.Button();
            this.pictureBox_lime = new System.Windows.Forms.PictureBox();
            this.pictureBox_black = new System.Windows.Forms.PictureBox();
            this.pictureBox_cyan = new System.Windows.Forms.PictureBox();
            this.pictureBox_red = new System.Windows.Forms.PictureBox();
            this.pictureBox_yellow = new System.Windows.Forms.PictureBox();
            this.pictureBox_blue = new System.Windows.Forms.PictureBox();
            this.pictureBox_orange = new System.Windows.Forms.PictureBox();
            this.pictureBox_fuchsia = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_picking_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eraser)).BeginInit();
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
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.textBox_room_code);
            this.panel_main.Controls.Add(this.listView_room_users);
            this.panel_main.Controls.Add(this.Canvas);
            this.panel_main.Controls.Add(this.panel_top);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(882, 553);
            this.panel_main.TabIndex = 0;
            // 
            // textBox_room_code
            // 
            this.textBox_room_code.BackColor = System.Drawing.Color.Bisque;
            this.textBox_room_code.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_room_code.Location = new System.Drawing.Point(716, 123);
            this.textBox_room_code.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_room_code.Name = "textBox_room_code";
            this.textBox_room_code.ReadOnly = true;
            this.textBox_room_code.Size = new System.Drawing.Size(133, 30);
            this.textBox_room_code.TabIndex = 1;
            this.textBox_room_code.Visible = false;
            this.textBox_room_code.Click += new System.EventHandler(this.textBox_room_code_Click);
            // 
            // listView_room_users
            // 
            this.listView_room_users.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView_room_users.HideSelection = false;
            this.listView_room_users.Location = new System.Drawing.Point(716, 161);
            this.listView_room_users.Margin = new System.Windows.Forms.Padding(10);
            this.listView_room_users.Name = "listView_room_users";
            this.listView_room_users.Size = new System.Drawing.Size(133, 146);
            this.listView_room_users.TabIndex = 1;
            this.listView_room_users.UseCompatibleStateImageBehavior = false;
            this.listView_room_users.View = System.Windows.Forms.View.List;
            this.listView_room_users.Visible = false;
            // 
            // Canvas
            // 
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 111);
            this.Canvas.Margin = new System.Windows.Forms.Padding(5);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(882, 442);
            this.Canvas.TabIndex = 2;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.button_save);
            this.panel_top.Controls.Add(this.pictureBox_picking_color);
            this.panel_top.Controls.Add(this.pictureBox_eraser);
            this.panel_top.Controls.Add(this.button_pen);
            this.panel_top.Controls.Add(this.label_tools);
            this.panel_top.Controls.Add(this.label_shapes);
            this.panel_top.Controls.Add(this.button_shape_circle);
            this.panel_top.Controls.Add(this.button_shape_line);
            this.panel_top.Controls.Add(this.label_pen_size);
            this.panel_top.Controls.Add(this.button_shape_rectangle);
            this.panel_top.Controls.Add(this.label_colors);
            this.panel_top.Controls.Add(this.button_pen_width_3);
            this.panel_top.Controls.Add(this.button_pen_width_2);
            this.panel_top.Controls.Add(this.button_pen_width_1);
            this.panel_top.Controls.Add(this.pictureBox_lime);
            this.panel_top.Controls.Add(this.pictureBox_black);
            this.panel_top.Controls.Add(this.pictureBox_cyan);
            this.panel_top.Controls.Add(this.pictureBox_red);
            this.panel_top.Controls.Add(this.pictureBox_yellow);
            this.panel_top.Controls.Add(this.pictureBox_blue);
            this.panel_top.Controls.Add(this.pictureBox_orange);
            this.panel_top.Controls.Add(this.pictureBox_fuchsia);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(882, 111);
            this.panel_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Save";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Transparent;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.Location = new System.Drawing.Point(25, 21);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(50, 50);
            this.button_save.TabIndex = 21;
            this.button_save.Tag = "";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // pictureBox_picking_color
            // 
            this.pictureBox_picking_color.BackColor = System.Drawing.Color.Black;
            this.pictureBox_picking_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_picking_color.Location = new System.Drawing.Point(649, 17);
            this.pictureBox_picking_color.Name = "pictureBox_picking_color";
            this.pictureBox_picking_color.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_picking_color.TabIndex = 20;
            this.pictureBox_picking_color.TabStop = false;
            // 
            // pictureBox_eraser
            // 
            this.pictureBox_eraser.BackColor = System.Drawing.Color.White;
            this.pictureBox_eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_eraser.BackgroundImage")));
            this.pictureBox_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_eraser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_eraser.Image")));
            this.pictureBox_eraser.Location = new System.Drawing.Point(209, 21);
            this.pictureBox_eraser.Name = "pictureBox_eraser";
            this.pictureBox_eraser.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_eraser.TabIndex = 19;
            this.pictureBox_eraser.TabStop = false;
            this.pictureBox_eraser.Tag = "";
            this.pictureBox_eraser.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // button_pen
            // 
            this.button_pen.BackColor = System.Drawing.Color.Transparent;
            this.button_pen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pen.FlatAppearance.BorderSize = 0;
            this.button_pen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pen.Image = ((System.Drawing.Image)(resources.GetObject("button_pen.Image")));
            this.button_pen.Location = new System.Drawing.Point(125, 21);
            this.button_pen.Name = "button_pen";
            this.button_pen.Size = new System.Drawing.Size(50, 50);
            this.button_pen.TabIndex = 18;
            this.button_pen.Tag = "10";
            this.button_pen.UseVisualStyleBackColor = false;
            this.button_pen.Click += new System.EventHandler(this.button_shapes_Click);
            // 
            // label_tools
            // 
            this.label_tools.AutoSize = true;
            this.label_tools.Location = new System.Drawing.Point(167, 82);
            this.label_tools.Name = "label_tools";
            this.label_tools.Size = new System.Drawing.Size(49, 20);
            this.label_tools.TabIndex = 17;
            this.label_tools.Text = "Tools";
            // 
            // label_shapes
            // 
            this.label_shapes.AutoSize = true;
            this.label_shapes.Location = new System.Drawing.Point(476, 79);
            this.label_shapes.Name = "label_shapes";
            this.label_shapes.Size = new System.Drawing.Size(63, 20);
            this.label_shapes.TabIndex = 16;
            this.label_shapes.Text = "Shapes";
            // 
            // button_shape_circle
            // 
            this.button_shape_circle.BackColor = System.Drawing.Color.Transparent;
            this.button_shape_circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_shape_circle.FlatAppearance.BorderSize = 0;
            this.button_shape_circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shape_circle.Image = ((System.Drawing.Image)(resources.GetObject("button_shape_circle.Image")));
            this.button_shape_circle.Location = new System.Drawing.Point(549, 17);
            this.button_shape_circle.Name = "button_shape_circle";
            this.button_shape_circle.Size = new System.Drawing.Size(50, 50);
            this.button_shape_circle.TabIndex = 15;
            this.button_shape_circle.Tag = "13";
            this.button_shape_circle.UseVisualStyleBackColor = false;
            this.button_shape_circle.Click += new System.EventHandler(this.button_shapes_Click);
            // 
            // button_shape_line
            // 
            this.button_shape_line.BackColor = System.Drawing.Color.Transparent;
            this.button_shape_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_shape_line.FlatAppearance.BorderSize = 0;
            this.button_shape_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shape_line.Image = ((System.Drawing.Image)(resources.GetObject("button_shape_line.Image")));
            this.button_shape_line.Location = new System.Drawing.Point(405, 17);
            this.button_shape_line.Name = "button_shape_line";
            this.button_shape_line.Size = new System.Drawing.Size(50, 50);
            this.button_shape_line.TabIndex = 13;
            this.button_shape_line.Tag = "11";
            this.button_shape_line.UseVisualStyleBackColor = false;
            this.button_shape_line.Click += new System.EventHandler(this.button_shapes_Click);
            // 
            // label_pen_size
            // 
            this.label_pen_size.AutoSize = true;
            this.label_pen_size.Location = new System.Drawing.Point(320, 79);
            this.label_pen_size.Name = "label_pen_size";
            this.label_pen_size.Size = new System.Drawing.Size(39, 20);
            this.label_pen_size.TabIndex = 12;
            this.label_pen_size.Text = "Size";
            // 
            // button_shape_rectangle
            // 
            this.button_shape_rectangle.BackColor = System.Drawing.Color.Transparent;
            this.button_shape_rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_shape_rectangle.FlatAppearance.BorderSize = 0;
            this.button_shape_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shape_rectangle.Image = ((System.Drawing.Image)(resources.GetObject("button_shape_rectangle.Image")));
            this.button_shape_rectangle.Location = new System.Drawing.Point(477, 17);
            this.button_shape_rectangle.Name = "button_shape_rectangle";
            this.button_shape_rectangle.Size = new System.Drawing.Size(50, 50);
            this.button_shape_rectangle.TabIndex = 14;
            this.button_shape_rectangle.Tag = "12";
            this.button_shape_rectangle.UseVisualStyleBackColor = false;
            this.button_shape_rectangle.Click += new System.EventHandler(this.button_shapes_Click);
            // 
            // label_colors
            // 
            this.label_colors.AutoSize = true;
            this.label_colors.Location = new System.Drawing.Point(720, 82);
            this.label_colors.Name = "label_colors";
            this.label_colors.Size = new System.Drawing.Size(57, 20);
            this.label_colors.TabIndex = 11;
            this.label_colors.Text = "Colors";
            // 
            // button_pen_width_3
            // 
            this.button_pen_width_3.BackColor = System.Drawing.Color.Transparent;
            this.button_pen_width_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pen_width_3.FlatAppearance.BorderSize = 0;
            this.button_pen_width_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pen_width_3.Image = ((System.Drawing.Image)(resources.GetObject("button_pen_width_3.Image")));
            this.button_pen_width_3.Location = new System.Drawing.Point(312, 54);
            this.button_pen_width_3.Name = "button_pen_width_3";
            this.button_pen_width_3.Size = new System.Drawing.Size(50, 15);
            this.button_pen_width_3.TabIndex = 10;
            this.button_pen_width_3.Tag = "7";
            this.button_pen_width_3.UseVisualStyleBackColor = false;
            this.button_pen_width_3.Click += new System.EventHandler(this.button_pen_width_Click);
            // 
            // button_pen_width_2
            // 
            this.button_pen_width_2.BackColor = System.Drawing.Color.Transparent;
            this.button_pen_width_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pen_width_2.FlatAppearance.BorderSize = 0;
            this.button_pen_width_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pen_width_2.Image = ((System.Drawing.Image)(resources.GetObject("button_pen_width_2.Image")));
            this.button_pen_width_2.Location = new System.Drawing.Point(312, 33);
            this.button_pen_width_2.Name = "button_pen_width_2";
            this.button_pen_width_2.Size = new System.Drawing.Size(50, 15);
            this.button_pen_width_2.TabIndex = 9;
            this.button_pen_width_2.Tag = "4";
            this.button_pen_width_2.UseVisualStyleBackColor = false;
            this.button_pen_width_2.Click += new System.EventHandler(this.button_pen_width_Click);
            // 
            // button_pen_width_1
            // 
            this.button_pen_width_1.BackColor = System.Drawing.Color.Transparent;
            this.button_pen_width_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pen_width_1.FlatAppearance.BorderSize = 0;
            this.button_pen_width_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pen_width_1.Image = ((System.Drawing.Image)(resources.GetObject("button_pen_width_1.Image")));
            this.button_pen_width_1.Location = new System.Drawing.Point(312, 12);
            this.button_pen_width_1.Name = "button_pen_width_1";
            this.button_pen_width_1.Size = new System.Drawing.Size(50, 15);
            this.button_pen_width_1.TabIndex = 8;
            this.button_pen_width_1.Tag = "2";
            this.button_pen_width_1.UseVisualStyleBackColor = false;
            this.button_pen_width_1.Click += new System.EventHandler(this.button_pen_width_Click);
            // 
            // pictureBox_lime
            // 
            this.pictureBox_lime.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_lime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_lime.Location = new System.Drawing.Point(716, 46);
            this.pictureBox_lime.Name = "pictureBox_lime";
            this.pictureBox_lime.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_lime.TabIndex = 7;
            this.pictureBox_lime.TabStop = false;
            this.pictureBox_lime.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_black
            // 
            this.pictureBox_black.BackColor = System.Drawing.Color.Black;
            this.pictureBox_black.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_black.Location = new System.Drawing.Point(716, 11);
            this.pictureBox_black.Name = "pictureBox_black";
            this.pictureBox_black.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_black.TabIndex = 6;
            this.pictureBox_black.TabStop = false;
            this.pictureBox_black.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_cyan
            // 
            this.pictureBox_cyan.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox_cyan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_cyan.Location = new System.Drawing.Point(752, 46);
            this.pictureBox_cyan.Name = "pictureBox_cyan";
            this.pictureBox_cyan.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_cyan.TabIndex = 5;
            this.pictureBox_cyan.TabStop = false;
            this.pictureBox_cyan.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_red
            // 
            this.pictureBox_red.BackColor = System.Drawing.Color.Red;
            this.pictureBox_red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_red.Location = new System.Drawing.Point(752, 11);
            this.pictureBox_red.Name = "pictureBox_red";
            this.pictureBox_red.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_red.TabIndex = 4;
            this.pictureBox_red.TabStop = false;
            this.pictureBox_red.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_yellow
            // 
            this.pictureBox_yellow.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox_yellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_yellow.Location = new System.Drawing.Point(824, 11);
            this.pictureBox_yellow.Name = "pictureBox_yellow";
            this.pictureBox_yellow.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_yellow.TabIndex = 3;
            this.pictureBox_yellow.TabStop = false;
            this.pictureBox_yellow.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_blue
            // 
            this.pictureBox_blue.BackColor = System.Drawing.Color.Blue;
            this.pictureBox_blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_blue.Location = new System.Drawing.Point(788, 46);
            this.pictureBox_blue.Name = "pictureBox_blue";
            this.pictureBox_blue.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_blue.TabIndex = 2;
            this.pictureBox_blue.TabStop = false;
            this.pictureBox_blue.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_orange
            // 
            this.pictureBox_orange.BackColor = System.Drawing.Color.Orange;
            this.pictureBox_orange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_orange.Location = new System.Drawing.Point(788, 11);
            this.pictureBox_orange.Name = "pictureBox_orange";
            this.pictureBox_orange.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_orange.TabIndex = 1;
            this.pictureBox_orange.TabStop = false;
            this.pictureBox_orange.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // pictureBox_fuchsia
            // 
            this.pictureBox_fuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox_fuchsia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_fuchsia.Location = new System.Drawing.Point(824, 46);
            this.pictureBox_fuchsia.Name = "pictureBox_fuchsia";
            this.pictureBox_fuchsia.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_fuchsia.TabIndex = 0;
            this.pictureBox_fuchsia.TabStop = false;
            this.pictureBox_fuchsia.Click += new System.EventHandler(this.pictureBox_black_Click);
            // 
            // Form_Client
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "artJam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Client_FormClosed);
            this.Load += new System.EventHandler(this.Form_Client_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_picking_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eraser)).EndInit();
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

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.TextBox textBox_room_code;
        private System.Windows.Forms.ListView listView_room_users;
        private System.Windows.Forms.Button button_pen_width_3;
        private System.Windows.Forms.Button button_pen_width_2;
        private System.Windows.Forms.Button button_pen_width_1;
        private System.Windows.Forms.Label label_pen_size;
        private System.Windows.Forms.Label label_colors;
        private System.Windows.Forms.PictureBox pictureBox_lime;
        private System.Windows.Forms.PictureBox pictureBox_black;
        private System.Windows.Forms.PictureBox pictureBox_cyan;
        private System.Windows.Forms.PictureBox pictureBox_red;
        private System.Windows.Forms.PictureBox pictureBox_yellow;
        private System.Windows.Forms.PictureBox pictureBox_blue;
        private System.Windows.Forms.PictureBox pictureBox_orange;
        private System.Windows.Forms.PictureBox pictureBox_fuchsia;
        private System.Windows.Forms.Button button_shape_line;
        private System.Windows.Forms.Button button_shape_circle;
        private System.Windows.Forms.Button button_shape_rectangle;
        private System.Windows.Forms.Label label_shapes;
        private System.Windows.Forms.Button button_pen;
        private System.Windows.Forms.Label label_tools;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.PictureBox pictureBox_eraser;
        private System.Windows.Forms.PictureBox pictureBox_picking_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_save;
    }
}