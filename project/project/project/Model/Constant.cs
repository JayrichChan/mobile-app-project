using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace project.Model
{
    public class Constant
    {
        public static bool isDev = true;

        public static Color BackgroundColor = Color.FromRgb(50, 153, 215);
        public static Color MainTextColor = Color.White;

        public static int LoginIconHeight = 120;

        // ---------------------- Login ------------------------------
        public static string LoginUrl = "https://test.com/api/Auth/Login";

        public static string NoInternetText = "No internet, please reconnect.";

        public static string SettingsScreenTitle = "Settings";
      

    }
}
