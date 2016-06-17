using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamarinHackDay.Droid
{



    // Make searchable
    [IntentFilter(new[] { Android.Content.Intent.ActionSearch })]

    [MetaData("android.app.searchable", Resource = "@xml/searchable")]

    [IntentFilter(new[] { Android.Content.Intent.ActionSearch })]
    [IntentFilter(new[] { Android.Gms.Actions.SearchIntents.ActionSearch },
        Categories = new[]
        {
            Android.Content.Intent.CategoryDefault
     })]

    [IntentFilter(new[] { Android.Content.Intent.ActionView },
     Categories = new[]
     {
         Android.Content.Intent.CategoryDefault,
         Android.Content.Intent.CategoryBrowsable
     },
     DataScheme = "http",
     DataPathPrefix = "/tesla/",
     DataHost = "exrin.net")]

    [Activity(Label = "XamarinHackDay", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());


            String search = Intent.GetStringExtra(SearchManager.Query);

            search = ""; // do something

        }
    }
}

