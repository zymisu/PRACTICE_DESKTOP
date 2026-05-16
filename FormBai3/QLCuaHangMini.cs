using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FormBai3
{
    public partial class QLCuaHangMini : Form
    {
        public string CurrentUser { get; private set; } = "Chưa đăng nhập";
        public bool IsAdmin { get; private set; } = false;
        public string CurrentForm { get; private set; } = "Trang chủ";

        // Dictionary lưu trữ dữ liệu gốc ListView
        private Dictionary<ListView, List<ListViewItem>> originalListViewItems = new Dictionary<ListView, List<ListViewItem>>();

        public QLCuaHangMini()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            notifyIcon1.Click += NotifyIcon1_Click;

            tstbTimKiem.TextChanged += tstbTimKiem_TextChanged;
            tstbTimKiem.KeyDown += tstbTimKiem_KeyDown;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = $"Thời gian: {DateTime.Now:HH:mm:ss dd/MM/yyyy}";
        }

        // ========================== ĐĂNG NHẬP ==========================
        private void tsmiDangNhap_Click(object sender, EventArgs e)
        {
            if (CurrentUser != "Chưa đăng nhập")
            {
                MessageBox.Show("Bạn đã đăng nhập rồi! Vui lòng đăng xuất trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (Form loginForm = new Form())
            {
                loginForm.Text = "Đăng nhập";
                loginForm.Size = new Size(350, 180);
                loginForm.StartPosition = FormStartPosition.CenterParent;
                loginForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                loginForm.MaximizeBox = false;
                loginForm.MinimizeBox = false;

                Label lblUser = new Label() { Left = 20, Top = 20, Text = "Tên đăng nhập:" };
                TextBox txtUser = new TextBox() { Left = 120, Top = 18, Width = 180 };

                Button btnLogin = new Button() { Text = "Đăng nhập", Left = 120, Top = 60, Width = 80 };
                Button btnCancel = new Button() { Text = "Hủy", Left = 220, Top = 60, Width = 80 };

                loginForm.Controls.Add(lblUser);
                loginForm.Controls.Add(txtUser);
                loginForm.Controls.Add(btnLogin);
                loginForm.Controls.Add(btnCancel);
                loginForm.AcceptButton = btnLogin;

                btnLogin.Click += (s, ev) =>
                {
                    string username = txtUser.Text.Trim();
                    if (string.IsNullOrEmpty(username))
                    {
                        MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (username.Equals("admin", StringComparison.OrdinalIgnoreCase))
                    {
                        CurrentUser = "Admin";
                        IsAdmin = true;
                    }
                    else
                    {
                        CurrentUser = username;
                        IsAdmin = false;
                    }

                    UpdateStatus();
                    UpdateAllChildFormsPermission();

                    MessageBox.Show($"Đăng nhập thành công!\nTài khoản: {CurrentUser}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loginForm.DialogResult = DialogResult.OK;
                    loginForm.Close();
                };

                btnCancel.Click += (s, ev) =>
                {
                    loginForm.DialogResult = DialogResult.Cancel;
                    loginForm.Close();
                };

                loginForm.ShowDialog();
            }
        }

        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            if (CurrentUser == "Chưa đăng nhập")
            {
                MessageBox.Show("Chưa đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Đăng xuất tài khoản '{CurrentUser}'?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CurrentUser = "Chưa đăng nhập";
                IsAdmin = false;
                UpdateStatus();
                UpdateAllChildFormsPermission();

                foreach (Form f in MdiChildren.ToArray())
                    f.Close();
            }
        }

        private void UpdateAllChildFormsPermission()
        {
            foreach (Form f in MdiChildren)
            {
                if (f is IPermission permForm)
                    permForm.SetPermission(this.IsAdmin);
            }
        }

        // ========================== CẬP NHẬT STATUSSTRIP ==========================
        private void UpdateStatus()
        {
            tsslUser.Text = $"Người dùng: {CurrentUser}";
            tsslTime.Text = $"Thời gian: {DateTime.Now:HH:mm:ss dd/MM/yyyy}";

            if (this.ActiveMdiChild != null)
                CurrentForm = this.ActiveMdiChild.Text;
            else
                CurrentForm = "Trang chủ";

            tsslForm.Text = $"Form hiện tại: {CurrentForm}";
        }

        private void tsmiNhanVien_Click(object sender, EventArgs e)
        {
            FormNV f = new FormNV();
            f.Show();
        }

        private void tsmiSanPham_Click(object sender, EventArgs e)
        {
            Form_File_Print f = new Form_File_Print();
            f.Show();
        }

        private void tsmiHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon f = new FormHoaDon();
            f.Show();
        }

        // ========================== GIỚI THIỆU & LIÊN HỆ ==========================
        private void tsmiGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "📦 QUẢN LÝ CỬA HÀNG MINI - KOHKONG STORE\n\n" +
                "Phiên bản: 1.0\n" +
                "Phát triển bởi: Nhóm Lập Trình Ứng Dụng\n" +
                "© 2025 - Cửa hàng bách hóa KOHKONG\n\n" +
                "Phần mềm quản lý:\n" +
                "• Nhân viên\n" +
                "• Sản phẩm\n" +
                "• Hóa đơn & In ấn\n" +
                "• Phân quyền người dùng (Admin/User)",
                "Giới thiệu phần mềm", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private void tsmiLienHe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "📞 THÔNG TIN LIÊN HỆ\n\n" +
                "💬 Hotline: 0882 215 831\n" +
                "📧 Email: kohkongstore@gmail.com\n" +
                "🏢 Địa chỉ: 172 Nguyễn Thị Thập, Phường Tân Hưng, Quận 7, TP.HCM\n" +
                "🌐 Website: www.kohkongstore.vn",
                "Liên hệ hỗ trợ", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        // ========================== THOÁT ==========================
        private void tsmiThoat_Click(object sender, EventArgs e) => Application.Exit();
      
        // ========================== NOTIFY ICON ==========================
        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Ứng dụng đang chạy nền";
                notifyIcon1.BalloonTipText = "KOHKONG STORE đang hoạt động ở khay hệ thống.\nNhấp vào biểu tượng để mở lại.";
                notifyIcon1.ShowBalloonTip(2000);
                this.Hide();
            }
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            notifyIcon1.Visible = false;
        }

        // ========================== TÌM KIẾM NHANH NÂNG CAO ==========================
        private void tstbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string text = tstbTimKiem.Text.Trim().ToLower();
            string[] keywords = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (Form f in MdiChildren)
            {
                // DataGridView
                var dgv = f.Controls.OfType<DataGridView>().FirstOrDefault();
                if (dgv != null)
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        // Reset highlight
                        foreach (DataGridViewCell cell in row.Cells)
                            cell.Style.BackColor = Color.White;

                        bool match = true;
                        foreach (string kw in keywords)
                        {
                            if (!row.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null && c.Value.ToString().ToLower().Contains(kw)))
                            {
                                match = false;
                                break;
                            }
                        }

                       
                        if (match)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value == null) continue;
                                string cellText = cell.Value.ToString().ToLower();
                                if (keywords.Any(k => cellText.Contains(k)))
                                    cell.Style.BackColor = Color.LightYellow;
                            }
                        }
                    }
                    dgv.Refresh();
                }

                // ListView
                var lv = f.Controls.OfType<ListView>().FirstOrDefault();
                if (lv != null && originalListViewItems.ContainsKey(lv))
                {
                    lv.BeginUpdate();
                    lv.Items.Clear();

                    foreach (var item in originalListViewItems[lv])
                    {
                        bool match = true;
                        foreach (string kw in keywords)
                        {
                            if (!item.SubItems.Cast<ListViewItem.ListViewSubItem>().Any(s => s.Text.ToLower().Contains(kw)))
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            var newItem = (ListViewItem)item.Clone();
                            foreach (ListViewItem.ListViewSubItem sub in newItem.SubItems)
                            {
                                if (keywords.Any(k => sub.Text.ToLower().Contains(k)))
                                    sub.BackColor = Color.LightYellow;
                                else
                                    sub.BackColor = Color.White;
                            }
                            lv.Items.Add(newItem);
                        }
                    }

                    lv.EndUpdate();
                }
            }
        }

        private void tstbTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tstbTimKiem.Clear();

                foreach (Form f in MdiChildren)
                {
                    // Reset DataGridView
                    var dgv = f.Controls.OfType<DataGridView>().FirstOrDefault();
                    if (dgv != null)
                    {
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            row.Visible = true;
                            foreach (DataGridViewCell cell in row.Cells)
                                cell.Style.BackColor = Color.White;
                        }
                        dgv.Refresh();
                    }

                    // Reset ListView
                    var lv = f.Controls.OfType<ListView>().FirstOrDefault();
                    if (lv != null && originalListViewItems.ContainsKey(lv))
                    {
                        lv.BeginUpdate();
                        lv.Items.Clear();
                        foreach (var item in originalListViewItems[lv])
                            lv.Items.Add((ListViewItem)item.Clone());
                        lv.EndUpdate();
                    }
                }
            }
        }

        // ========================== Interface IPermission ==========================
        public interface IPermission
        {
            void SetPermission(bool isAdmin);
        }
    }
}
