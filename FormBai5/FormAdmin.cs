using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormBai5;

namespace FormBai5
{
    public partial class FormAdmin : Form
    {
        private System.Windows.Forms.Timer _progressTimer;
        private int _progressCount = 0;
        private readonly int _intervalSeconds = 5;

        private IDisposable _signalRServer;
        private IHubContext _hubContext;

        private string _city = "Hà Nội";
        private double _temp = 38;
        private double _wind = 0;
        private bool _isRunning = false;

        public FormAdmin()
        {
            InitializeComponent();
            InitializeUI();
            StartSignalRServer();
        }

        private void InitializeUI()
        {
            lblCity.Text = $"📍 Địa điểm: {_city}";
            lblTemp.Text = $"🌡️ Nhiệt độ: {_temp}°C";
            lblWind.Text = $"💨 Gió: ";
            lblStatus.Text = $"☁️ Thời tiết: ";
            lblTime.Text = "🕐 Cập nhật lúc: ";

            pbTimer.Maximum = _intervalSeconds;
            pbTimer.Value = 0;
            lblUpdate.Text = $"{_intervalSeconds} giây";

            btnStart.Enabled = true;
            btnStop.Enabled = true;

            this.BackColor = Color.White;

            // Chỉ dùng 1 timer để vừa cập nhật progress bar vừa gửi data
            _progressTimer = new System.Windows.Forms.Timer();
            _progressTimer.Interval = 1000; // Mỗi giây
            _progressTimer.Tick += ProgressTimer_Tick;
        }

        private void StartSignalRServer()
        {
            Task.Run(() =>
            {
                try
                {
                    string url = "http://localhost:5000";
                    _signalRServer = WebApp.Start<Startup>(url);
                    _hubContext = GlobalHost.ConnectionManager.GetHubContext<WeatherHub>();

                    this.Invoke((Action)(() =>
                    {
                        lblServer.Text = "⚙️ Server đã sẵn sàng - Chờ cập nhật...";
                        lblServer.ForeColor = Color.Blue;
                    }));
                }
                catch (Exception ex)
                {
                    this.Invoke((Action)(() =>
                    {
                        lblServer.Text = $"❌ Lỗi: {ex.Message}";
                        lblServer.ForeColor = Color.Red;
                        MessageBox.Show($"Không thể khởi động server!\n{ex.Message}",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_hubContext == null)
            {
                MessageBox.Show("Server chưa sẵn sàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _isRunning = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            lblServer.Text = "▶️ Đang cập nhật dữ liệu...";
            lblServer.ForeColor = Color.Green;

            _progressTimer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _isRunning = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            _progressTimer.Stop();

            lblServer.Text = "⏸️ Đã dừng cập nhật dữ liệu";
            lblServer.ForeColor = Color.Red;
        }

        private async void ProgressTimer_Tick(object sender, EventArgs e)
        {
            _progressCount++;
            pbTimer.Value = _progressCount;

            // Hiển thị thời gian còn lại
            int remaining = _intervalSeconds - _progressCount;
            lblUpdate.Text = $"Gửi sau: {remaining} giây";

            // Khi đếm đủ 5 giây -> GỬI DATA
            if (_progressCount >= _intervalSeconds)
            {
                await SendWeatherData();

                // Reset để đếm lại từ đầu
                _progressCount = 0;
                pbTimer.Value = 0;
                lblUpdate.Text = $"Gửi sau: {_intervalSeconds} giây";
            }
        }

        private async Task SendWeatherData()
        {
            if (!_isRunning || _hubContext == null) return;

            try
            {
                Random rnd = new Random();
                _temp = rnd.Next(5, 40);
                _wind = rnd.Next(0, 20);
                DateTime updatedAt = DateTime.Now;
                string status = "";

                // Xác định tình trạng
                if (_temp >= 35)
                {
                    status = "☀ Nắng nóng";
                }
                else if (_temp <= 10)
                {
                    status = "❄ Lạnh";
                }
                else
                {
                    status = "🌤️ Mát mẻ";
                }

                // Cập nhật UI
                this.Invoke((Action)(() =>
                {
                    lblTemp.Text = $"🌡️ Nhiệt độ: {_temp}°C";
                    lblWind.Text = $"💨 Gió: {_wind} km/h";
                    lblStatus.Text = $"☁️ Thời tiết: {status}";

                    if (_temp > 35)
                        lblStatus.ForeColor = Color.Red;
                    else if (_temp < 10)
                        lblStatus.ForeColor = Color.Blue;
                    else
                        lblStatus.ForeColor = Color.Green;

                    lblTime.Text = $"🕐 Cập nhật lúc: {updatedAt:dd/MM/yyyy - HH:mm:ss}";
                }));

                // Gửi đến tất cả User - dùng dynamic
                dynamic clients = _hubContext.Clients.All;
                clients.receiveWeatherData(new
                {
                    City = _city,
                    Temp = _temp,
                    Wind = _wind,
                    Status = status,
                    UpdatedAt = updatedAt
                });

                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                this.Invoke((Action)(() =>
                {
                    lblServer.Text = $"❌ Lỗi gửi: {ex.Message}";
                    lblServer.ForeColor = Color.Red;
                }));
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _progressTimer?.Stop();
            _progressTimer?.Dispose();

            if (_signalRServer != null)
            {
                try
                {
                    _signalRServer.Dispose();
                }
                catch { }
            }

            base.OnFormClosing(e);
        }
    }
}