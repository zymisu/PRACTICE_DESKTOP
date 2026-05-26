using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBai5
{
    public partial class FormForecast : Form
    {
        private readonly string iconFolder = @"D:\Pictures\";

        public FormForecast()
        {
            InitializeComponent();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await UpdateWeatherAsync();
        }

        private async Task UpdateWeatherAsync()
        {
            await FadeIn();

            try
            {
                double latitude = 0, longitude = 0;

                string cityName = cboCity.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(cityName))
                {
                    MessageBox.Show("Vui lòng chọn tỉnh/thành hoặc nhập tọa độ!");
                    return;
                }

                switch (cityName)
                {
                    case "HCM":
                        latitude = 10.8231;
                        longitude = 106.6297;
                        break;

                    case "Hà Nội":
                        latitude = 21.028;
                        longitude = 105.834;
                        break;

                    case "Đà Nẵng":
                        latitude = 16.0544;
                        longitude = 108.2022;
                        break;

                    case "Khác":
                        if (!double.TryParse(txtLatitude.Text.Trim(), out latitude) ||
                            !double.TryParse(txtLongitude.Text.Trim(), out longitude))
                        {
                            MessageBox.Show("Vui lòng nhập tọa độ hợp lệ!");
                            return;
                        }
                        break;
                }

                if (latitude < -90 || latitude > 90)
                {
                    MessageBox.Show("Vĩ độ phải nằm trong khoảng -90 đến 90!");
                    return;
                }

                if (longitude < -180 || longitude > 180)
                {
                    MessageBox.Show("Kinh độ phải nằm trong khoảng -180 đến 180!");
                    return;
                }

                // Dùng InvariantCulture để đảm bảo dấu chấm thập phân
                string lat = latitude.ToString(CultureInfo.InvariantCulture);
                string lon = longitude.ToString(CultureInfo.InvariantCulture);

                string url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current_weather=true&timezone=Asia/Ho_Chi_Minh";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage res = await client.GetAsync(url);
                    string result = await res.Content.ReadAsStringAsync();

                    if (!res.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Lỗi truy cập API: {res.StatusCode}\n{result}");
                        return;
                    }

                    dynamic data = JsonConvert.DeserializeObject(result);
                    if (data?.current_weather == null)
                    {
                        MessageBox.Show("Không nhận được dữ liệu thời tiết hợp lệ.");
                        return;
                    }

                    double temp = data.current_weather.temperature;
                    double wind = data.current_weather.windspeed;
                    int weatherCode = data.current_weather.weathercode;
                    string time = data.current_weather.time;

                    lblTemp.Text = $"Nhiệt độ: {temp}°C";
                    lblWind.Text = $"Gió: {wind} km/h";
                    lblTime.Text = $"Cập nhật lúc: {time}";

                    string iconFile = "cloudy.png";

                    if (temp >= 35) iconFile = "sunny.png";
                    else if (temp <= 15) iconFile = "cold.png";

                    if (weatherCode >= 51 && weatherCode <= 99) iconFile = "rain.png";
                    if (wind > 40) iconFile = "wind.png";

                    string iconPath = iconFolder + iconFile;

                    if (File.Exists(iconPath))
                    {
                        if (pbIcon.Image != null)
                            pbIcon.Image.Dispose();

                        pbIcon.Image = Image.FromFile(iconPath);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy icon: " + iconPath);
                        pbIcon.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCity.SelectedItem != null &&
                cboCity.SelectedItem.ToString() == "Khác")
            {
                groupBox1.Enabled = true;   // Cho nhập
            }
            else
            {
                groupBox1.Enabled = false;  // Khóa lại
            }
        }

        private async Task FadeIn()
        {
            pbIcon.Visible = false;
            lblTemp.Visible = false;
            lblWind.Visible = false;
            lblTime.Visible = false;

            await Task.Delay(0); pbIcon.Visible = true;
            await Task.Delay(0); lblTemp.Visible = true;
            await Task.Delay(0); lblWind.Visible = true;
            await Task.Delay(0); lblTime.Visible = true;
        }
    }
}