using Microsoft.AspNet.SignalR;

namespace FormBai5
{
    // SignalR Hub
    public class WeatherHub : Hub
    {
        public void SendWeatherData(object data)
        {
            Clients.All.receiveWeatherData(data);
        }
    }
}
