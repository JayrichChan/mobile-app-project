using project.Model;
using project.Views.DetailViews;
using project.Views.DetailViews.SettingsViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace project.Views.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
        public ListView ListView { get { return listView; } }
        public List<MasterMenuItem> items;

		public MasterPage ()
		{
			InitializeComponent ();
            SetItems();

		}

        void SetItems()
        {
            items = new List<MasterMenuItem>();
            items.Add(new MasterMenuItem("Infoscreen1", "icon.png", Color.White, typeof(InfoScreen1)));
            items.Add(new MasterMenuItem("Infoscreen2", "icon.png", Color.White, typeof(InfoScreen2)));
            items.Add(new MasterMenuItem("Settings", "icon.png", Color.White, typeof(SettingsScreen)));
            ListView.ItemsSource = items;

        }

        /*
        async void Btn_LogOut_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Logging Out", "Log out successfully", "Okay");
            if (Device.RuntimePlatform == Device.Android)
            {
                Application.Current.MainPage = new NavigationPage(new LoginView());
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                await Navigation.PushModalAsync(new LoginView());
            }
        }
        */
    }
}
 