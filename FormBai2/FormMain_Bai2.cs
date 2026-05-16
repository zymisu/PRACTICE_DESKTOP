using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBai2
{
    public partial class FormMain_Bai2 : Form
    {
        public FormMain_Bai2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void tsmDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }
        private void tsmDangKySP_Click(object sender, EventArgs e)
        {
            FormDangKy f = new FormDangKy();
            f.Show();
        }
        private void tsmQLSP_Click(object sender, EventArgs e)
        {
            FormQuanLySP f = new FormQuanLySP();
            f.Show();
        }

    }
}
