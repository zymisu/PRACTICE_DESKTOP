using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace QuanLyBanHang
{
    public partial class FormPhanTrang : Form
    {
        string strConnectionString = "Data Source=DESKTOP-LBGMCIO\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        DataTable dtSP;
        int vitri = -1;

        public FormPhanTrang()
        {
            InitializeComponent();
        }
        private void FormPhanTrang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            //Mở kết nối
            conn.Open();
            // Đưa dữ liệu vào Bảng sản phẩm dtSP
            da = new SqlDataAdapter("SELECT * FROM SanPham", conn);
            ds = new DataSet();
            da.Fill(ds, "SanPham");
            dtSP = ds.Tables["SanPham"];
            btnFirst.PerformClick(); //thực hiện chọn nút First đầu tiên
            LoadLoaiSanPham();


        }
        void LoadLoaiSanPham()
        {
            // Vận chuyển dữ liệu vào ComboBox
            da = new SqlDataAdapter("SELECT * FROM LoaiSanPham", conn);
            ds = new DataSet();
            da.Fill(ds, "LoaiSanPham");
            cboLoaiSP.DataSource = ds.Tables["LoaiSanPham"];
            cboLoaiSP.DisplayMember = "TenLoai";
            cboLoaiSP.ValueMember = "MaLoai";
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (dtSP.Rows.Count == 0) return;
            vitri = 0;
            txtMaSP.Text = dtSP.Rows[vitri]["MaSP"].ToString();
            txtTenSP.Text = dtSP.Rows[vitri]["TenSP"].ToString();
            txtDVT.Text = dtSP.Rows[vitri]["DVTinh"].ToString();
            txtDonGia.Text = dtSP.Rows[vitri]["DonGia"].ToString();
            cboLoaiSP.SelectedValue = dtSP.Rows[vitri]["MaLoai"].ToString();
        }


private void btnLast_Click(object sender, EventArgs e)
        {
            if (dtSP.Rows.Count == 0) return;
            vitri = dtSP.Rows.Count - 1;
            txtMaSP.Text = dtSP.Rows[vitri]["MaSP"].ToString();
            txtTenSP.Text = dtSP.Rows[vitri]["TenSP"].ToString();
            txtDVT.Text = dtSP.Rows[vitri]["DVTinh"].ToString();
            txtDonGia.Text = dtSP.Rows[vitri]["DonGia"].ToString();
            cboLoaiSP.SelectedValue = dtSP.Rows[vitri]["MaLoai"].ToString();
        }


private void btnNext_Click(object sender, EventArgs e)
        {
            if (dtSP.Rows.Count == 0) return;
            vitri++;
            if (vitri > dtSP.Rows.Count - 1) vitri = dtSP.Rows.Count - 1;
            txtMaSP.Text = dtSP.Rows[vitri]["MaSP"].ToString();
            txtTenSP.Text = dtSP.Rows[vitri]["TenSP"].ToString();
            txtDVT.Text = dtSP.Rows[vitri]["DVTinh"].ToString();
            txtDonGia.Text = dtSP.Rows[vitri]["DonGia"].ToString();
            cboLoaiSP.SelectedValue = dtSP.Rows[vitri]["MaLoai"].ToString();
        }
private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (dtSP.Rows.Count == 0) return;
            vitri--;
            if (vitri < 0) vitri = 0;
            txtMaSP.Text = dtSP.Rows[vitri]["MaSP"].ToString();
            txtTenSP.Text = dtSP.Rows[vitri]["TenSP"].ToString();
            txtDVT.Text = dtSP.Rows[vitri]["DVTinh"].ToString();
            txtDonGia.Text = dtSP.Rows[vitri]["DonGia"].ToString();
            cboLoaiSP.SelectedValue = dtSP.Rows[vitri]["MaLoai"].ToString();
        }


    }
}
