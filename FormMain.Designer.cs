namespace HotelManagement
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            labelTenKhachSan = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblTenNguoiDung = new Label();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            panelMain = new Panel();
            panel4 = new Panel();
            button13 = new Button();
            btnTrangChu = new Button();
            button5 = new Button();
            button4 = new Button();
            button7 = new Button();
            button6 = new Button();
            btnQuanLyPhong = new Button();
            button12 = new Button();
            button11 = new Button();
            btnSoDoPhong = new Button();
            button9 = new Button();
            button10 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(labelTenKhachSan);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 92);
            panel1.TabIndex = 0;
            // 
            // labelTenKhachSan
            // 
            labelTenKhachSan.AutoSize = true;
            labelTenKhachSan.BackColor = Color.Transparent;
            labelTenKhachSan.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTenKhachSan.ForeColor = Color.LightSalmon;
            labelTenKhachSan.Location = new Point(66, 25);
            labelTenKhachSan.Name = "labelTenKhachSan";
            labelTenKhachSan.Size = new Size(285, 41);
            labelTenKhachSan.TabIndex = 3;
            labelTenKhachSan.Text = "Hotel Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Menu;
            pictureBox1.Location = new Point(12, 18);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(lblTenNguoiDung);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(linkLabel1);
            panel2.Location = new Point(0, 92);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 198);
            panel2.TabIndex = 1;
            // 
            // lblTenNguoiDung
            // 
            lblTenNguoiDung.AutoSize = true;
            lblTenNguoiDung.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenNguoiDung.ForeColor = Color.White;
            lblTenNguoiDung.Location = new Point(28, 159);
            lblTenNguoiDung.Name = "lblTenNguoiDung";
            lblTenNguoiDung.Size = new Size(76, 26);
            lblTenNguoiDung.TabIndex = 2;
            lblTenNguoiDung.Text = "Admin";
            lblTenNguoiDung.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(101, 35);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.MidnightBlue;
            linkLabel1.LinkColor = Color.MidnightBlue;
            linkLabel1.Location = new Point(4, 8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(101, 25);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng xuất";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.Honeydew;
            panelMain.Location = new Point(310, 98);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1280, 890);
            panelMain.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.BackColor = Color.DarkCyan;
            panel4.Controls.Add(button13);
            panel4.Controls.Add(btnTrangChu);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(btnQuanLyPhong);
            panel4.Controls.Add(button12);
            panel4.Controls.Add(button11);
            panel4.Controls.Add(btnSoDoPhong);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button10);
            panel4.Location = new Point(0, 290);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 700);
            panel4.TabIndex = 4;
            // 
            // button13
            // 
            button13.BackColor = Color.DarkCyan;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.ForeColor = SystemColors.ButtonHighlight;
            button13.Image = Properties.Resources.MenuThongKe;
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(0, 605);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Padding = new Padding(10, 0, 0, 0);
            button13.Size = new Size(304, 51);
            button13.TabIndex = 16;
            button13.Text = "      Thống kê";
            button13.TextAlign = ContentAlignment.MiddleLeft;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.DarkCyan;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTrangChu.ForeColor = SystemColors.ButtonHighlight;
            btnTrangChu.Image = Properties.Resources.MenuTrangChu;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Margin = new Padding(3, 4, 3, 4);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Padding = new Padding(10, 0, 0, 0);
            btnTrangChu.Size = new Size(304, 55);
            btnTrangChu.TabIndex = 3;
            btnTrangChu.Text = "      Trang chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkCyan;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = Properties.Resources.MenuQuanLyTaiKhoan;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 550);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(304, 51);
            button5.TabIndex = 8;
            button5.Text = "      Danh sách tài khoản";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkCyan;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.MenuLoaiPhong;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 165);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(304, 51);
            button4.TabIndex = 7;
            button4.Text = "      Loại phòng";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkCyan;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Image = Properties.Resources.MenuQuanLyNhanVien;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 495);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Padding = new Padding(10, 0, 0, 0);
            button7.Size = new Size(304, 51);
            button7.TabIndex = 10;
            button7.Text = "      Danh sách nhân viên";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkCyan;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Image = Properties.Resources.MenuQuanLyKhachHang;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 440);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(304, 51);
            button6.TabIndex = 9;
            button6.Text = "      Danh sách khách hàng";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // btnQuanLyPhong
            // 
            btnQuanLyPhong.BackColor = Color.DarkCyan;
            btnQuanLyPhong.FlatAppearance.BorderSize = 0;
            btnQuanLyPhong.FlatStyle = FlatStyle.Flat;
            btnQuanLyPhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuanLyPhong.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyPhong.Image = Properties.Resources.MenuPhong;
            btnQuanLyPhong.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanLyPhong.Location = new Point(0, 110);
            btnQuanLyPhong.Margin = new Padding(3, 4, 3, 4);
            btnQuanLyPhong.Name = "btnQuanLyPhong";
            btnQuanLyPhong.Padding = new Padding(10, 0, 0, 0);
            btnQuanLyPhong.Size = new Size(304, 51);
            btnQuanLyPhong.TabIndex = 6;
            btnQuanLyPhong.Text = "      Phòng";
            btnQuanLyPhong.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyPhong.UseVisualStyleBackColor = false;
            btnQuanLyPhong.Click += btnQuanLyPhong_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.DarkCyan;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Image = Properties.Resources.MenuTienNghi;
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(0, 385);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Padding = new Padding(10, 0, 0, 0);
            button12.Size = new Size(304, 51);
            button12.TabIndex = 15;
            button12.Text = "      Danh sách tiện nghi";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.DarkCyan;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Image = Properties.Resources.MenuQuanLyDichVu;
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(0, 330);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Padding = new Padding(10, 0, 0, 0);
            button11.Size = new Size(304, 51);
            button11.TabIndex = 14;
            button11.Text = "      Danh sách dịch vụ";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // btnSoDoPhong
            // 
            btnSoDoPhong.AllowDrop = true;
            btnSoDoPhong.BackColor = Color.DarkCyan;
            btnSoDoPhong.FlatAppearance.BorderSize = 0;
            btnSoDoPhong.FlatStyle = FlatStyle.Flat;
            btnSoDoPhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSoDoPhong.ForeColor = SystemColors.ButtonHighlight;
            btnSoDoPhong.Image = Properties.Resources.MenuSoDoPhong;
            btnSoDoPhong.ImageAlign = ContentAlignment.MiddleLeft;
            btnSoDoPhong.Location = new Point(0, 55);
            btnSoDoPhong.Margin = new Padding(3, 4, 3, 4);
            btnSoDoPhong.Name = "btnSoDoPhong";
            btnSoDoPhong.Padding = new Padding(10, 0, 0, 0);
            btnSoDoPhong.Size = new Size(304, 51);
            btnSoDoPhong.TabIndex = 5;
            btnSoDoPhong.Text = "      Sơ đồ phòng";
            btnSoDoPhong.TextAlign = ContentAlignment.MiddleLeft;
            btnSoDoPhong.UseVisualStyleBackColor = false;
            btnSoDoPhong.Click += btnSoDoPhong_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkCyan;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Image = Properties.Resources.MenuDatPhong;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(0, 220);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Padding = new Padding(10, 0, 0, 0);
            button9.Size = new Size(304, 51);
            button9.TabIndex = 12;
            button9.Text = "      Danh sách đặt phòng";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.DarkCyan;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Image = Properties.Resources.MenuDanhSachHoaDon;
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(0, 275);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Padding = new Padding(10, 0, 0, 0);
            button10.Size = new Size(304, 51);
            button10.TabIndex = 13;
            button10.Text = "      Danh sách hóa đơn";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1600, 1000);
            Controls.Add(panel4);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management - Quản lý khách sạn";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTenKhachSan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnQuanLyPhong;
        private System.Windows.Forms.Button btnSoDoPhong;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button13;
    }
}
