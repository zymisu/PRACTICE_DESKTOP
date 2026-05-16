namespace FormBai1
{
    partial class Form_Tạo_máy_tính_bỏ_túi
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
            this.lblSothunhat = new System.Windows.Forms.Label();
            this.lblSothuhai = new System.Windows.Forms.Label();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.txtSothunhat = new System.Windows.Forms.TextBox();
            this.txtSothuhai = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSothunhat
            // 
            this.lblSothunhat.AutoSize = true;
            this.lblSothunhat.Location = new System.Drawing.Point(47, 56);
            this.lblSothunhat.Name = "lblSothunhat";
            this.lblSothunhat.Size = new System.Drawing.Size(92, 20);
            this.lblSothunhat.TabIndex = 0;
            this.lblSothunhat.Text = "Số thứ nhất";
            // 
            // lblSothuhai
            // 
            this.lblSothuhai.AutoSize = true;
            this.lblSothuhai.Location = new System.Drawing.Point(47, 103);
            this.lblSothuhai.Name = "lblSothuhai";
            this.lblSothuhai.Size = new System.Drawing.Size(81, 20);
            this.lblSothuhai.TabIndex = 1;
            this.lblSothuhai.Text = "Số thứ hai";
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Location = new System.Drawing.Point(52, 221);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(64, 20);
            this.lblKetqua.TabIndex = 2;
            this.lblKetqua.Text = "Kết quả";
            // 
            // txtSothunhat
            // 
            this.txtSothunhat.Location = new System.Drawing.Point(147, 53);
            this.txtSothunhat.Name = "txtSothunhat";
            this.txtSothunhat.Size = new System.Drawing.Size(187, 26);
            this.txtSothunhat.TabIndex = 3;
            // 
            // txtSothuhai
            // 
            this.txtSothuhai.Location = new System.Drawing.Point(147, 103);
            this.txtSothuhai.Name = "txtSothuhai";
            this.txtSothuhai.Size = new System.Drawing.Size(187, 26);
            this.txtSothuhai.TabIndex = 4;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(147, 221);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(187, 26);
            this.txtKetqua.TabIndex = 5;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(56, 164);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(39, 30);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(112, 164);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(39, 30);
            this.btnTru.TabIndex = 7;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(166, 164);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(39, 30);
            this.btnNhan.TabIndex = 8;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(221, 164);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(38, 30);
            this.btnChia.TabIndex = 9;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(279, 164);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(55, 30);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // Form_Tạo_máy_tính_bỏ_túi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 279);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtSothuhai);
            this.Controls.Add(this.txtSothunhat);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.lblSothuhai);
            this.Controls.Add(this.lblSothunhat);
            this.Name = "Form_Tạo_máy_tính_bỏ_túi";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSothunhat;
        private System.Windows.Forms.Label lblSothuhai;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.TextBox txtSothunhat;
        private System.Windows.Forms.TextBox txtSothuhai;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnDel;
    }
}

