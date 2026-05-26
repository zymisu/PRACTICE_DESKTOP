using Microsoft.AspNet.SignalR.Client;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace FormBai5
{
    public partial class FormUser : Form
    {
        private HubConnection _connection;
        private IHubProxy _hubProxy;

        private string _city = "Hà Nội";
        private double _temp = 38;
        private double _wind = 0;
        private string _status = "Đang chờ...";
        private DateTime _updatedAt = DateTime.Now;

        // Timer cho hiệu ứng nhấp nháy
        private System.Windows.Forms.Timer _blinkTimer;
        private bool _isBlinking = false;
        private int _blinkCount = 0;
        private Color _originalColor;

        // Âm thanh
        private SoundPlayer _notificationSound;

        public FormUser()
        {
            InitializeComponent();
            InitializeUI();
            InitializeEffects();
            ConnectToSignalR();
        }

        private void InitializeUI()
        {
            lblCity.Text = $"📍 Địa điểm: {_city}";
            lblTemp.Text = $"🌡️ Nhiệt độ: 38°C";
            lblWind.Text = $"💨 Gió:   Đang chờ...";
            lblStatus.Text = $"☁️ Thời tiết:   Đang chờ...";
            lblTime.Text = $"🕐 Cập nhật lúc:   Đang chờ...";
            lblConnection.Text = "⏳ Chờ Admin khởi động...";
            lblConnection.ForeColor = Color.Orange;

            // Ẩn label warning ban đầu
            if (this.Controls.ContainsKey("lblWarning"))
            {
                this.Controls["lblWarning"].Visible = false;
            }

            this.BackColor = Color.White;
        }

        private void InitializeEffects()
        {
            // Timer cho hiệu ứng nhấp nháy
            _blinkTimer = new System.Windows.Forms.Timer();
            _blinkTimer.Interval = 300; // Nhấp nháy mỗi 300ms
            _blinkTimer.Tick += BlinkTimer_Tick;

            // Không cần tải âm thanh trước, dùng SystemSounds trực tiếp
            _notificationSound = null;
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            if (_blinkCount >= 6) // Nhấp nháy 3 lần (6 lần đổi màu)
            {
                _blinkTimer.Stop();
                _isBlinking = false;
                _blinkCount = 0;
                this.BackColor = Color.White;
                return;
            }

            // Hiệu ứng nhấp nháy background
            if (this.BackColor == Color.White)
            {
                this.BackColor = _originalColor == Color.Red ? Color.FromArgb(255, 220, 220) : Color.FromArgb(220, 220, 255);
            }
            else
            {
                this.BackColor = Color.White;
            }

            _blinkCount++;
        }

        private async void ConnectToSignalR()
        {
            try
            {
                // Kết nối tới server
                _connection = new HubConnection("http://localhost:5000");
                _hubProxy = _connection.CreateHubProxy("WeatherHub");

                // Đăng ký nhận dữ liệu
                _hubProxy.On<dynamic>("receiveWeatherData", (data) =>
                {
                    this.Invoke((Action)(() =>
                    {
                        UpdateWeatherData(data);
                    }));
                });

                // Xử lý khi kết nối lại
                _connection.Reconnected += Connection_Reconnected;

                // Xử lý khi mất kết nối
                _connection.Closed += Connection_Closed;

                // Bắt đầu kết nối
                await _connection.Start();

                this.Invoke((Action)(() =>
                {
                    lblConnection.Text = "✅ Đã kết nối thành công!";
                    lblConnection.ForeColor = Color.Green;
                }));
            }
            catch (Exception ex)
            {
                this.Invoke((Action)(() =>
                {
                    lblConnection.Text = $"❌ Lỗi: {ex.Message}";
                    lblConnection.ForeColor = Color.Red;
                    MessageBox.Show($"Không thể kết nối tới server!\n\nVui lòng:\n1. Bật Form Admin trước\n2. Nhấn nút 'Bắt đầu' ở Admin\n\nLỗi: {ex.Message}",
                        "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }

        private void Connection_Reconnected()
        {
            this.Invoke((Action)(() =>
            {
                lblConnection.Text = "✅ Đã kết nối lại!";
                lblConnection.ForeColor = Color.Green;
            }));
        }

        private void Connection_Closed()
        {
            this.Invoke((Action)(() =>
            {
                lblConnection.Text = "❌ Mất kết nối!";
                lblConnection.ForeColor = Color.Red;
                lblStatus.Text = "☁️ Tình trạng: Mất kết nối";
                lblStatus.ForeColor = Color.Red;
            }));
        }

        private void UpdateWeatherData(dynamic data)
        {
            try
            {
                double oldTemp = _temp;

                _city = data.City?.ToString() ?? "Hà Nội";
                _temp = Convert.ToDouble(data.Temp);
                _wind = Convert.ToDouble(data.Wind);
                _status = data.Status?.ToString() ?? "Không rõ";
                _updatedAt = Convert.ToDateTime(data.UpdatedAt);

                // Cập nhật UI cơ bản
                lblCity.Text = $"📍 Địa điểm: {_city}";
                lblTemp.Text = $"🌡️ Nhiệt độ: {_temp}°C";
                lblWind.Text = $"💨 Gió: {_wind} km/h";
                lblStatus.Text = $"☁️ Thời tiết: {_status}";
                lblTime.Text = $"🕐 Cập nhật lúc: {_updatedAt:dd/MM/yyyy - HH:mm:ss}";

                // Reset màu mặc định
                lblTemp.ForeColor = Color.Black;
                lblStatus.ForeColor = Color.Black;

                // Kiểm tra và hiển thị cảnh báo
                Label lblWarning = null;
                if (this.Controls.ContainsKey("lblWarning"))
                {
                    lblWarning = (Label)this.Controls["lblWarning"];
                }

                bool isWarning = false;

                if (_temp > 35)
                {
                    // CẢNH BÁO NẮNG NÓNG
                    isWarning = true;
                    if (lblWarning != null)
                    {
                        lblWarning.Text = "⚠️ CẢNH BÁO: 🔥 NHIỆT ĐỘ NẮNG NÓNG!";
                        lblWarning.BackColor = Color.Red;
                        lblWarning.ForeColor = Color.White;
                        lblWarning.Font = new Font(lblWarning.Font.FontFamily, 10, FontStyle.Bold);
                        lblWarning.Padding = new Padding(6, 4, 6, 4);
                        lblWarning.BorderStyle = BorderStyle.FixedSingle;
                        lblWarning.Visible = true;
                    }
                }
                else if (_temp < 10)
                {
                    // CẢNH BÁO LẠNH
                    isWarning = true;
                    if (lblWarning != null)
                    {
                        lblWarning.Text = "⚠️ CẢNH BÁO: ❄️ NHIỆT ĐỘ XUỐNG THẤP!";
                        lblWarning.BackColor = Color.LightCyan;
                        lblWarning.ForeColor = Color.Black;
                        lblWarning.Font = new Font(lblWarning.Font.FontFamily,10 , FontStyle.Regular);
                        lblWarning.Padding = new Padding(6, 4, 6, 4);
                        lblWarning.BorderStyle = BorderStyle.FixedSingle;
                        lblWarning.Visible = true;
                    }
                }
                else
                {
                    // Không có cảnh báo - ẩn label warning
                    if (lblWarning != null)
                    {
                        lblWarning.Visible = false;
                    }
                }

                // Kích hoạt hiệu ứng nếu có cảnh báo
                if (isWarning && !_isBlinking)
                {
                    _originalColor = _temp > 35 ? Color.Red : Color.Blue;
                    _isBlinking = true;
                    _blinkCount = 0;
                   

                    // Phát âm thanh
                    PlayNotificationSound();
                }
                else if (!isWarning)
                {
                    this.BackColor = Color.White;
                }

                lblConnection.Text = "✅ Đang nhận dữ liệu...";
                lblConnection.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblConnection.Text = $"⚠️ Lỗi xử lý: {ex.Message}";
                lblConnection.ForeColor = Color.Orange;
            }
        }

        private void PlayNotificationSound()
        {
            try
            {
                // Phát âm thanh Windows mặc định
                SystemSounds.Exclamation.Play();
            }
            catch
            {
                // Nếu không phát được âm thanh thì bỏ qua
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _blinkTimer?.Stop();
            _blinkTimer?.Dispose();
            _notificationSound?.Dispose();

            if (_connection != null)
            {
                try
                {
                    _connection.Stop();
                    _connection.Dispose();
                }
                catch { }
            }

            base.OnFormClosing(e);
        }
    }
}