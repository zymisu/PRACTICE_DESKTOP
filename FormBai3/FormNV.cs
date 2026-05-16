using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace FormBai3
{
    public partial class FormNV : Form, QLCuaHangMini.IPermission
    {
        private List<NhanVien> danhSachNV = new List<NhanVien>();
        private bool isUpdating = false;
        private bool isAdmin; 

        public FormNV()
        {
            InitializeComponent();

            // Thiết lập DataGridView
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.MultiSelect = false;

            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            // Dữ liệu mẫu
            danhSachNV.AddRange(new[]
            {
                new NhanVien { MaNV = "NV001", HoTen = "Phạm Mỹ Anh", GioiTinh = "Nữ", SDT = "0912347652", ChucVu = "Kế toán", MucLuong = 15000000 },
                new NhanVien { MaNV = "NV002", HoTen = "Hồ Thảo Ly", GioiTinh = "Nữ", SDT = "0806324578", ChucVu = "Nhân sự", MucLuong = 12000000 },
                new NhanVien { MaNV = "NV003", HoTen = "Hoàng Duy Khải", GioiTinh = "Nam", SDT = "0913167589", ChucVu = "Thu ngân", MucLuong = 6000000 }
            });

            HienThi();
        }

        // ✅ KHÔNG GỌI SetPermission Ở ĐÂY
        // (tránh việc form Load ghi đè quyền)
        private void FormNV_Load(object sender, EventArgs e)
        {
            // Không set isAdmin ở đây nữa
        }

        // Interface IPermission
        public void SetPermission(bool isAdmin)
        {
            this.isAdmin = isAdmin; // giữ lại quyền thật sự

            // Debug xem quyền được truyền đúng chưa
            // MessageBox.Show($"SetPermission nhận: {isAdmin}");

            // Cập nhật quyền điều khiển
            btnThem.Enabled = isAdmin;
            btnSua.Enabled = isAdmin;
            btnXoa.Enabled = isAdmin;

            txtMa.ReadOnly = !isAdmin;
            txtHoTen.ReadOnly = !isAdmin;
            txtSoDT.ReadOnly = !isAdmin;
            txtLuong.ReadOnly = !isAdmin;
            cboChucVu.Enabled = isAdmin;
            cboGioiTinh.Enabled = isAdmin;

            this.Text = isAdmin
                ? "Quản lý nhân viên (Admin - Toàn quyền)"
                : "Quản lý nhân viên (Chỉ xem)";
        }

        private void HienThi()
        {
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = danhSachNV;
            if (dgvNhanVien.Columns["MucLuong"] != null)
            {
                dgvNhanVien.Columns["MucLuong"].DefaultCellStyle.Format = "N0";
                dgvNhanVien.Columns["MucLuong"].DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Bạn không có quyền thêm nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMa.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(cboChucVu.Text) ||
                string.IsNullOrWhiteSpace(txtSoDT.Text) ||
                string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả thông tin!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (danhSachNV.Any(nv => nv.MaNV == txtMa.Text))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Trùng mã",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            danhSachNV.Add(new NhanVien
            {
                MaNV = txtMa.Text,
                HoTen = txtHoTen.Text,
                GioiTinh = cboGioiTinh.Text,
                SDT = txtSoDT.Text,
                ChucVu = cboChucVu.Text,
                MucLuong = decimal.TryParse(txtLuong.Text, out var luong) ? luong : 0
            });

            HienThi();
            LamMoi();
            MessageBox.Show("Đã thêm nhân viên thành công!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Bạn không có quyền sửa thông tin nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ma = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            var nv = danhSachNV.FirstOrDefault(x => x.MaNV == ma);

            if (nv != null)
            {
                nv.HoTen = txtHoTen.Text;
                nv.GioiTinh = cboGioiTinh.Text;
                nv.SDT = txtSoDT.Text;
                nv.ChucVu = cboChucVu.Text;
                nv.MucLuong = decimal.TryParse(txtLuong.Text, out var luong) ? luong : 0;

                HienThi();
                MessageBox.Show("Đã sửa thông tin nhân viên thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Bạn không có quyền xóa nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ma = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            var nv = danhSachNV.FirstOrDefault(x => x.MaNV == ma);

            if (nv != null)
            {
                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn xóa nhân viên '{nv.HoTen}' (Mã: {nv.MaNV})?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    danhSachNV.Remove(nv);
                    HienThi();
                    LamMoi();
                    MessageBox.Show("Đã xóa nhân viên thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            isUpdating = true;
            txtMa.Clear();
            txtHoTen.Clear();
            cboGioiTinh.SelectedIndex = -1;
            txtSoDT.Clear();
            cboChucVu.SelectedIndex = -1;
            txtLuong.Clear();
            dgvNhanVien.ClearSelection();
            isUpdating = false;
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (isUpdating || dgvNhanVien.CurrentRow == null) return;

            txtMa.Text = dgvNhanVien.CurrentRow.Cells["MaNV"].Value?.ToString();
            txtHoTen.Text = dgvNhanVien.CurrentRow.Cells["HoTen"].Value?.ToString();
            cboGioiTinh.Text = dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value?.ToString();
            txtSoDT.Text = dgvNhanVien.CurrentRow.Cells["SDT"].Value?.ToString();
            cboChucVu.Text = dgvNhanVien.CurrentRow.Cells["ChucVu"].Value?.ToString();
            txtLuong.Text = dgvNhanVien.CurrentRow.Cells["MucLuong"].Value?.ToString();
        }

        // Class dữ liệu nhân viên
        public class NhanVien
        {
            public string MaNV { get; set; }
            public string HoTen { get; set; }
            public string GioiTinh { get; set; }
            public string SDT { get; set; }
            public string ChucVu { get; set; }
            public decimal MucLuong { get; set; }
        }
    }
}
