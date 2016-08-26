using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.App;

namespace MenuDrawerLayout
{
    [Activity(Label = "MenuDrawerLayout", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {

        private SupportToolbar mtoolbar;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mtoolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            SetSupportActionBar(mtoolbar);
            SupportActionBar.Title = "Hamburger";
            
        }
    }
}

