namespace QuanLyBanHang
{
    partial class FormListBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstSanPham = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // lstSanPham
            // 
            this.lstSanPham.FormattingEnabled = true;
            this.lstSanPham.ItemHeight = 20;
            this.lstSanPham.Items.AddRange(new object[] {
            "Giáo trình Tin học đại cương",
            "Giáo trình C# toàn tập",
            "Thiết kế Web chuyên nghiệp",
            "Áo thun 3 lỗ",
            "Quần Jean",
            ""});
            this.lstSanPham.Location = new System.Drawing.Point(61, 82);
            this.lstSanPham.Name = "lstSanPham";
            this.lstSanPham.Size = new System.Drawing.Size(361, 284);
            this.lstSanPham.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(447, 82);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 418);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lstSanPham);
            this.Controls.Add(this.label1);
            this.Name = "FormListBox";
            this.Text = "Đưa dữ liệu vào ListBox";
            this.Load += new System.EventHandler(this.FormListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSanPham;
        private System.Windows.Forms.Button btnThoat;
    }
}

