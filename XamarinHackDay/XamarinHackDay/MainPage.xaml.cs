using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinHackDay
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected void ButtonClicked(object sender, EventArgs e)
        {
            var url = $"http://exrin.net/tesla/";

            var entry = new AppLinkEntry
            {
                Title = "Tesla",
                Description = "Electric Cars",
                AppLinkUri = new Uri(url, UriKind.RelativeOrAbsolute),
                IsLinkActive = true
            };

            if (Device.OS == TargetPlatform.iOS)
                entry.Thumbnail = ImageSource.FromFile("logo.png");

            entry.KeyValues.Add("contentType", "Tesla");
            entry.KeyValues.Add("appName", "Tesla");
            entry.KeyValues.Add("companyName", "Tesla");

            Application.Current.AppLinks.RegisterLink(entry);
        }
    }
}
