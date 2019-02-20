using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            User user = new User(Entry_Password.Text,Entry_Username.Text);
            if (user.validate())
            {
                await DisplayAlert("Login", "Login Success", "Ok");
                await Navigation.PushAsync(new TabbedPage1());
            }
            else
            {
                await DisplayAlert("Login", "Login Failed", "Ok");
            }
        }
    }
}