using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Newtonsoft.Json;
using System.Net;
using static WeatherApp.WeatherInfo;
using System.Security.Policy;

namespace WeatherApp
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                getweatherAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string APIKey = "Your_API_Key";
        double lati;
        double longi ;

        async Task getweatherAsync()
        {
            using (WebClient web = new WebClient())
            {


                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txtcity.Text, APIKey);
                var jsonToday = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(jsonToday);
                lati = Info.coord.lat;
                longi = Info.coord.lon;

                string icon1 = Info.weather[0].icon;                
                lbldesc.Text = Info.weather[0].description;
                lblcloud.Text = Info.weather[0].main;
                lblsunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                lblsunset.Text = convertDateTime(Info.sys.sunset).ToString();
                lblwind.Text = Info.wind.speed.ToString();
                lblpre.Text = Info.main.pressure.ToString();
                lbltemp.Text = Info.main.temp.ToString();
                //picweather.Image = Image.FromFile("../Resources/");
                picweather.Image = Image.FromFile($"E:\\VPprojects\\C#Project\\Assets\\Weather\\{icon1}.png");

                string forcasturl = string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&appid={2}", lati, longi, APIKey);
                var jsonForcast = web.DownloadString(forcasturl);
                WeatherForcast forcast = JsonConvert.DeserializeObject<WeatherForcast>(jsonForcast);

                
                picweather1.Image = Image.FromFile($"E:\\VPprojects\\C#Project\\Assets\\Weather\\{forcast.list[0].weather[0].icon}.png");
                lblcloud1.Text = string.Format("{0}", forcast.list[0].weather[0].main);
                lblwind1.Text = forcast.list[0].wind.speed.ToString();
                lblpre1.Text = forcast.list[0].main.pressure.ToString();
                lbltemp1.Text = forcast.list[0].main.temp.ToString();

                picweather2.Image = Image.FromFile($"E:\\VPprojects\\C#Project\\Assets\\Weather\\{forcast.list[1].weather[0].icon}.png");
                lblcloud2.Text = string.Format("{0}", forcast.list[1].weather[0].main);
                lblwind2.Text = forcast.list[1].wind.speed.ToString();
                lblpre2.Text = forcast.list[1].main.pressure.ToString();
                lbltemp2.Text = forcast.list[1].main.temp.ToString();

                picweather3.Image = Image.FromFile($"E:\\VPprojects\\C#Project\\Assets\\Weather\\{forcast.list[2].weather[0].icon}.png");
                lblcloud3.Text = string.Format("{0}", forcast.list[2].weather[0].main);
                lblwind3.Text = forcast.list[2].wind.speed.ToString();
                lblpre3.Text = forcast.list[2].main.pressure.ToString();
                lbltemp3.Text = forcast.list[2].main.temp.ToString();

                picweather4.Image = Image.FromFile($"E:\\VPprojects\\C#Project\\Assets\\Weather\\{forcast.list[3].weather[0].icon}.png");
                lblcloud4.Text = string.Format("{0}", forcast.list[3].weather[0].main);
                lblwind4.Text = forcast.list[3].wind.speed.ToString();
                lblpre4.Text = forcast.list[3].main.pressure.ToString();
                lbltemp4.Text = forcast.list[3].main.temp.ToString();

                picweather5.Image = Image.FromFile($"E:\\VPprojects\\C#Project\\Assets\\Weather\\{forcast.list[4].weather[0].icon}.png");
                lblcloud5.Text = string.Format("{0}", forcast.list[4].weather[0].main);
                lblwind5.Text = forcast.list[4].wind.speed.ToString();
                lblpre5.Text = forcast.list[4].main.pressure.ToString();
                lbltemp5.Text = forcast.list[4].main.temp.ToString();

                picweather6.Image = Image.FromFile($"E:\\VPprojects\\C#Project\\Assets\\Weather\\{forcast.list[5].weather[0].icon}.png");
                lblcloud6.Text = string.Format("{0}", forcast.list[5].weather[0].main);
                lblwind6.Text = forcast.list[5].wind.speed.ToString();
                lblpre6.Text = forcast.list[5].main.pressure.ToString();
                lbltemp6.Text = forcast.list[5].main.temp.ToString();

                picweather7.Image = Image.FromFile($"E:\\VPprojects\\C#Project\\Assets\\Weather\\{forcast.list[6].weather[0].icon}.png");
                lblcloud7.Text = string.Format("{0}", forcast.list[6].weather[0].main);
                lblwind7.Text = forcast.list[6].wind.speed.ToString();
                lblpre7.Text = forcast.list[6].main.pressure.ToString();
                lbltemp7.Text = forcast.list[6].main.temp.ToString();

            }
        }

        DateTime convertDateTime(long milisec)
        {
            DateTime day =new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc).ToLocalTime();
            day=day.AddMilliseconds(milisec).ToLocalTime();

            return day;
        }
    }
}
