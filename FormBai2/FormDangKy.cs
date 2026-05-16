using System;
using System.Windows.Forms;

namespace FormBai2
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string tenSP = txt1.Text.Trim();
            string loaiSP = cob1.SelectedItem.ToString();
            int soLuong = (int)nud1.Value;
            //Kiểm tra tên sản phẩm
            if (string.IsNullOrEmpty(tenSP))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thông báo");
                return;
            }
            
            // Thêm dữ liệu vào DataGridView
            dgv1.Rows.Add(tenSP, loaiSP, soLuong);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                dgv1.Rows.RemoveAt(dgv1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo");
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            cob1.Text = "";
            nud1.Value= 0;
        }
    }
}
