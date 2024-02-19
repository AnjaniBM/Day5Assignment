using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Day5Assignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(uName.Text == "admin" && pass.Text == "admin")
            { 
              Navigation.PushAsync(new WelcomePage());
            }
            else
            {
                 DisplayAlert("Login Failed", "Please try again", "OK");
            }

        }
    }
}