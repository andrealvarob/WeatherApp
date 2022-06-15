using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {

        int count = 0;
        public LoginUI()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            UserData cadastro1 = new UserData("admin", "admin", "andrealvarob@gmail.com");
            UserData cadastro2 = new UserData("andre", "123", "andrealvarob@gmail.com");
            UserData cadastro3 = new UserData("ana", "1234", "andrealvarob@gmail.com");

            if((usertxt.Text == cadastro1.name && passtxt.Text == cadastro1.password) ||
                (usertxt.Text == cadastro2.name && passtxt.Text == cadastro2.password) ||
                (usertxt.Text == cadastro3.name && passtxt.Text == cadastro3.password))
            {
                Navigation.PushAsync(new WeatherPage());
                usertxt.Text = "";
                passtxt.Text = "";
            }
            else
            {

                if (count >= 3)
                {
                    DisplayAlert("Ops...", "Mais de três tentativas, cheque seu email!", "Ok");
                    usertxt.Text = "";
                    passtxt.Text = "";
                }
                else
                {
                    count += 1;
                    DisplayAlert("Ops...", "Senha ou usuário incorreto!", "Ok");
                }
            }
        }

    }
}