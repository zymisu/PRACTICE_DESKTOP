using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBai1
{
    public partial class FormMain_Bai1 : Form
    {
        public FormMain_Bai1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void tsmFormLoad_Click(object sender, EventArgs e)
        {
            FormLoad f = new FormLoad();
            f.Show();
        }
        private void tsmTaomaytinh_Click(object sender, EventArgs e)
        {
            Form_Tạo_máy_tính_bỏ_túi f = new Form_Tạo_máy_tính_bỏ_túi();
            f.Show();
        }
        private void tsmTimUCLNvaBCNN_Click(object sender, EventArgs e)
        {
            Tìm_USCLN_và_BSCNN_của_A_và_B f = new Tìm_USCLN_và_BSCNN_của_A_và_B();
            f.Show();
        }

    }
}


