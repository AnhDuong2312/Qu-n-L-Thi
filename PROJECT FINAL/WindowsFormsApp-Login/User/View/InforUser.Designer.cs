﻿namespace WindowsFormsApp_Login.User.View
{
    partial class InforUser
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FullName = new RJCodeAdvance.RJControls.RJButton();
            this.xepHang = new System.Windows.Forms.Label();
            this.ketQua = new System.Windows.Forms.Label();
            this.vaoThi = new System.Windows.Forms.Label();
            this.trangChu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjDropdownMenu1 = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.vàoThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.reset = new RJCodeAdvance.RJControls.RJButton();
            this.sua = new RJCodeAdvance.RJControls.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.rjDropdownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.FullName);
            this.panel1.Controls.Add(this.xepHang);
            this.panel1.Controls.Add(this.ketQua);
            this.panel1.Controls.Add(this.vaoThi);
            this.panel1.Controls.Add(this.trangChu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(86, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 82);
            this.panel1.TabIndex = 4;
           
            // 
            // FullName
            // 
            this.FullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.FullName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.FullName.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.FullName.BorderRadius = 0;
            this.FullName.BorderSize = 0;
            this.FullName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullName.FlatAppearance.BorderSize = 0;
            this.FullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.ForeColor = System.Drawing.Color.White;
            this.FullName.Location = new System.Drawing.Point(583, 25);
            this.FullName.Margin = new System.Windows.Forms.Padding(2);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(198, 36);
            this.FullName.TabIndex = 5;
            this.FullName.Text = "Nguyễn Minh Quân";
            this.FullName.TextColor = System.Drawing.Color.White;
            this.FullName.UseVisualStyleBackColor = false;
            this.FullName.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // xepHang
            // 
            this.xepHang.AutoSize = true;
            this.xepHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xepHang.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xepHang.ForeColor = System.Drawing.Color.White;
            this.xepHang.Location = new System.Drawing.Point(474, 31);
            this.xepHang.Name = "xepHang";
            this.xepHang.Size = new System.Drawing.Size(90, 22);
            this.xepHang.TabIndex = 4;
            this.xepHang.Text = "Xếp hạng";
            this.xepHang.Click += new System.EventHandler(this.xepHang_Click);
            // 
            // ketQua
            // 
            this.ketQua.AutoSize = true;
            this.ketQua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ketQua.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketQua.ForeColor = System.Drawing.Color.White;
            this.ketQua.Location = new System.Drawing.Point(371, 31);
            this.ketQua.Name = "ketQua";
            this.ketQua.Size = new System.Drawing.Size(76, 22);
            this.ketQua.TabIndex = 3;
            this.ketQua.Text = "Kết quả";
            this.ketQua.Click += new System.EventHandler(this.ketQua_Click);
            // 
            // vaoThi
            // 
            this.vaoThi.AutoSize = true;
            this.vaoThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vaoThi.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaoThi.ForeColor = System.Drawing.Color.White;
            this.vaoThi.Location = new System.Drawing.Point(286, 31);
            this.vaoThi.Name = "vaoThi";
            this.vaoThi.Size = new System.Drawing.Size(69, 22);
            this.vaoThi.TabIndex = 2;
            this.vaoThi.Text = "Vào thi";
            this.vaoThi.Click += new System.EventHandler(this.vaoThi_Click);
            // 
            // trangChu
            // 
            this.trangChu.AutoSize = true;
            this.trangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trangChu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChu.ForeColor = System.Drawing.Color.White;
            this.trangChu.Location = new System.Drawing.Point(175, 31);
            this.trangChu.Name = "trangChu";
            this.trangChu.Size = new System.Drawing.Size(94, 22);
            this.trangChu.TabIndex = 1;
            this.trangChu.Text = "Trang chủ";
            this.trangChu.Click += new System.EventHandler(this.trangChu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "QuizPro";
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu1.IsMainMenu = true;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vàoThiToolStripMenuItem,
            this.thayĐổiThôngTinToolStripMenuItem,
            this.thayĐổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.rjDropdownMenu1.Size = new System.Drawing.Size(189, 92);
            // 
            // vàoThiToolStripMenuItem
            // 
            this.vàoThiToolStripMenuItem.Name = "vàoThiToolStripMenuItem";
            this.vàoThiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.vàoThiToolStripMenuItem.Text = "Vào thi";
            this.vàoThiToolStripMenuItem.Click += new System.EventHandler(this.vàoThiToolStripMenuItem_Click);
            // 
            // thayĐổiThôngTinToolStripMenuItem
            // 
            this.thayĐổiThôngTinToolStripMenuItem.Name = "thayĐổiThôngTinToolStripMenuItem";
            this.thayĐổiThôngTinToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.thayĐổiThôngTinToolStripMenuItem.Text = "Thay đổi thông tin";
            this.thayĐổiThôngTinToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiThôngTinToolStripMenuItem_Click);
            // 
            // thayĐổiMậtKhẩuToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.thayĐổiMậtKhẩuToolStripMenuItem.Text = "Thay đổi mật khẩu";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.label6.Location = new System.Drawing.Point(263, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "THAY ĐỔI THÔNG TIN CÁ NHÂN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tên đăng nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Họ và tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(174, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Số điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(174, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Địa chỉ email";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.White;
            this.reset.BackgroundColor = System.Drawing.Color.White;
            this.reset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.reset.BorderRadius = 10;
            this.reset.BorderSize = 2;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.reset.Location = new System.Drawing.Point(268, 413);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(150, 40);
            this.reset.TabIndex = 19;
            this.reset.Text = "Làm lại";
            this.reset.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.sua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(12)))));
            this.sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sua.BorderRadius = 10;
            this.sua.BorderSize = 0;
            this.sua.FlatAppearance.BorderSize = 0;
            this.sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sua.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.ForeColor = System.Drawing.Color.White;
            this.sua.Location = new System.Drawing.Point(469, 413);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(150, 40);
            this.sua.TabIndex = 20;
            this.sua.Text = "Sửa đổi";
            this.sua.TextColor = System.Drawing.Color.White;
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp_Login.Properties.Resources._21504082051;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
           
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(327, 211);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 31);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(327, 248);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(385, 32);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(327, 286);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(385, 33);
            this.textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(327, 325);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(385, 32);
            this.textBox4.TabIndex = 24;
            // 
            // InforUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 541);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "InforUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InforUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rjDropdownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton FullName;
        private System.Windows.Forms.Label xepHang;
        private System.Windows.Forms.Label ketQua;
        private System.Windows.Forms.Label vaoThi;
        private System.Windows.Forms.Label trangChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJCodeAdvance.RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem vàoThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private RJCodeAdvance.RJControls.RJButton reset;
        private RJCodeAdvance.RJControls.RJButton sua;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}