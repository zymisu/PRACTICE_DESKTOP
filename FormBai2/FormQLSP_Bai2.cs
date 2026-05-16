using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormBai2
{
    public partial class FormQuanLySP : Form
    {
        public FormQuanLySP()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(txt1, "Nhập tên sản phẩm");
            toolTip1.SetToolTip(nud1, "Nhập số lượng > 0");

            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Load += FormQuanLySP_Load;
        }
        private void FormQuanLySP_Load(object sender, EventArgs e)
        {
            // Khởi tạo tình trạng ban đầu
            rad1.Checked = false;
            rad2.Checked = false;
            cbo1.SelectedIndex = -1;
            CapNhatTongSanPham();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Kiểm tra lỗi
            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txt1.Text))
            {
                errorProvider1.SetError(txt1, "Tên sản phẩm không được để trống!");
                hopLe = false;
            }
            else errorProvider1.SetError(txt1, "");

            if (nud1.Value <= 0)
            {
                errorProvider1.SetError(nud1, "Số lượng phải lớn hơn 0!");
                hopLe = false;
            }
            else errorProvider1.SetError(nud1, "");

            // Kiểm tra tình trạng
            if (!rad1.Checked && !rad2.Checked)
            {
                MessageBox.Show("Vui lòng chọn tình trạng sản phẩm (Còn / Hết)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hopLe = false;
            }
            if (!hopLe) return;
            // Thêm vào DataGridView
            string tinhTrang = rad1.Checked ? "Còn" : "Hết";
            dgvSanPham.Rows.Add(txt1.Text.Trim(), cbo1.Text, nud1.Value, tinhTrang);
            CapNhatTongSanPham();

            txt1.Clear();
            cbo1.SelectedIndex = -1;
            nud1.Value = 0;
            rad1.Checked = false;
            rad2.Checked = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra lỗi
            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txt1.Text))
            {
                errorProvider1.SetError(txt1, "Tên sản phẩm không được để trống!");
                hopLe = false;
            }
            else errorProvider1.SetError(txt1, "");

            if (nud1.Value <= 0)
            {
                errorProvider1.SetError(nud1, "Số lượng phải lớn hơn 0!");
                hopLe = false;
            }
            else errorProvider1.SetError(nud1, "");

            if (!hopLe) return;

            // Sửa dòng đang chọn
            DataGridViewRow row = dgvSanPham.SelectedRows[0];
            row.Cells["Column1"].Value = txt1.Text.Trim();
            row.Cells["Column2"].Value = cbo1.Text;
            row.Cells["Column3"].Value = nud1.Value;
            row.Cells["Column4"].Value = rad1.Checked ? "Còn" : "Hết";

            CapNhatTongSanPham();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvSanPham.Rows.RemoveAt(dgvSanPham.SelectedRows[0].Index);
            CapNhatTongSanPham();
        }
        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            // Không cập nhật tự động vào bảng
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            // Không cập nhật tự động vào bảng
        }
        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgvSanPham.SelectedRows[0];
            txt1.Text = row.Cells["Column1"].Value?.ToString();
            cbo1.Text = row.Cells["Column2"].Value?.ToString();
            nud1.Value = Convert.ToDecimal(row.Cells["Column3"].Value);

            string tt = row.Cells["Column4"].Value?.ToString();
            rad1.Checked = tt == "Còn";
            rad2.Checked = tt == "Hết";
        }
        private void CapNhatTongSanPham()
        {
            int tong = 0;
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                string tinhTrang = row.Cells["Column4"].Value?.ToString();
                if (tinhTrang == "Còn")
                {
                    if (int.TryParse(row.Cells["Column3"].Value?.ToString(), out int sl))
                        tong += sl;
                }
            }

            tssl1.Text = $"Tổng số sản phẩm: {tong}";
        }        
    }
}










