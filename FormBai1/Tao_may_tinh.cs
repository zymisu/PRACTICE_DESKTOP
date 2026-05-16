using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBai1
{
    public partial class Form_Tạo_máy_tính_bỏ_túi : Form
    {
        public Form_Tạo_máy_tính_bỏ_túi()
        {
            InitializeComponent();
            // Gán sự kiện KeyPress cho 2 ô nhập
            txtSothunhat.KeyPress += Txt_KeyPress_OnlyNumber;
            txtSothuhai.KeyPress += Txt_KeyPress_OnlyNumber;

            // Gán sự kiện click cho các nút
            btnCong.Click += btnCong_Click; // Cộng
            btnTru.Click += btnTru_Click; // Trừ
            btnNhan.Click += btnNhan_Click; // Nhân
            btnChia.Click += btnChia_Click; // Chia
            btnDel.Click += btnDel_Click; // Delete
        }
        private void Txt_KeyPress_OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double cong;
            Console.WriteLine(txtSothunhat.Text);
            Console.WriteLine(txtSothuhai.Text);
            cong = Convert.ToDouble(txtSothunhat.Text) + Convert.ToDouble(txtSothuhai.Text);
            txtKetqua.Text = cong + "";
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            double tru;
            Console.WriteLine(txtSothunhat.Text);
            Console.WriteLine(txtSothuhai.Text);
            tru = Convert.ToDouble(txtSothunhat.Text) - Convert.ToDouble(txtSothuhai.Text);
            txtKetqua.Text = tru + "";
        }
        private void btnNhan_Click(object sender, EventArgs e)
        {
            double nhan;
            Console.WriteLine(txtSothunhat.Text);
            Console.WriteLine(txtSothuhai.Text);
            nhan = Convert.ToDouble(txtSothunhat.Text) * Convert.ToDouble(txtSothuhai.Text);
            txtKetqua.Text = nhan + "";
        }
        private void btnChia_Click(object sender, EventArgs e)
        {
            double chia;
            double so1 = Convert.ToDouble(txtSothunhat.Text);
            double so2 = Convert.ToDouble(txtSothuhai.Text);

            if (so2 == 0)
            {
                MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKetqua.Text = ""; // Xóa kết quả
                return;
            }

            chia = so1 / so2;
            txtKetqua.Text = chia + "";
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            txtSothunhat.Text = "";
            txtSothuhai.Text = "";
            txtKetqua.Text = "";
        }
    }
}
