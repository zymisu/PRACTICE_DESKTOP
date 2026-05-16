using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    
    public partial class FormMain_Bai4 : Form
    {
        // ====== KHAI BÁO TOÀN CỤC ======
        SQLiteDataAdapter da;
        DataSet ds;
        SQLiteCommandBuilder cmd;
        SQLiteConnection conn;
        DataTable dtSP = new DataTable();
        int vitri = 0;

        public FormMain_Bai4()
        {
            InitializeComponent();
        }
        private void tsmListBox_Click(object sender, EventArgs e)
        {
            FormListBox f = new FormListBox();
            f.ShowDialog();
        }
        private void tsmComboBox_Click(object sender, EventArgs e)
        {
            FormComboBox f = new FormComboBox();
            f.ShowDialog();
        }
        private void tsmDataGridView_Click(object sender, EventArgs e)
        {
            FormDataGridView f = new FormDataGridView();
            f.ShowDialog();
        }
        private void tsmFilter_Click(object sender, EventArgs e)
        {
            FormLocSanPham f = new FormLocSanPham();
            f.ShowDialog();
        }
        private void tsmSearch_Click(object sender, EventArgs e)
        {
            FormTimKiem f = new FormTimKiem();
            f.ShowDialog();
        }
        private void tsmTreevaDataGridView_Click(object sender, EventArgs e)
        {
            FormTreeViewvaDataGridView f = new FormTreeViewvaDataGridView();
            f.ShowDialog();
        }
        private void tsmPhantrang_Click(object sender, EventArgs e)
        {
            FormPhanTrang f = new FormPhanTrang();
            f.ShowDialog();
        }

        private void tsmQuanLy_Click(object sender, EventArgs e)
        {
            FormQuanLySanPham f = new FormQuanLySanPham(); 
            f.ShowDialog();
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.ShowDialog();
        }
        private void FormMain_Bai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ds != null) ds.Dispose();
            if (conn != null) conn.Close();
        }
    }
}
