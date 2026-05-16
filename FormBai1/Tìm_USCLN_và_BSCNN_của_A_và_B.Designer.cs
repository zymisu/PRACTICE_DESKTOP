using System.Windows.Forms;

namespace FormBai1
{
    partial class Tìm_USCLN_và_BSCNN_của_A_và_B : Form
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
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.radUSCLN = new System.Windows.Forms.RadioButton();
            this.radBSCNN = new System.Windows.Forms.RadioButton();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grp1.SuspendLayout();
            this.grp2.SuspendLayout();
            this.grp3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.txt2);
            this.grp1.Controls.Add(this.txt1);
            this.grp1.Controls.Add(this.lbl2);
            this.grp1.Controls.Add(this.lbl1);
            this.grp1.Location = new System.Drawing.Point(12, 26);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(390, 128);
            this.grp1.TabIndex = 0;
            this.grp1.TabStop = false;
            this.grp1.Text = "Nhập:";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(52, 76);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(320, 26);
            this.txt2.TabIndex = 3;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(52, 39);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(320, 26);
            this.txt1.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 79);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(24, 20);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "B:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(24, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "A:";
            // 
            // radUSCLN
            // 
            this.radUSCLN.AutoSize = true;
            this.radUSCLN.Location = new System.Drawing.Point(21, 40);
            this.radUSCLN.Name = "radUSCLN";
            this.radUSCLN.Size = new System.Drawing.Size(88, 24);
            this.radUSCLN.TabIndex = 1;
            this.radUSCLN.TabStop = true;
            this.radUSCLN.Text = "USCLN";
            this.radUSCLN.UseVisualStyleBackColor = true;
            // 
            // radBSCNN
            // 
            this.radBSCNN.AutoSize = true;
            this.radBSCNN.Location = new System.Drawing.Point(20, 80);
            this.radBSCNN.Name = "radBSCNN";
            this.radBSCNN.Size = new System.Drawing.Size(89, 24);
            this.radBSCNN.TabIndex = 2;
            this.radBSCNN.TabStop = true;
            this.radBSCNN.Text = "BSCNN";
            this.radBSCNN.UseVisualStyleBackColor = true;
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.radUSCLN);
            this.grp2.Controls.Add(this.radBSCNN);
            this.grp2.Location = new System.Drawing.Point(419, 26);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(200, 128);
            this.grp2.TabIndex = 3;
            this.grp2.TabStop = false;
            this.grp2.Text = "Chọn tìm";
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.button3);
            this.grp3.Controls.Add(this.button2);
            this.grp3.Controls.Add(this.button1);
            this.grp3.Controls.Add(this.txt3);
            this.grp3.Location = new System.Drawing.Point(12, 160);
            this.grp3.Name = "grp3";
            this.grp3.Size = new System.Drawing.Size(607, 141);
            this.grp3.TabIndex = 4;
            this.grp3.TabStop = false;
            this.grp3.Text = "Kết quả:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bỏ qua";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(52, 36);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(348, 26);
            this.txt3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(635, 313);
            this.Controls.Add(this.grp3);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Tìm USCLN và BSCNN của A và B";
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            this.grp3.ResumeLayout(false);
            this.grp3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.RadioButton radUSCLN;
        private System.Windows.Forms.RadioButton radBSCNN;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.GroupBox grp3;

        public Button button3 { get; private set; }

        private System.Windows.Forms.TextBox txt3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

