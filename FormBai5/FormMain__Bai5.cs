using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBai5
{
    public partial class FormMain__Bai5 : Form
    {
        public FormMain__Bai5()
        {
            InitializeComponent();
        }
        private void tsmForecast_Click(object sender, EventArgs e)
        {
            FormForecast f = new FormForecast();
            f.Show();
        }
        private void tsmWarning_Click(object sender, EventArgs e)
        {
            string info = "";
            info += "⚙ PHẦN MỀM CẢNH BÁO THỜI TIẾT REALTIME\n";
            info += "----------------------------------------------\n";
            info += "• Môn: Phát triẻn ứng dụng Desktop\n";
            info += "• Công nghệ: .NET Framework + SignalR\n";
            info += "• Admin cập nhật mỗi 5 giây\n";
            info += "• User nhận thông báo tức thời (không cần refresh)\n";
            info += "• Tích hợp hiệu ứng cảnh báo + âm thanh ting\n";
            info += "\nVersion: 1.0.0\n";
            info += "Build: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            MessageBox.Show(info, "Thông tin hệ thống",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        private void tsmAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin();
            f.Show();
        }

        private void tsmUser_Click(object sender, EventArgs e)
        {
            FormUser f = new FormUser();
            f.Show();
        }
        private void tsmYoutube_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\anhba\source\repos\API và dịch vụ bên ngoài\WinFormYoutube\WinFormYoutube\bin\Debug\net8.0-windows\WinFormsYoutube.exe";

            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = path,
                UseShellExecute = true
            };

            Process.Start(psi);
        }

    }
}
