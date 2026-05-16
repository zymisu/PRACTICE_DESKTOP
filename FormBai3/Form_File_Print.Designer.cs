namespace FormBai3
{
    partial class Form_File_Print
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thực phẩm");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Đồ uống");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Gia vị");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Đồ gia dụng");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvSanPham = new System.Windows.Forms.TreeView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lsvSanPham = new System.Windows.Forms.ListView();
            this.clhMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTonKho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripSanPham = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnMoPhong = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripSanPham.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvSanPham);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.lbl1);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel2.Controls.Add(this.lsvSanPham);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(797, 442);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // trvSanPham
            // 
            this.trvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvSanPham.Location = new System.Drawing.Point(0, 0);
            this.trvSanPham.Name = "trvSanPham";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Thực phẩm";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Đồ uống";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Gia vị";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Đồ gia dụng";
            this.trvSanPham.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.trvSanPham.Size = new System.Drawing.Size(265, 442);
            this.trvSanPham.TabIndex = 0;
            this.trvSanPham.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvSanPham_AfterSelect);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(335, 407);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(133, 20);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Hiển thị % tiến độ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 407);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(310, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // lsvSanPham
            // 
            this.lsvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhMa,
            this.clhTen,
            this.clhGia,
            this.clhTonKho});
            this.lsvSanPham.ContextMenuStrip = this.contextMenuStripSanPham;
            this.lsvSanPham.FullRowSelect = true;
            this.lsvSanPham.HideSelection = false;
            this.lsvSanPham.Location = new System.Drawing.Point(0, 57);
            this.lsvSanPham.Name = "lsvSanPham";
            this.lsvSanPham.Size = new System.Drawing.Size(528, 338);
            this.lsvSanPham.TabIndex = 0;
            this.lsvSanPham.UseCompatibleStateImageBehavior = false;
            this.lsvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // clhMa
            // 
            this.clhMa.Text = "Mã";
            this.clhMa.Width = 65;
            // 
            // clhTen
            // 
            this.clhTen.Text = "Tên";
            this.clhTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhTen.Width = 120;
            // 
            // clhGia
            // 
            this.clhGia.Text = "Giá";
            this.clhGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhGia.Width = 80;
            // 
            // clhTonKho
            // 
            this.clhTonKho.Text = "Tồn Kho";
            this.clhTonKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhTonKho.Width = 85;
            // 
            // contextMenuStripSanPham
            // 
            this.contextMenuStripSanPham.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.contextMenuStripSanPham.AllowDrop = true;
            this.contextMenuStripSanPham.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripSanPham.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXem,
            this.tsmiXoa});
            this.contextMenuStripSanPham.Name = "contextMenuStrip1";
            this.contextMenuStripSanPham.ShowCheckMargin = true;
            this.contextMenuStripSanPham.Size = new System.Drawing.Size(221, 68);
            this.contextMenuStripSanPham.UseWaitCursor = true;
            // 
            // tsmiXem
            // 
            this.tsmiXem.Name = "tsmiXem";
            this.tsmiXem.Size = new System.Drawing.Size(220, 32);
            this.tsmiXem.Text = "Xem chi tiết";
            this.tsmiXem.Click += new System.EventHandler(this.tsmiXem_Click);
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.Size = new System.Drawing.Size(220, 32);
            this.tsmiXoa.Text = "Xóa sản phẩm";
            this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnMoPhong);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 57);
            this.panel1.TabIndex = 6;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnImport.Location = new System.Drawing.Point(78, 8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(79, 32);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnMoPhong
            // 
            this.btnMoPhong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMoPhong.Location = new System.Drawing.Point(299, 8);
            this.btnMoPhong.Name = "btnMoPhong";
            this.btnMoPhong.Size = new System.Drawing.Size(145, 32);
            this.btnMoPhong.TabIndex = 3;
            this.btnMoPhong.Text = "Mô phỏng Export";
            this.btnMoPhong.UseVisualStyleBackColor = false;
            this.btnMoPhong.Click += new System.EventHandler(this.btnMoPhong_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExport.Location = new System.Drawing.Point(187, 8);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(79, 32);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_File_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 442);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_File_Print";
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripSanPham.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvSanPham;
        private System.Windows.Forms.ListView lsvSanPham;
        private System.Windows.Forms.ColumnHeader clhMa;
        private System.Windows.Forms.ColumnHeader clhTen;
        private System.Windows.Forms.ColumnHeader clhGia;
        private System.Windows.Forms.ColumnHeader clhTonKho;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnMoPhong;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmiXem;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
        private System.Windows.Forms.Panel panel1;
    }
}

