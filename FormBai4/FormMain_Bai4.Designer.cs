namespace QuanLyBanHang
{
    partial class FormMain_Bai4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_Bai4));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmComboBox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDataGridView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTreevaDataGridView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPhantrang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmListBox,
            this.tsmComboBox,
            this.tsmDataGridView,
            this.tsmSearch,
            this.tsmFilter,
            this.tsmTreevaDataGridView,
            this.tsmPhantrang,
            this.tsmQuanLy,
            this.tsmAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1722, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmListBox
            // 
            this.tsmListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmListBox.Name = "tsmListBox";
            this.tsmListBox.Size = new System.Drawing.Size(93, 32);
            this.tsmListBox.Text = "ListBox";
            this.tsmListBox.Click += new System.EventHandler(this.tsmListBox_Click);
            // 
            // tsmComboBox
            // 
            this.tsmComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmComboBox.Name = "tsmComboBox";
            this.tsmComboBox.Size = new System.Drawing.Size(128, 32);
            this.tsmComboBox.Text = "ComboBox";
            this.tsmComboBox.Click += new System.EventHandler(this.tsmComboBox_Click);
            // 
            // tsmDataGridView
            // 
            this.tsmDataGridView.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmDataGridView.Name = "tsmDataGridView";
            this.tsmDataGridView.Size = new System.Drawing.Size(151, 32);
            this.tsmDataGridView.Text = "DataGridView";
            this.tsmDataGridView.Click += new System.EventHandler(this.tsmDataGridView_Click);
            // 
            // tsmSearch
            // 
            this.tsmSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSearch.Name = "tsmSearch";
            this.tsmSearch.Size = new System.Drawing.Size(113, 32);
            this.tsmSearch.Text = "Tìm kiếm";
            this.tsmSearch.Click += new System.EventHandler(this.tsmSearch_Click);
            // 
            // tsmFilter
            // 
            this.tsmFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmFilter.Name = "tsmFilter";
            this.tsmFilter.Size = new System.Drawing.Size(240, 32);
            this.tsmFilter.Text = "Lọc sản phẩm theo loại";
            this.tsmFilter.Click += new System.EventHandler(this.tsmFilter_Click);
            // 
            // tsmTreevaDataGridView
            // 
            this.tsmTreevaDataGridView.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmTreevaDataGridView.Name = "tsmTreevaDataGridView";
            this.tsmTreevaDataGridView.Size = new System.Drawing.Size(265, 32);
            this.tsmTreevaDataGridView.Text = "TreeView và DataGridView";
            this.tsmTreevaDataGridView.Click += new System.EventHandler(this.tsmTreevaDataGridView_Click);
            // 
            // tsmPhantrang
            // 
            this.tsmPhantrang.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmPhantrang.Name = "tsmPhantrang";
            this.tsmPhantrang.Size = new System.Drawing.Size(134, 32);
            this.tsmPhantrang.Text = "Phân trang ";
            this.tsmPhantrang.Click += new System.EventHandler(this.tsmPhantrang_Click);
            // 
            // tsmQuanLy
            // 
            this.tsmQuanLy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmQuanLy.Name = "tsmQuanLy";
            this.tsmQuanLy.Size = new System.Drawing.Size(193, 32);
            this.tsmQuanLy.Text = "Quản lý sản phẩm";
            this.tsmQuanLy.Click += new System.EventHandler(this.tsmQuanLy_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(84, 32);
            this.tsmAbout.Text = "About";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1722, 937);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 977);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain_Bai4";
            this.Text = "BT TUẦN 4 - ỨNG DỤNG QUẢN LÝ BÁN HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmListBox;
        private System.Windows.Forms.ToolStripMenuItem tsmComboBox;
        private System.Windows.Forms.ToolStripMenuItem tsmDataGridView;
        private System.Windows.Forms.ToolStripMenuItem tsmSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmTreevaDataGridView;
        private System.Windows.Forms.ToolStripMenuItem tsmPhantrang;
        private System.Windows.Forms.ToolStripMenuItem tsmQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}