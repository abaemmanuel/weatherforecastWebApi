using Newtonsoft.Json;
using System.Net;
using WeatherForecast.Model;

namespace WeatherForecast.Service
{
    public class WeatherService
    {
        public void GetWeather(string city)
        {
            
            string APIKey = "b5b86906c67357cdeabbfcdbe22f7cac";
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city, APIKey);
                var downloadfile = web.DownloadString(url);
                WeatherDetails.root Info = JsonConvert.DeserializeObject<WeatherDetails.root>(downloadfile);
            }
        }

        DateTime ConvertDateTime(long sec)
        {
            DateTime currTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            var forTime = currTime.AddSeconds(sec).ToLocalTime();
            return forTime;
        }
    }
}
