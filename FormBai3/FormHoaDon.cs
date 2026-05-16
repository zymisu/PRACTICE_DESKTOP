using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace FormBai3
{
    public partial class FormHoaDon : Form, QLCuaHangMini.IPermission
    {
        private bool isAdmin = false;
        private List<HoaDon> danhSachHoaDon;
        private List<ChiTietHoaDon> danhSachChiTiet;
        private List<ChiTietHoaDon> chiTietHienTai;

        private List<SanPham> danhSachSP;
        private string currentUser = "Admin";

        private PrintDocument printDocument;
        private int currentItemIndex = 0;

        public FormHoaDon()
        {
            InitializeComponent();
            KhoiTaoDuLieu();
            KhoiTaoDGV();
            GenerateMaHD();

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        // ========================== PHÂN QUYỀN ==========================
        public void SetPermission(bool isAdmin)
        {
            this.isAdmin = isAdmin;
            txtNV.Text = "Admin";

            btnThem.Enabled = true;
            btnTao.Enabled = isAdmin;
            btnIn.Enabled = isAdmin;
            btnLamMoi.Enabled = true;
            txtKH.ReadOnly = !isAdmin;

            this.Text = isAdmin
                ? "Quản lý hóa đơn (Admin - Toàn quyền)"
                : "Quản lý hóa đơn (Người dùng - Chỉ thêm sản phẩm)";
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            txtNV.Text = currentUser;
            nudSL.Value = 1;
        }

        // ========================== KHỞI TẠO DỮ LIỆU ==========================
        private void KhoiTaoDuLieu()
        {
            danhSachHoaDon = new List<HoaDon>();
            danhSachChiTiet = new List<ChiTietHoaDon>();
            chiTietHienTai = new List<ChiTietHoaDon>();

            danhSachSP = new List<SanPham>
            {
                new SanPham("TP01","Gạo Jasmine 5kg","Thực phẩm",180000,50),
                new SanPham("TP02","Mì gói Hảo Hảo","Thực phẩm",3500,200),
                new SanPham("TP03","Trứng gà 10 quả","Thực phẩm",30000,100),
                new SanPham("TP04","Sữa tươi Vinamilk 1L","Thực phẩm",23000,80),
                new SanPham("TP05","Phô mai con bò cười","Thực phẩm",15000,60),
                new SanPham("NU01","Nước ngọt Coca-Cola 500ml","Đồ uống",12000,100),
                new SanPham("NU02","Trà Lipton 1L","Đồ uống",25000,70),
                new SanPham("NU03","Cà phê hòa tan G7","Đồ uống",45000,50),
                new SanPham("NU04","Nước suối Aquafina 500ml","Đồ uống",8000,150),
                new SanPham("NU05","Sữa đậu nành Fami 1L","Đồ uống",20000,60),
                new SanPham("GV01","Muối I-ốt 500g","Gia vị",7000,100),
                new SanPham("GV02","Đường cát trắng 1kg","Gia vị",12000,80),
                new SanPham("GV03","Hạt nêm Knorr 500g","Gia vị",30000,50),
                new SanPham("GV04","Tiêu xay 50g","Gia vị",15000,70),
                new SanPham("GV05","Nước mắm 500ml","Gia vị",25000,60),
                new SanPham("DG01","Xà phòng OMO 200g","Đồ gia dụng",10000,80),
                new SanPham("DG02","Nước rửa chén Sunlight 500ml","Đồ gia dụng",22000,50),
                new SanPham("DG03","Bột giặt Tide 1kg","Đồ gia dụng",90000,40),
                new SanPham("DG04","Giấy vệ sinh 10 cuộn","Đồ gia dụng",50000,30),
                new SanPham("DG05","Khăn giấy ăn 200 tờ","Đồ gia dụng",15000,60)
            };

            cboSP.Items.Clear();
            foreach (var sp in danhSachSP)
                cboSP.Items.Add($"{sp.MaSP} - {sp.TenSP}");
        }

        private void KhoiTaoDGV()
        {
            dgvHoaDon.Columns.Clear();
            dgvHoaDon.Columns.Add("STT", "STT");
            dgvHoaDon.Columns.Add("MaSP", "Mã SP");
            dgvHoaDon.Columns.Add("TenSP", "Tên SP");
            dgvHoaDon.Columns.Add("Gia", "Đơn giá");
            dgvHoaDon.Columns.Add("SoLuong", "Số lượng");
            dgvHoaDon.Columns.Add("ThanhTien", "Thành tiền");

            dgvHoaDon.Columns["Gia"].DefaultCellStyle.Format = "#,##0";
            dgvHoaDon.Columns["ThanhTien"].DefaultCellStyle.Format = "#,##0";
        }

        private void GenerateMaHD()
        {
            string maHD = $"HD{danhSachHoaDon.Count + 1:D4}";
            txtHD.Text = maHD;
        }

        // ========================== THÊM GIỎ HÀNG ==========================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboSP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSP = cboSP.Text.Split('-')[0].Trim();
            var sp = danhSachSP.FirstOrDefault(x => x.MaSP == maSP);
            if (sp == null) return;

            int soLuong = (int)nudSL.Value;

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (soLuong > sp.TonKho)
            {
                MessageBox.Show($"Tồn kho không đủ! (Còn: {sp.TonKho})", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existing = chiTietHienTai.FirstOrDefault(x => x.SanPham.MaSP == maSP);
            if (existing != null)
                existing.SoLuong += soLuong;
            else
                chiTietHienTai.Add(new ChiTietHoaDon(txtHD.Text, sp, soLuong));

            LoadChiTietGrid();
            CapNhatTongTien();
        }

        // ========================== TẠO HÓA ĐƠN ==========================
        private void btnTao_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Chỉ Admin mới được tạo hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKH.Text))
            {
                MessageBox.Show("Nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (chiTietHienTai.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal tongTien = chiTietHienTai.Sum(ct => ct.ThanhTien);
            var hd = new HoaDon(txtHD.Text, txtKH.Text, currentUser, tongTien, DateTime.Now);
            danhSachHoaDon.Add(hd);

            foreach (var ct in chiTietHienTai)
            {
                var sp = danhSachSP.FirstOrDefault(x => x.MaSP == ct.SanPham.MaSP);
                if (sp != null) sp.TonKho -= ct.SoLuong;
                danhSachChiTiet.Add(ct);
            }

            var result = MessageBox.Show("Tạo hóa đơn thành công! Bạn có muốn in hóa đơn?",
                             "Thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                currentItemIndex = 0;
                PrintPreviewDialog preview = new PrintPreviewDialog { Document = printDocument };
                preview.WindowState = FormWindowState.Maximized;
                preview.ShowDialog();
            }

            chiTietHienTai.Clear();
            dgvHoaDon.Rows.Clear();
            txtKH.Clear();
            nudSL.Value = 1;
            GenerateMaHD();
            CapNhatTongTien();
        }

        // ========================== IN HÓA ĐƠN ==========================
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Chỉ Admin mới được in hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chiTietHienTai.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentItemIndex = 0;
            PrintPreviewDialog preview = new PrintPreviewDialog { Document = printDocument };
            preview.WindowState = FormWindowState.Maximized;
            preview.ShowDialog();
        }

        // ========================== LÀM MỚI ==========================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            chiTietHienTai.Clear();
            dgvHoaDon.Rows.Clear();
            txtKH.Clear();
            nudSL.Value = 1;
            GenerateMaHD();
            CapNhatTongTien();
        }

        private void LoadChiTietGrid()
        {
            dgvHoaDon.Rows.Clear();
            int stt = 1;
            foreach (var ct in chiTietHienTai)
            {
                dgvHoaDon.Rows.Add(stt++, ct.SanPham.MaSP, ct.SanPham.TenSP,
                    ct.SanPham.Gia.ToString("N0"), ct.SoLuong, ct.ThanhTien.ToString("N0"));
            }
        }

        private void CapNhatTongTien()
        {
            decimal tong = chiTietHienTai.Sum(ct => ct.ThanhTien);
            lblTongTien.Text = $"Tổng tiền: {tong:#,##0}đ";
        }

        // ========================== IN ẤN ==========================
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int yPos = 60;
            int left = 60;

            // ====== TIÊU ĐỀ ======
            g.DrawString("CỬA HÀNG BÁCH HÓA KOHKONG", new Font("Arial", 22, FontStyle.Bold), Brushes.Orange, left, yPos);
            yPos += 45;
            g.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, left, yPos);
            yPos += 40;

            // ====== THÔNG TIN HÓA ĐƠN ======
            g.DrawString($"Mã HĐ: {txtHD.Text}", new Font("Arial", 13), Brushes.Black, left, yPos);
            yPos += 28;
            g.DrawString($"Khách hàng: {txtKH.Text}", new Font("Arial", 13), Brushes.Black, left, yPos);
            yPos += 28;
            g.DrawString($"Nhân viên: {txtNV.Text}", new Font("Arial", 13), Brushes.Black, left, yPos);
            yPos += 28;
            g.DrawString($"Ngày lập hóa đơn: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", new Font("Arial", 13), Brushes.Black, left, yPos);
            yPos += 40;

            // ====== BẢNG SẢN PHẨM ======
            g.DrawString("STT", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, left, yPos);
            g.DrawString("Sản phẩm", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, left + 70, yPos);
            g.DrawString("Đơn giá", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, left + 330, yPos);
            g.DrawString("SL", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, left + 440, yPos);
            g.DrawString("Thành tiền", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, left + 520, yPos);
            yPos += 30;

            int stt = 1;
            foreach (var ct in chiTietHienTai)
            {
                g.DrawString(stt.ToString(), new Font("Arial", 13), Brushes.Black, left, yPos);
                g.DrawString(ct.SanPham.TenSP, new Font("Arial", 13), Brushes.Black, left + 70, yPos);
                g.DrawString(ct.SanPham.Gia.ToString("N0"), new Font("Arial", 13), Brushes.Black, left + 330, yPos);
                g.DrawString(ct.SoLuong.ToString(), new Font("Arial", 13), Brushes.Black, left + 440, yPos);
                g.DrawString(ct.ThanhTien.ToString("N0"), new Font("Arial", 13), Brushes.Black, left + 520, yPos);
                yPos += 30;
                stt++;
            }

            // ====== TỔNG TIỀN ======
            yPos += 40;
            decimal tongTien = chiTietHienTai.Sum(ct => ct.ThanhTien);
            string tongText = $"TỔNG TIỀN: {tongTien:N0} VND";

            SizeF tongSize = g.MeasureString(tongText, new Font("Arial", 22, FontStyle.Bold));
            float centerX = (e.PageBounds.Width - tongSize.Width) / 2;
            g.DrawString(tongText, new Font("Arial", 22, FontStyle.Bold), Brushes.Red, centerX, yPos);

            // ====== CẢM ƠN ======
            yPos += 80;
            string thank = "❤ Cảm ơn quý khách và hẹn gặp lại ❤";
            SizeF thankSize = g.MeasureString(thank, new Font("Arial", 16, FontStyle.Italic));
            float thankX = (e.PageBounds.Width - thankSize.Width) / 2;
            g.DrawString(thank, new Font("Arial", 16, FontStyle.Italic), Brushes.Orange, thankX, yPos);
        }
    }

    // ========================== CLASS DỮ LIỆU ==========================
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DanhMuc { get; set; }
        public decimal Gia { get; set; }
        public int TonKho { get; set; }

        public SanPham(string ma, string ten, string dm, decimal gia, int ton)
        {
            MaSP = ma; TenSP = ten; DanhMuc = dm; Gia = gia; TonKho = ton;
        }
    }

    public class HoaDon
    {
        public string MaHD { get; set; }
        public string TenKhachHang { get; set; }
        public string NhanVien { get; set; }
        public decimal TongTien { get; set; }
        public DateTime NgayLap { get; set; }

        public HoaDon(string ma, string kh, string nv, decimal tong, DateTime ngay)
        {
            MaHD = ma; TenKhachHang = kh; NhanVien = nv; TongTien = tong; NgayLap = ngay;
        }
    }

    public class ChiTietHoaDon
    {
        public string MaHD { get; set; }
        public SanPham SanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien => SanPham.Gia * SoLuong;

        public ChiTietHoaDon(string ma, SanPham sp, int sl)
        {
            MaHD = ma; SanPham = sp; SoLuong = sl;
        }
    }
}
