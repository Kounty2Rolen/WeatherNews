using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading;
using System.Windows.Forms;

namespace WeatherNews.Control
{
    class API
    {
        private Response response;
        private ipgeo ipinfo;
        private double lat;//Широта
        private double lon;//Долгота

        public double Lon { get => lon; set => lon = value; }
        public double Lat { get => lat; set => lat = value; }
        internal Response Response { get => response; set => response = value; }
        internal ipgeo Ipinfo { get => ipinfo; set => ipinfo = value; }

        public API()
        {
                ip2geo();
        }
        public void ip2geo()
        {
            HttpClient ip2geoclient = new HttpClient();
            ip2geoclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage httpResponse =  ip2geoclient.GetAsync(@"http://api.ipgeolocation.io/ipgeo?apiKey=0f4d7e26c3d541b4b6f535d8f61ee705").Result;
            if (httpResponse.IsSuccessStatusCode)
            {
                Ipinfo = JsonConvert.DeserializeObject<ipgeo>(httpResponse.Content.ReadAsStringAsync().Result);
                Lat = Ipinfo.latitude;
                Lon = Ipinfo.longitude;
            }
            else
            {
                MessageBox.Show("Отсуствует интернет подключение!\n");
            }

            ip2geoclient.Dispose();
            httpResponse.Dispose();

        }
        public void getWeatherByCoards()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Yandex-API-Key", "d125946b-7757-45bb-ab0c-f4ec55deb9c5");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var a=Lat.ToString();
            HttpResponseMessage httpResponse = client.GetAsync($"http://api.weather.yandex.ru/v1/forecast?lat={Lat.ToString().Replace(',','.')}&lon={Lon.ToString().Replace(',', '.')}").Result;
            if (httpResponse.IsSuccessStatusCode)
            {
                Response = JsonConvert.DeserializeObject<Response>(httpResponse.Content.ReadAsStringAsync().Result);
            }
            httpResponse.Dispose();

        }

    }
}