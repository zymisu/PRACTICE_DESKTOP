using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormLocSanPham : Form
    {
        string strConnectionString ="Data Source=DESKTOP-LBGMCIO\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;

        public FormLocSanPham()
        {
            InitializeComponent();
           
        }
        private void FormLocSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                conn.Open();

                da = new SqlDataAdapter("SELECT * FROM LoaiSanPham", conn);
                ds = new DataSet();
                da.Fill(ds, "LoaiSanPham");

                cboLoaiSP.DataSource = ds.Tables["LoaiSanPham"];
                cboLoaiSP.DisplayMember = "TenLoai";
                cboLoaiSP.ValueMember = "MaLoai";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu loại sản phẩm!");
            }
        }

        void LoadSanPham(string maloai)
        {
            try
            {

                // Vận chuyển dữ liệu vào DataGridView 
                da = null;
                ds = new DataSet();
                da = new SqlDataAdapter("SELECT * FROM SanPham Where MaLoai='" + maloai + "'", conn);
                da.Fill(ds, "SanPham");
                dgSanPham.DataSource = ds.Tables["SanPham"];
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu, có lỗi rồi!");
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadSanPham(cboLoaiSP.SelectedValue.ToString());
        }

    }
}
