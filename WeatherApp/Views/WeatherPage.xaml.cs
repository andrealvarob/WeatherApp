using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {

        string APIKey = "13d83c0f97f49c982e9c146d568a0acc";
        public WeatherPage()
        {
            InitializeComponent();
        }

        private void Button_Search(object sender, EventArgs e) 
        {
            labcondition.Text = "Condição clímatica: ";
            labtemp.Text = "Temperatura: ";
            labmax.Text = "Máxima: ";
            labmin.Text = "Mínima: ";
            labsunrise.Text = "Nascer do sol: ";
            labsunset.Text = "Pôr do sol: ";
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
               string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&lang=pt_br&units=metric", lugar.Text, APIKey);
               var json = web.DownloadString(url);

               Models.WeatherData Info = JsonConvert.DeserializeObject<Models.WeatherData>(json);

               picIcon.Source = "https://openweathermap.org/img/w/"+Info.weather[0].icon+".png";

               labcondition.Text += Info.weather[0].description;
               labtemp.Text += Info.main.temp.ToString() + "ºC";
               labmax.Text += Info.main.temp_max.ToString() + "ºC";
               labmin.Text += Info.main.temp_min.ToString() + "ºC";
               labsunrise.Text += convertTime(Info.sys.sunrise).ToString();
               labsunset.Text += convertTime(Info.sys.sunset).ToString();
            }
        }

        DateTime convertTime(long milsec)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            dt = dt.AddSeconds(milsec).ToLocalTime();

            return dt;
        }
    }
}