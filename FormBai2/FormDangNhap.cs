using System;
using System.Windows.Forms;
namespace FormBai2
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txt1, "Tài khoản mặc định: admin");
            toolTip1.SetToolTip(txt2, "Mật khẩu mặc định: 123");
            txt2.UseSystemPasswordChar = true;
        }
     private void btn1_Click(object sender, EventArgs e)
        {
            //Xóa lỗi cũ
            errorProvider1.Clear();
            bool hasError = false;

            // Kiểm tra Username
            if (string.IsNullOrWhiteSpace(txt1.Text))
            {
                errorProvider1.SetError(txt1, "Vui lòng nhập Username!");
                hasError = true;
            }

            // Kiểm tra Password
            if (string.IsNullOrWhiteSpace(txt2.Text))
            {
                errorProvider1.SetError(txt2, "Vui lòng nhập Password!");
                hasError = true;
            }
            if (hasError) return;

            // Kiểm tra đăng nhập
            if (txt1.Text == "admin" && txt2.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Mở form bài 3
                FormDangKy frm = new FormDangKy();
                frm.ShowDialog();
                //Ẩn form đăng nhập
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
