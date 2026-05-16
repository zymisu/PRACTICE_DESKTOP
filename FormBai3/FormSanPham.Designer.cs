namespace FormBai3
{
    partial class FormSanPham
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
            System.Windows.Forms.ColumnHeader clhMa;
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thực phẩm");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Đồ uống");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Gia vị");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Đồ gia dụng");
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.trvSanPham = new System.Windows.Forms.TreeView();
            this.lsvSanPham = new System.Windows.Forms.ListView();
            this.clhTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTonKho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripSanPham = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiXem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            clhMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.contextMenuStripSanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // clhMa
            // 
            clhMa.Text = "Mã";
            clhMa.Width = 65;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.trvSanPham);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lsvSanPham);
            this.splitContainer3.Size = new System.Drawing.Size(617, 324);
            this.splitContainer3.SplitterDistance = 205;
            this.splitContainer3.TabIndex = 4;
            // 
            // trvSanPham
            // 
            this.trvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.trvSanPham.Size = new System.Drawing.Size(205, 324);
            this.trvSanPham.TabIndex = 0;
            // 
            // lsvSanPham
            // 
            this.lsvSanPham.AutoArrange = false;
            this.lsvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            clhMa,
            this.clhTen,
            this.clhGia,
            this.clhTonKho});
            this.lsvSanPham.ContextMenuStrip = this.contextMenuStripSanPham;
            this.lsvSanPham.Cursor = System.Windows.Forms.Cursors.Default;
            this.lsvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvSanPham.FullRowSelect = true;
            this.lsvSanPham.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvSanPham.HideSelection = false;
            this.lsvSanPham.Location = new System.Drawing.Point(0, 0);
            this.lsvSanPham.Name = "lsvSanPham";
            this.lsvSanPham.Size = new System.Drawing.Size(408, 324);
            this.lsvSanPham.TabIndex = 0;
            this.lsvSanPham.UseCompatibleStateImageBehavior = false;
            this.lsvSanPham.View = System.Windows.Forms.View.Details;
            this.lsvSanPham.SelectedIndexChanged += new System.EventHandler(this.lsvSanPham_SelectedIndexChanged);
            // 
            // clhTen
            // 
            this.clhTen.Text = "Tên";
            this.clhTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhTen.Width = 114;
            // 
            // clhGia
            // 
            this.clhGia.Text = "Giá";
            this.clhGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhGia.Width = 113;
            // 
            // clhTonKho
            // 
            this.clhTonKho.Text = "Tồn kho";
            this.clhTonKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhTonKho.Width = 108;
            // 
            // contextMenuStripSanPham
            // 
            this.contextMenuStripSanPham.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripSanPham.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXem,
            this.tsmiXoa});
            this.contextMenuStripSanPham.Name = "contextMenuStripSanPham";
            this.contextMenuStripSanPham.Size = new System.Drawing.Size(199, 68);
            // 
            // tsmiXem
            // 
            this.tsmiXem.Name = "tsmiXem";
            this.tsmiXem.Size = new System.Drawing.Size(198, 32);
            this.tsmiXem.Text = "Xem chi tiết";
            this.tsmiXem.Click += new System.EventHandler(this.tsmiXem_Click);
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.Size = new System.Drawing.Size(198, 32);
            this.tsmiXoa.Text = "Xóa sản phẩm";
            this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 324);
            this.Controls.Add(this.splitContainer3);
            this.Name = "FormSanPham";
            this.Text = "Quản lý sản phẩm";
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.contextMenuStripSanPham.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TreeView trvSanPham;
        private System.Windows.Forms.ListView lsvSanPham;
        private System.Windows.Forms.ColumnHeader clhTen;
        private System.Windows.Forms.ColumnHeader clhGia;
        private System.Windows.Forms.ColumnHeader clhTonKho;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmiXem;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
    }
}

