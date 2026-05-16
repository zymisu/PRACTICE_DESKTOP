using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormListBox : Form
    {
        string strConnectionString = "Data Source = DESKTOP-LBGMCIO\\SQLEXPRESS; Initial Catalog = QLBH; Integrated Security=True";
        // Đối tượng kết nối dữ liệu
        SqlConnection conn = null;
        // Đối tượng thực hiện vận chuyển dữ liệu  
        SqlDataAdapter da = null;
        // Đối tượng chứa dữ liệu trong bộ nhớ
        DataSet ds = null;

        public FormListBox()
        {
            InitializeComponent();
        }

        private void FormListBox_Load(object sender, EventArgs e)
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
                // Đưa dữ liệu lên ListBox
                lstSanPham.DataSource = ds.Tables[0];
                lstSanPham.DisplayMember = "TenSP";
                lstSanPham.ValueMember = "MaSP";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu, có lỗi rồi!");
            }

        }
        private void FormClosing(object sender, EventArgs e)
        {
            ds.Dispose();
            ds = null;
            conn.Close();
            conn = null;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) Application.Exit();

        }
    }
}
