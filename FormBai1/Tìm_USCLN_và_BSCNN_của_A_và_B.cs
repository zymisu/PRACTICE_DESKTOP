using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBai1
{
    public partial class Tìm_USCLN_và_BSCNN_của_A_và_B : Form
    {
        public Tìm_USCLN_và_BSCNN_của_A_và_B()
        { 
            InitializeComponent();
            // Gán sự kiện Keydowwn cho textbox
            txt1.KeyPress += Txt_KeyPress_OnlyNumber;
            txt2.KeyPress += Txt_KeyPress_OnlyNumber;

            // Gán sự kiện Click cho button
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
        }

        private void Txt_KeyPress_OnlyNumber(object sender, KeyPressEventArgs e)
        {
            // Chỉ chấp nhận phím số, phím điều khiển (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Thuật toán Euclid tìm USCLN
        private int TinhUSCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy 2 số từ textbox
            if (!int.TryParse(txt1.Text, out int a) || !int.TryParse(txt2.Text, out int b))
            {
                MessageBox.Show("Vui lòng nhập 2 số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra radio nào được chọn và tính toán
            if (radUSCLN.Checked)
            {
                int uscln = TinhUSCLN(a, b);
                txt3.Text = uscln.ToString();
            }
            else if (radBSCNN.Checked)
            {
                int uscln = TinhUSCLN(a, b);
                int bscnn = Math.Abs(a * b) / uscln;
                txt3.Text = bscnn.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            radUSCLN.Checked = false;
            radBSCNN.Checked = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
