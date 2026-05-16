namespace FormBai3
{
    partial class QLCuaHangMini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLCuaHangMini));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDangNhap = new System.Windows.Forms.ToolStripButton();
            this.tsbDangXuat = new System.Windows.Forms.ToolStripButton();
            this.tsbThoat = new System.Windows.Forms.ToolStripButton();
            this.tsbNhanVien = new System.Windows.Forms.ToolStripButton();
            this.tsbSanPham = new System.Windows.Forms.ToolStripButton();
            this.tsbHoaDon = new System.Windows.Forms.ToolStripButton();
            this.tsbTroGiup = new System.Windows.Forms.ToolStripButton();
            this.tsbLienHe = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tslTimKiem = new System.Windows.Forms.ToolStripLabel();
            this.tstbTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMoLai = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThoatChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.pbKohKong = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKohKong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHeThong,
            this.tsmiQuanLy,
            this.tsmiTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1762, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "MenuMain";
            // 
            // tsmiHeThong
            // 
            this.tsmiHeThong.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDangNhap,
            this.tsmiDangXuat,
            this.tsmiThoat});
            this.tsmiHeThong.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiHeThong.Name = "tsmiHeThong";
            this.tsmiHeThong.Size = new System.Drawing.Size(115, 32);
            this.tsmiHeThong.Text = "&Hệ thống";
            // 
            // tsmiDangNhap
            // 
            this.tsmiDangNhap.Name = "tsmiDangNhap";
            this.tsmiDangNhap.Size = new System.Drawing.Size(270, 36);
            this.tsmiDangNhap.Text = "&Đăng nhập";
            this.tsmiDangNhap.Click += new System.EventHandler(this.tsmiDangNhap_Click);
            // 
            // tsmiDangXuat
            // 
            this.tsmiDangXuat.Name = "tsmiDangXuat";
            this.tsmiDangXuat.Size = new System.Drawing.Size(270, 36);
            this.tsmiDangXuat.Text = "&Đăng xuất";
            this.tsmiDangXuat.Click += new System.EventHandler(this.tsmiDangXuat_Click);
            // 
            // tsmiThoat
            // 
            this.tsmiThoat.Name = "tsmiThoat";
            this.tsmiThoat.Size = new System.Drawing.Size(270, 36);
            this.tsmiThoat.Text = "&Thoát";
            this.tsmiThoat.Click += new System.EventHandler(this.tsmiThoat_Click);
            // 
            // tsmiQuanLy
            // 
            this.tsmiQuanLy.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNhanVien,
            this.tsmiSanPham,
            this.tsmiHoaDon});
            this.tsmiQuanLy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiQuanLy.Name = "tsmiQuanLy";
            this.tsmiQuanLy.Size = new System.Drawing.Size(98, 32);
            this.tsmiQuanLy.Text = "&Quản lý";
            // 
            // tsmiNhanVien
            // 
            this.tsmiNhanVien.Name = "tsmiNhanVien";
            this.tsmiNhanVien.Size = new System.Drawing.Size(207, 36);
            this.tsmiNhanVien.Text = "Nhân viên";
            this.tsmiNhanVien.Click += new System.EventHandler(this.tsmiNhanVien_Click);
            // 
            // tsmiSanPham
            // 
            this.tsmiSanPham.Name = "tsmiSanPham";
            this.tsmiSanPham.Size = new System.Drawing.Size(207, 36);
            this.tsmiSanPham.Text = "Sản phẩm";
            this.tsmiSanPham.Click += new System.EventHandler(this.tsmiSanPham_Click);
            // 
            // tsmiHoaDon
            // 
            this.tsmiHoaDon.Name = "tsmiHoaDon";
            this.tsmiHoaDon.Size = new System.Drawing.Size(207, 36);
            this.tsmiHoaDon.Text = "Hóa đơn";
            this.tsmiHoaDon.Click += new System.EventHandler(this.tsmiHoaDon_Click);
            // 
            // tsmiTroGiup
            // 
            this.tsmiTroGiup.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGioiThieu,
            this.tsmiLienHe});
            this.tsmiTroGiup.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiTroGiup.Name = "tsmiTroGiup";
            this.tsmiTroGiup.Size = new System.Drawing.Size(103, 32);
            this.tsmiTroGiup.Text = "&Trợ giúp";
            // 
            // tsmiGioiThieu
            // 
            this.tsmiGioiThieu.Name = "tsmiGioiThieu";
            this.tsmiGioiThieu.Size = new System.Drawing.Size(203, 36);
            this.tsmiGioiThieu.Text = "Giới thiệu";
            this.tsmiGioiThieu.Click += new System.EventHandler(this.tsmiGioiThieu_Click);
            // 
            // tsmiLienHe
            // 
            this.tsmiLienHe.Name = "tsmiLienHe";
            this.tsmiLienHe.Size = new System.Drawing.Size(203, 36);
            this.tsmiLienHe.Text = "Liên hệ";
            this.tsmiLienHe.Click += new System.EventHandler(this.tsmiLienHe_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDangNhap,
            this.tsbDangXuat,
            this.tsbThoat,
            this.tsbNhanVien,
            this.tsbSanPham,
            this.tsbHoaDon,
            this.tsbTroGiup,
            this.tsbLienHe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1762, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDangNhap
            // 
            this.tsbDangNhap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("tsbDangNhap.Image")));
            this.tsbDangNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDangNhap.Name = "tsbDangNhap";
            this.tsbDangNhap.Size = new System.Drawing.Size(34, 28);
            this.tsbDangNhap.Text = "&Đăng nhập";
            this.tsbDangNhap.Click += new System.EventHandler(this.tsmiDangNhap_Click);
            // 
            // tsbDangXuat
            // 
            this.tsbDangXuat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("tsbDangXuat.Image")));
            this.tsbDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDangXuat.Name = "tsbDangXuat";
            this.tsbDangXuat.Size = new System.Drawing.Size(34, 28);
            this.tsbDangXuat.Text = "&Đăng xuất";
            this.tsbDangXuat.Click += new System.EventHandler(this.tsmiDangXuat_Click);
            // 
            // tsbThoat
            // 
            this.tsbThoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbThoat.Image = ((System.Drawing.Image)(resources.GetObject("tsbThoat.Image")));
            this.tsbThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThoat.Name = "tsbThoat";
            this.tsbThoat.Size = new System.Drawing.Size(34, 28);
            this.tsbThoat.Text = "&Thoát";
            this.tsbThoat.Click += new System.EventHandler(this.tsmiThoat_Click);
            // 
            // tsbNhanVien
            // 
            this.tsbNhanVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("tsbNhanVien.Image")));
            this.tsbNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNhanVien.Name = "tsbNhanVien";
            this.tsbNhanVien.Size = new System.Drawing.Size(34, 28);
            this.tsbNhanVien.Text = "&Nhân viên";
            this.tsbNhanVien.Click += new System.EventHandler(this.tsmiNhanVien_Click);
            // 
            // tsbSanPham
            // 
            this.tsbSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSanPham.Image = ((System.Drawing.Image)(resources.GetObject("tsbSanPham.Image")));
            this.tsbSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSanPham.Name = "tsbSanPham";
            this.tsbSanPham.Size = new System.Drawing.Size(34, 28);
            this.tsbSanPham.Text = "&Sản phẩm";
            this.tsbSanPham.Click += new System.EventHandler(this.tsmiSanPham_Click);
            // 
            // tsbHoaDon
            // 
            this.tsbHoaDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("tsbHoaDon.Image")));
            this.tsbHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHoaDon.Name = "tsbHoaDon";
            this.tsbHoaDon.Size = new System.Drawing.Size(34, 28);
            this.tsbHoaDon.Text = "&Hóa đơn";
            this.tsbHoaDon.Click += new System.EventHandler(this.tsmiHoaDon_Click);
            // 
            // tsbTroGiup
            // 
            this.tsbTroGiup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTroGiup.Image = ((System.Drawing.Image)(resources.GetObject("tsbTroGiup.Image")));
            this.tsbTroGiup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTroGiup.Name = "tsbTroGiup";
            this.tsbTroGiup.Size = new System.Drawing.Size(34, 28);
            this.tsbTroGiup.Text = "&Giới thiệu";
            this.tsbTroGiup.Click += new System.EventHandler(this.tsmiGioiThieu_Click);
            // 
            // tsbLienHe
            // 
            this.tsbLienHe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLienHe.Image = ((System.Drawing.Image)(resources.GetObject("tsbLienHe.Image")));
            this.tsbLienHe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLienHe.Name = "tsbLienHe";
            this.tsbLienHe.Size = new System.Drawing.Size(34, 28);
            this.tsbLienHe.Text = "&Liên hệ";
            this.tsbLienHe.Click += new System.EventHandler(this.tsmiLienHe_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUser,
            this.tsslForm,
            this.tsslTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 969);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1762, 35);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslUser
            // 
            this.tsslUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(127, 28);
            this.tsslUser.Text = "Người dùng:";
            // 
            // tsslForm
            // 
            this.tsslForm.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslForm.Name = "tsslForm";
            this.tsslForm.Size = new System.Drawing.Size(152, 28);
            this.tsslForm.Text = "Form đang mở:";
            // 
            // tsslTime
            // 
            this.tsslTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(102, 28);
            this.tsslTime.Text = "Thời gian:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon";
            this.notifyIcon1.Visible = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTimKiem,
            this.tstbTimKiem});
            this.toolStrip2.Location = new System.Drawing.Point(0, 73);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1762, 33);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tslTimKiem
            // 
            this.tslTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslTimKiem.Name = "tslTimKiem";
            this.tslTimKiem.Size = new System.Drawing.Size(97, 28);
            this.tslTimKiem.Text = "Tìm kiếm";
            // 
            // tstbTimKiem
            // 
            this.tstbTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tstbTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbTimKiem.Name = "tstbTimKiem";
            this.tstbTimKiem.Size = new System.Drawing.Size(610, 33);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMoLai,
            this.tsmiThoatChuongTrinh});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 68);
            // 
            // tsmiMoLai
            // 
            this.tsmiMoLai.Name = "tsmiMoLai";
            this.tsmiMoLai.Size = new System.Drawing.Size(240, 32);
            this.tsmiMoLai.Text = "Mở lại chương trình";
            // 
            // tsmiThoatChuongTrinh
            // 
            this.tsmiThoatChuongTrinh.Name = "tsmiThoatChuongTrinh";
            this.tsmiThoatChuongTrinh.Size = new System.Drawing.Size(240, 32);
            this.tsmiThoatChuongTrinh.Text = "Thoát";
            // 
            // pbKohKong
            // 
            this.pbKohKong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbKohKong.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbKohKong.Image = ((System.Drawing.Image)(resources.GetObject("pbKohKong.Image")));
            this.pbKohKong.Location = new System.Drawing.Point(0, 106);
            this.pbKohKong.Margin = new System.Windows.Forms.Padding(4);
            this.pbKohKong.Name = "pbKohKong";
            this.pbKohKong.Size = new System.Drawing.Size(1762, 863);
            this.pbKohKong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKohKong.TabIndex = 7;
            this.pbKohKong.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 87);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(115, 89);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // QLCuaHangMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1762, 1004);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbKohKong);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLCuaHangMini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QUẢN LÝ CỬA HÀNG MINI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbKohKong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHeThong;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsmiTroGiup;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangNhap;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsmiThoat;
        private System.Windows.Forms.ToolStripMenuItem tsmiNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmiSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmiHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tsmiGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem tsmiLienHe;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslForm;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.ToolStripButton tsbDangNhap;
        private System.Windows.Forms.ToolStripButton tsbDangXuat;
        private System.Windows.Forms.ToolStripButton tsbThoat;
        private System.Windows.Forms.ToolStripButton tsbNhanVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbSanPham;
        private System.Windows.Forms.ToolStripButton tsbHoaDon;
        private System.Windows.Forms.ToolStripButton tsbLienHe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbTroGiup;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoLai;
        private System.Windows.Forms.ToolStripMenuItem tsmiThoatChuongTrinh;
        private System.Windows.Forms.ToolStripLabel tslTimKiem;
        private System.Windows.Forms.ToolStripTextBox tstbTimKiem;
        internal System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pbKohKong;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

