using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using project.Views.Menu;
using System.Reflection;

namespace project.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent();
            Init();
		}

        void Init()
        {
            BackgroundColor = Constant.BackgroundColor;
            lbl_Username.TextColor = Constant.MainTextColor;
            lbl_Password.TextColor = Constant.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constant.LoginIconHeight;
            App.StartCheckIfInternet(lbl_NoInternet, this);


            usernameEntry.Completed += (s, e) => passwordEntry.Focus();
            passwordEntry.Completed += (s, e) => Btn_Login_Clicked(s, e);     
        }

        async void Btn_Login_Clicked(object sender, EventArgs e)
        {
            Users user = new Users(usernameEntry.Text, passwordEntry.Text);
            if (user.CheckInput())
            {
                ActivitySpinner.IsVisible = true;
                var result = new Token();
                await DisplayAlert("Login", "Login Success", "Okay");

                if(App.SettingsDatabase.GetSettings() == null)
                {
                    Settings settings = new Model.Settings();
                    App.SettingsDatabase.SaveSettings(settings);
                }

                
                if (result != null)
                {
                    ActivitySpinner.IsVisible = false;
                    //App.UserDatabase.SaveUser(user);
                    //App.TokenDatabase.SaveToken(result);
                    if (Device.RuntimePlatform == Device.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new MasterDetail());
                    }
                    else if(Device.RuntimePlatform == Device.iOS)
                    {
                        await Navigation.PushModalAsync(new MasterDetail());
                    }
                }
            }
            else
            {               
                await DisplayAlert("Login", "Username or password is incorrect.", "Okay");
                ActivitySpinner.IsVisible = false;
            }

        }

    }
}