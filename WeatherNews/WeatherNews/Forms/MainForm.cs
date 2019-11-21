using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MaterialSkin.Controls;
using MaterialSkin;
using WeatherNews.Control;
using System.Drawing.Imaging;

namespace WeatherNews
{
    public partial class MainForm : MaterialForm
    {
        API api;
        WeatherNews.Control.Response response;
        public MainForm()
        {
            InitializeComponent();
            var SkinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.Light;
            SkinManager.ColorScheme=new ColorScheme(Primary.DeepOrange500,Primary.Brown500,Primary.DeepOrange300,Accent.Red200,TextShade.White);
            LoadForm();
        }
        
        public void LoadForm()
        {
            api = new API();
            api.getWeatherByCoards();
            cityLable.Text = api.Ipinfo.city;
            tempLabel.Text = api.Response.fact.temp.ToString();
            feelLabel.Text = api.Response.fact.feels_like.ToString();
            UriBuilder uri = new UriBuilder($"https://yastatic.net/weather/i/icons/blueye/color/svg/{api.Response.fact.icon}.svg");
            webBrowser.Url = uri.Uri;
            uvIndexLabel.Text = api.Response.fact.uv_index.ToString();
            windSpeedLabel.Text = api.Response.fact.wind_speed.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LoadForm();

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            Forms.About about = new Forms.About();
            about.Show();
        }
    }
}
