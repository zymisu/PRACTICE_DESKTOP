using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormTimKiem : Form
    {
        string strConnectionString = "Data Source=DESKTOP-LBGMCIO\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;";

        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;

        public FormTimKiem()
        {
            InitializeComponent();
            TimKiem(txtKeyWord.Text);
        }

        private void TimKiem(string keyword)
        {
            try
            {
                //Khởi tạo kết nối
                conn = new SqlConnection(strConnectionString);
                //Mở kết nối
                conn.Open();

                //Khai báo câu truy vấn
                string sql = "";
                if (keyword != "")
                {
                    sql = "SELECT * FROM SanPham Where TenSP like N'%" + keyword + "%'";
                }
                else
                {
                    sql = "SELECT * FROM SanPham";
                }

                // Vận chuyển dữ liệu vào DataGridView dgSanPham
                da = new SqlDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds, "ABC");
                dgSanPham.DataSource = ds.Tables["ABC"];

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu, có lỗi rồi!");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem(txtKeyWord.Text);
        }
    }
}

