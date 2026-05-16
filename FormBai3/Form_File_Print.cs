using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBai3
{ 
    public partial class Form_File_Print : Form, QLCuaHangMini.IPermission
    {
        private Dictionary<string, List<SanPham>> danhSachSP = new Dictionary<string, List<SanPham>>();
        private bool isAdmin = false;

        public Form_File_Print()
        {
            InitializeComponent();
            InitializeData();
            InitializeTreeView();
        }

        // ================== PHÂN QUYỀN ==================
        public void SetPermission(bool isAdmin)
        {
            this.isAdmin = isAdmin;

            tsmiXoa.Enabled = isAdmin;
            btnImport.Enabled = isAdmin;
            btnExport.Enabled = isAdmin;
            btnMoPhong.Enabled = isAdmin;

            tsmiXem.Enabled = true;
            lsvSanPham.Enabled = true;
            trvSanPham.Enabled = true;

            this.Text = isAdmin
                ? "Quản lý sản phẩm (Admin - Toàn quyền)"
                : "Quản lý sản phẩm (Chỉ xem)";
        }

        // ================== KHỞI TẠO DỮ LIỆU ==================
        private void InitializeData()
        {
            danhSachSP = new Dictionary<string, List<SanPham>>
            {
                ["Thực phẩm"] = new List<SanPham>
                {
                    new SanPham("TP001","Gạo ST25",150000,50),
                    new SanPham("TP002","Bánh mỳ tươi",12000,30),
                    new SanPham("TP003","Mỳ tôm",9000,40),
                    new SanPham("TP004","Trứng gà",25000,60),
                    new SanPham("TP005","Thịt heo",90000,20),
                    new SanPham("TP006","Cá hồi",150000,10)
                },
                ["Đồ uống"] = new List<SanPham>
                {
                    new SanPham("DU001","Nước ngọt",15000,100),
                    new SanPham("DU002","Sữa tươi",20000,80),
                    new SanPham("DU003","Trà xanh",18000,50),
                    new SanPham("DU004","Cà phê",30000,70),
                    new SanPham("DU005","Nước ép trái cây",25000,60),
                    new SanPham("DU006","Soda",12000,90),
                    new SanPham("DU007","Nước lọc",5000,200)
                },
                ["Gia vị"] = new List<SanPham>
                {
                    new SanPham("GV001","Muối",5000,200),
                    new SanPham("GV002","Đường",8000,150),
                    new SanPham("GV003","Tiêu",10000,120),
                    new SanPham("GV004","Bột ngọt",7000,100),
                    new SanPham("GV005","Ớt bột",12000,80)
                },
                ["Đồ gia dụng"] = new List<SanPham>
                {
                    new SanPham("DG001","Nồi cơm điện",500000,15),
                    new SanPham("DG002","Quạt điện",300000,20),
                    new SanPham("DG003","Bình nước nóng",400000,10),
                    new SanPham("DG004","Máy xay sinh tố",350000,12),
                    new SanPham("DG005","Ấm siêu tốc",250000,18),
                    new SanPham("DG006","Chảo chống dính",150000,25)
                }
            };
        }

        private void InitializeTreeView()
        {
            trvSanPham.Nodes.Clear();
            foreach (var danhMuc in danhSachSP.Keys)
                trvSanPham.Nodes.Add(danhMuc);

            trvSanPham.AfterSelect += TrvSanPham_AfterSelect;
        }

        private void TrvSanPham_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DisplayProducts(e.Node.Text);
        }

        private void DisplayProducts(string danhMuc)
        {
            lsvSanPham.Items.Clear();
            if (!danhSachSP.ContainsKey(danhMuc)) return;

            foreach (var sp in danhSachSP[danhMuc])
            {
                var item = new ListViewItem(sp.Ma);
                item.SubItems.Add(sp.Ten);
                item.SubItems.Add(sp.Gia.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")));
                item.SubItems.Add(sp.TonKho.ToString());
                item.Tag = sp;
                lsvSanPham.Items.Add(item);
            }
        }

        // ================== XEM CHI TIẾT ==================
        private void tsmiXem_Click(object sender, EventArgs e)
        {
            if (lsvSanPham.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thông báo");
                return;
            }

            var item = lsvSanPham.SelectedItems[0];
            MessageBox.Show(
                $"Mã: {item.SubItems[0].Text}\nTên: {item.SubItems[1].Text}\nGiá: {item.SubItems[2].Text}\nTồn kho: {item.SubItems[3].Text}",
                "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ================== XÓA SẢN PHẨM ==================
        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Bạn không có quyền xóa sản phẩm!", "Cảnh báo");
                return;
            }

            if (lsvSanPham.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.", "Thông báo");
                return;
            }

            var item = lsvSanPham.SelectedItems[0];
            string ma = item.SubItems[0].Text;

            if (MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {ma} không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string danhMuc = trvSanPham.SelectedNode?.Text;
                if (!string.IsNullOrEmpty(danhMuc) && danhSachSP.ContainsKey(danhMuc))
                {
                    danhSachSP[danhMuc].RemoveAll(sp => sp.Ma == ma);
                    DisplayProducts(danhMuc);
                }
            }
        }

        // ================== IMPORT FILE CSV ==================
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Bạn không có quyền import dữ liệu!", "Cảnh báo");
                return;
            }

            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog1.Title = "Chọn file CSV để import";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportFromCSV(openFileDialog1.FileName);
                    MessageBox.Show("Import dữ liệu thành công!", "Thông báo");
                    if (trvSanPham.SelectedNode != null)
                        DisplayProducts(trvSanPham.SelectedNode.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi import: {ex.Message}", "Lỗi");
                }
            }
        }

        private void ImportFromCSV(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length >= 4)
                {
                    string ma = parts[0].Trim();
                    string ten = parts[1].Trim();
                    decimal gia = decimal.Parse(parts[2]);
                    int tonKho = int.Parse(parts[3]);

                    var sp = new SanPham(ma, ten, gia, tonKho);

                    if (!danhSachSP.ContainsKey("Import"))
                        danhSachSP["Import"] = new List<SanPham>();

                    danhSachSP["Import"].Add(sp);
                }
            }

            if (!trvSanPham.Nodes.ContainsKey("Import"))
                trvSanPham.Nodes.Add("Import");
        }

        // ================== EXPORT FILE CSV ==================
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Bạn không có quyền export!", "Cảnh báo");
                return;
            }

            saveFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog1.FileName = "BaoCaoDoanhThu.csv";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportToCSV(saveFileDialog1.FileName);
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi export: {ex.Message}", "Lỗi");
                }
            }
        }

        private void ExportToCSV(string filePath)
        {
            using (var sw = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine("Mã SP,Tên SP,Giá,Tồn Kho,Danh Mục");
                foreach (var kvp in danhSachSP)
                {
                    foreach (var sp in kvp.Value)
                        sw.WriteLine($"{sp.Ma},{sp.Ten},{sp.Gia},{sp.TonKho},{kvp.Key}");
                }
            }
        }

        // ================== MÔ PHỎNG EXPORT ==================
        private async void btnMoPhong_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Chỉ Admin mới được phép mô phỏng export!");
                return;
            }

            if (danhSachSP.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để export!");
                return;
            }

            progressBar1.Value = 0;
            progressBar1.Maximum = danhSachSP.Count;
            lbl1.Text = "0%";

            int i = 0;
            foreach (var dm in danhSachSP)
            {
                await Task.Delay(700);
                i++;
                progressBar1.Value = i;
                int percent = (int)((double)i / progressBar1.Maximum * 100);
                lbl1.Text = percent + "%";
                this.Text = $"Exporting... {percent}%";
            }

            lbl1.Text = "Hoàn tất!";
            MessageBox.Show("Mô phỏng export hoàn tất!", "Thông báo");
        }

        // ================== CLASS SẢN PHẨM ==================
        public class SanPham
        {
            public string Ma { get; set; }
            public string Ten { get; set; }
            public decimal Gia { get; set; }
            public int TonKho { get; set; }

            public SanPham() { }
            public SanPham(string ma, string ten, decimal gia, int ton)
            {
                Ma = ma; Ten = ten; Gia = gia; TonKho = ton;
            }
        }
    }
}
