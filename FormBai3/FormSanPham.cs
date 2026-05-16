using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;


namespace FormBai3
{
    public partial class FormSanPham : Form
    {
        private Dictionary<string, List<SanPham>> categories;
        public FormSanPham()
        {
            InitializeComponent();
            InitializeData();
            InitializeTreeView();
        }

        private void InitializeData()
        {
            categories = new Dictionary<string, List<SanPham>>
            {
                ["Thực phẩm"] = new List<SanPham>
                {
                    new SanPham { Ma = "TP001", Ten = "Gạo ST25", Gia = 150000, TonKho = 50 },
                    new SanPham { Ma = "TP002", Ten = "Bánh mỳ tươi", Gia = 12000, TonKho = 30 },
                    new SanPham { Ma = "TP003", Ten = "Mỳ tôm", Gia = 9000, TonKho = 40 },
                    new SanPham { Ma = "TP004", Ten = "Trứng gà", Gia = 25000, TonKho = 60 },
                    new SanPham { Ma = "TP005", Ten = "Thịt heo", Gia = 90000, TonKho = 20 },
                    new SanPham { Ma = "TP006", Ten = "Cá hồi", Gia = 150000, TonKho = 10 }
                },

                ["Đồ uống"] = new List<SanPham>
                {
                    new SanPham { Ma = "DU001", Ten = "Nước ngọt", Gia = 15000, TonKho = 100 },
                    new SanPham { Ma = "DU002", Ten = "Sữa tươi", Gia = 20000, TonKho = 80 },
                    new SanPham { Ma = "DU003", Ten = "Trà xanh", Gia = 18000, TonKho = 50 },
                    new SanPham { Ma = "DU004", Ten = "Cà phê", Gia = 30000, TonKho = 70 },
                    new SanPham { Ma = "DU005", Ten = "Nước ép trái cây", Gia = 25000, TonKho = 60 },
                    new SanPham { Ma = "DU006", Ten = "Soda", Gia = 12000, TonKho = 90 },
                    new SanPham { Ma = "DU007", Ten = "Nước lọc", Gia = 5000, TonKho = 200 }
                },

                ["Gia vị"] = new List<SanPham>
                {
                    new SanPham { Ma = "GV001", Ten = "Muối", Gia = 5000, TonKho = 200 },
                    new SanPham { Ma = "GV002", Ten = "Đường", Gia = 8000, TonKho = 150 },
                    new SanPham { Ma = "GV003", Ten = "Tiêu", Gia = 10000, TonKho = 120 },
                    new SanPham { Ma = "GV004", Ten = "Bột ngọt", Gia = 7000, TonKho = 100 },
                    new SanPham { Ma = "GV005", Ten = "Ớt bột", Gia = 12000, TonKho = 80 }
                },

                ["Đồ gia dụng"] = new List<SanPham>
                {
                    new SanPham { Ma = "DG001", Ten = "Nồi cơm điện", Gia = 500000, TonKho = 15 },
                    new SanPham { Ma = "DG002", Ten = "Quạt điện", Gia = 300000, TonKho = 20 },
                    new SanPham { Ma = "DG003", Ten = "Bình nước nóng", Gia = 400000, TonKho = 10 },
                    new SanPham { Ma = "DG004", Ten = "Máy xay sinh tố", Gia = 350000, TonKho = 12 },
                    new SanPham { Ma = "DG005", Ten = "Ấm siêu tốc", Gia = 250000, TonKho = 18 },
                    new SanPham { Ma = "DG006", Ten = "Chảo chống dính", Gia = 150000, TonKho = 25 }
                }
            };
        }
        private void InitializeTreeView()
        {
            trvSanPham.Nodes.Clear();
            foreach (var category in categories.Keys)
            {
                trvSanPham.Nodes.Add(new TreeNode(category));
            }

            trvSanPham.AfterSelect += trvSanPham_AfterSelect;
        }
        // Khi chọn danh mục trong TreeView
        private void trvSanPham_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DisplayProducts(e.Node.Text);
        }
        // Hiển thị danh sách sản phẩm trong ListView
        private void DisplayProducts(string category)
        {
            lsvSanPham.Items.Clear();
            if (!categories.ContainsKey(category)) return;

            foreach (var product in categories[category])
            {
                var item = new ListViewItem(product.Ma);
                item.SubItems.Add(product.Ten);
                item.SubItems.Add(product.Gia.ToString("N0", CultureInfo.InvariantCulture));
                item.SubItems.Add(product.TonKho.ToString());
                item.Tag = product;
                lsvSanPham.Items.Add(item);
            }
        }

        public class SanPham
        {
            public string Ma { get; set; }
            public string Ten { get; set; }
            public decimal Gia { get; set; }
            public int TonKho { get; set; }

            public SanPham() { }
            public SanPham(string ma, string ten, decimal gia, int tonKho)
            {
                Ma = ma;
                Ten = ten;
                Gia = gia;
                TonKho = tonKho;
            }
        }

        private void tsmiXem_Click(object sender, EventArgs e)
        {
            if (lsvSanPham.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var item = lsvSanPham.SelectedItems[0];
            string ma = item.SubItems[0].Text;
            string ten = item.SubItems[1].Text;
            string gia = item.SubItems[2].Text;
            string tonKho = item.SubItems[3].Text;

            MessageBox.Show($"Mã: {ma}\nTên: {ten}\nGiá: {gia}\nTồn kho: {tonKho}",
                "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Khi chọn "Xóa sản phẩm"
        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            if (lsvSanPham.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var item = lsvSanPham.SelectedItems[0];
            string ma = item.SubItems[0].Text;

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {ma} không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // Xóa khỏi ListView
                lsvSanPham.Items.Remove(item);

                string currentCategory = trvSanPham.SelectedNode?.Text;
                if (!string.IsNullOrEmpty(currentCategory) && categories.ContainsKey(currentCategory))
                {
                    categories[currentCategory].RemoveAll(sp => sp.Ma == ma);
                }
            }
        }

        private void lsvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
