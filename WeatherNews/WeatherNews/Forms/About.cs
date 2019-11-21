using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using MaterialSkin;

namespace WeatherNews.Forms
{
    public partial class About : MaterialForm
    {
        public About()
        {
            InitializeComponent();
            var SkinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.Light;
            SkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange500, Primary.Brown500, Primary.DeepOrange300, Accent.Red200, TextShade.White);
        }
    }
}
