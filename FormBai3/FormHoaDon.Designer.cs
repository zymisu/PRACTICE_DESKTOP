namespace FormBai3
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSL = new System.Windows.Forms.NumericUpDown();
            this.txtHD = new System.Windows.Forms.TextBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.cboSP = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblBig = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToOrderColumns = true;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSP,
            this.TenSP,
            this.DonGia,
            this.SL,
            this.ThanhTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(-1, 338);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.Size = new System.Drawing.Size(896, 306);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.Width = 150;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 150;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 8;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 8;
            this.SL.Name = "SL";
            this.SL.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên sản phẩm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số lượng";
            // 
            // nudSL
            // 
            this.nudSL.Location = new System.Drawing.Point(594, 161);
            this.nudSL.Name = "nudSL";
            this.nudSL.Size = new System.Drawing.Size(120, 26);
            this.nudSL.TabIndex = 8;
            // 
            // txtHD
            // 
            this.txtHD.Location = new System.Drawing.Point(159, 111);
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(249, 26);
            this.txtHD.TabIndex = 9;
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(159, 155);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(249, 26);
            this.txtKH.TabIndex = 10;
            // 
            // cboSP
            // 
            this.cboSP.FormattingEnabled = true;
            this.cboSP.Items.AddRange(new object[] {
            "SP001_Thịt bò (100,000đ)  ",
            "SP002_Thịt gà (80,000đ)  ",
            "SP003_Cá hồi (150,000đ)  ",
            "SP004_Trứng gà (25,000đ)  ",
            "SP005_Sữa tươi (30,000đ)  ",
            "SP006_Cà phê hòa tan (50,000đ)  ",
            "SP007_Coca-Cola 500ml (15,000đ)  ",
            "SP008_Trà xanh matcha (35,000đ)  ",
            "SP009_Đường trắng (20,000đ)  ",
            "SP010_Muối i-ốt (10,000đ)  ",
            "SP011_Hạt tiêu (40,000đ)  ",
            "SP012_Dầu ăn (60,000đ)  ",
            "SP013_Bột mì (25,000đ)  ",
            "SP014_Bột ngọt (15,000đ)  ",
            "SP015_Máy xay sinh tố (850,000đ)  ",
            "SP016_Bếp điện từ (1,200,000đ)  ",
            "SP017_Nồi inox 3 đáy (700,000đ)  ",
            "SP018_Chảo chống dính (350,000đ)  ",
            "SP019_Đèn bàn học (250,000đ)  ",
            "SP020_Quạt cây (500,000đ)  "});
            this.cboSP.Location = new System.Drawing.Point(594, 114);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(261, 28);
            this.cboSP.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnThem.Location = new System.Drawing.Point(684, 201);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(171, 43);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm giỏ hàng";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTao.Location = new System.Drawing.Point(253, 263);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(115, 42);
            this.btnTao.TabIndex = 14;
            this.btnTao.Text = "Tạo hóa đơn";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIn.Location = new System.Drawing.Point(417, 263);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(116, 42);
            this.btnIn.TabIndex = 15;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(583, 263);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(97, 42);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblBig
            // 
            this.lblBig.AutoSize = true;
            this.lblBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBig.ForeColor = System.Drawing.Color.Tomato;
            this.lblBig.Location = new System.Drawing.Point(317, 32);
            this.lblBig.Name = "lblBig";
            this.lblBig.Size = new System.Drawing.Size(363, 37);
            this.lblBig.TabIndex = 17;
            this.lblBig.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTongTien.Location = new System.Drawing.Point(12, 654);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(155, 29);
            this.lblTongTien.TabIndex = 18;
            this.lblTongTien.Text = "TỔNG TIỀN";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(159, 204);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(249, 26);
            this.txtNV.TabIndex = 19;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 692);
            this.Controls.Add(this.txtNV);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblBig);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboSP);
            this.Controls.Add(this.txtKH);
            this.Controls.Add(this.txtHD);
            this.Controls.Add(this.nudSL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "FormHoaDon";
            this.Text = "QUẢN LÝ HÓA ĐƠN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudSL;
        private System.Windows.Forms.TextBox txtHD;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.ComboBox cboSP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblBig;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtNV;
    }
}