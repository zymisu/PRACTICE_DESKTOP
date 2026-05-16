using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormDataGridView : Form
    {
        string strConnectionString =
            "Data Source=DESKTOP-LBGMCIO\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;";

        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;

        public FormDataGridView()
        {
            InitializeComponent();
        }

        private void FormDataGridView_Load(object sender, EventArgs e)
        {
            try
            {

                //Khởi động kết nối
                conn = new SqlConnection(strConnectionString);
                //Mở kết nối
                conn.Open();
                // Vận chuyển dữ liệu
                da = new SqlDataAdapter("SELECT * FROM SanPham", conn);
                //Khởi tạo đối tượng chứa dữ liệu
                ds = new DataSet();
                //Đổ dữ liệu vào DataSet
                da.Fill(ds);
                // Đưa dữ liệu lên DataGridView
                dgSanPham.DataSource = ds.Tables[0];

                dgSanPham.Columns[0].HeaderText = "Mã sản phẩm";
                dgSanPham.Columns[1].HeaderText = "Tên sản phẩm";
                dgSanPham.Columns[2].HeaderText = "Đơn vị tính";
                dgSanPham.Columns[3].HeaderText = "Đơn giá";
                dgSanPham.Columns[4].HeaderText = "Mã loại sản phẩm";

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu, có lỗi rồi!");
            }
        }

        private void FormClosing(object sender, FormClosingEventArgs e)
        {
            ds.Dispose();
            ds = null;
            conn.Close();
            conn = null;
        }
    }
}
