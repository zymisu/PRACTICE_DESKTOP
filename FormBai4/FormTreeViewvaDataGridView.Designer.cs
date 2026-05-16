namespace QuanLyBanHang
{
    partial class FormTreeViewvaDataGridView
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
            this.label2 = new System.Windows.Forms.Label();
            this.trvLoaiSanPham = new System.Windows.Forms.TreeView();
            this.dgSanPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sản phẩm";
            // 
            // trvLoaiSanPham
            // 
            this.trvLoaiSanPham.Location = new System.Drawing.Point(24, 86);
            this.trvLoaiSanPham.Name = "trvLoaiSanPham";
            this.trvLoaiSanPham.Size = new System.Drawing.Size(327, 332);
            this.trvLoaiSanPham.TabIndex = 2;
            this.trvLoaiSanPham.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvLoaiSanPham_AfterSelect);
            // 
            // dgSanPham
            // 
            this.dgSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSanPham.Location = new System.Drawing.Point(374, 86);
            this.dgSanPham.Name = "dgSanPham";
            this.dgSanPham.RowHeadersWidth = 62;
            this.dgSanPham.RowTemplate.Height = 28;
            this.dgSanPham.Size = new System.Drawing.Size(754, 332);
            this.dgSanPham.TabIndex = 3;
            // 
            // FormTreeViewvaDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.dgSanPham);
            this.Controls.Add(this.trvLoaiSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTreeViewvaDataGridView";
            this.Text = "TreeView và DataGridView";
            this.Load += new System.EventHandler(this.FormTreeViewvaDataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView trvLoaiSanPham;
        private System.Windows.Forms.DataGridView dgSanPham;
    }
}