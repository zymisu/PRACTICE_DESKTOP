using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBai1
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }
        // a. Sự kiện Form Load
        private void Form1_Load(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Bạn có muốn mở ứng dụng không?", "Xác nhận",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question)
                == DialogResult.Cancel)
            {
                Dispose();
            }
        }
        // b. Nhấn nút "Hiển thị"
        private void btnHienthi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1.Text))
            { MessageBox.Show("Nhập nội dung:" + txt1.Text);}
            else 
            { MessageBox.Show("Yêu cầu nhập nội dung!");}
        }
        // c. Nhấn tổ hợp phím ALT + H
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
            {
                txt1.Text = "Xin chào Khoa CNTTKD";
            }
        }
        // d. Click chuột hiển thị thông báo người dùng vừa nhấp chuột
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                { MessageBox.Show("Bạn đang nhấn chuột trái:"); }
            }
            if (e.Button == MouseButtons.Right)
            {
                { MessageBox.Show("Bạn đang nhấn chuột phải:"); }
            }
            if (e.Button == MouseButtons.Middle)
            {
                { MessageBox.Show("Bạn đang nhấn chuột giữa:"); }
            }
        }
            // e. Nhấn nút "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?","Xác nhận thoát",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                Dispose();
            }
        }
    }
}
