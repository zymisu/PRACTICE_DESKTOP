using System;
using System.Data.SQLite;

namespace QuanLyBanHang
{
    class DatabaseSetup
    {
        public static void CreateDatabase()
        {
            // 1. Tạo file database 
            SQLiteConnection.CreateFile("QLBH.db");

            // 2. Kết nối
            using (var conn = new SQLiteConnection("Data Source=QLBH.db;Version=3;"))
            {
                conn.Open();

                // 3. Tạo bảng KhachHang
                string sqlKhachHang = @"CREATE TABLE IF NOT EXISTS KhachHang(
                    MaKH TEXT PRIMARY KEY,
                    TenKH TEXT,
                    DiaChi TEXT,
                    DienThoai TEXT
                );";
                new SQLiteCommand(sqlKhachHang, conn).ExecuteNonQuery();

                // 4. Tạo bảng NhanVien
                string sqlNhanVien = @"CREATE TABLE IF NOT EXISTS NhanVien(
                    MaNV TEXT PRIMARY KEY,
                    TenNV TEXT,
                    GioiTinh INTEGER,
                    DiaChi TEXT,
                    DienThoai TEXT
                );";
                new SQLiteCommand(sqlNhanVien, conn).ExecuteNonQuery();

                // 5. Tạo bảng LoaiSanPham
                string sqlLoaiSP = @"CREATE TABLE IF NOT EXISTS LoaiSanPham(
                    MaLoai TEXT PRIMARY KEY,
                    TenLoai TEXT
                );";
                new SQLiteCommand(sqlLoaiSP, conn).ExecuteNonQuery();

                // 6. Tạo bảng SanPham
                string sqlSanPham = @"CREATE TABLE IF NOT EXISTS SanPham(
                    MaSP TEXT PRIMARY KEY,
                    TenSP TEXT,
                    DVTinh TEXT,
                    DonGia INTEGER,
                    MaLoai TEXT,
                    FOREIGN KEY(MaLoai) REFERENCES LoaiSanPham(MaLoai)
                );";
                new SQLiteCommand(sqlSanPham, conn).ExecuteNonQuery();

                // 7. Tạo bảng HoaDon
                string sqlHoaDon = @"CREATE TABLE IF NOT EXISTS HoaDon(
                    MaHD TEXT PRIMARY KEY,
                    MaKH TEXT,
                    MaNV TEXT,
                    NgayHD TEXT,
                    NgayNhan TEXT,
                    ThanhTien INTEGER,
                    FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH),
                    FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
                );";
                new SQLiteCommand(sqlHoaDon, conn).ExecuteNonQuery();

                // 8. Tạo bảng ChiTietHoaDon
                string sqlChiTietHD = @"CREATE TABLE IF NOT EXISTS ChiTietHoaDon(
                    MaHD TEXT,
                    MaSP TEXT,
                    SoLuong INTEGER,
                    GiaBan INTEGER,
                    PRIMARY KEY(MaHD, MaSP),
                    FOREIGN KEY(MaHD) REFERENCES HoaDon(MaHD),
                    FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP)
                );";
                new SQLiteCommand(sqlChiTietHD, conn).ExecuteNonQuery();

                // 9. Chèn dữ liệu mẫu LoaiSanPham
                string insertLoaiSP = @"INSERT OR IGNORE INTO LoaiSanPham VALUES
                    ('L001','Thời trang'),
                    ('L002','Báo'),
                    ('L003','Sách'),
                    ('L004','Đồ công nghệ');";
                new SQLiteCommand(insertLoaiSP, conn).ExecuteNonQuery();

                // 10. Chèn dữ liệu mẫu SanPham
                string insertSanPham = @"INSERT OR IGNORE INTO SanPham VALUES
                    ('SP001','Giáo trình Tin học đại cương','quyển',45000,'L003'),
                    ('SP002','Giáo trình C# toàn tập','quyển',70000,'L003'),
                    ('SP003','Thiết kế Web chuyên nghiệp','quyển',30000,'L003'),
                    ('SP004','Áo thun 3 lỗ','cái',50000,'L001'),
                    ('SP005','Quần Jean','cái',200000,'L001'),
                    ('SP006','Giáo trình OOP1','quyển',40000,'L003'),
                    ('SP007','Giáo trình OOP2','quyển',50000,'L003'),
                    ('SP008','Giáo trình Kế toán','quyển',45000,'L003'),
                    ('SP009','Iphone 4s','cái',4500000,'L004'),
                    ('SP010','Iphone 5','cái',8000000,'L004'),
                    ('SP011','Iphone 5s','cái',11000000,'L004'),
                    ('SP012','Máy tính bảng S','cái',7000000,'L004');";
                new SQLiteCommand(insertSanPham, conn).ExecuteNonQuery();

                conn.Close();
            }

            Console.WriteLine("Database QLBH.db đã được tạo và có dữ liệu!");
        }
    }
}
