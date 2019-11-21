using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNews.Control
{
    class TemperatureInfo
    {
        public float temp { get; set; }
        public float uv_index { get; set; }
        public float wind_speed { get; set; }
        public string icon { get; set; }
        public float feels_like { get; set; }
    }
}
