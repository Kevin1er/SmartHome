using System;

using Android.App;
using Android.Content.PM;
using Android.OS;
using Firebase;

namespace SmartHome.Droid
{
    [Activity(Label = "SmartHome", Icon = "@mipmap/icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            //Firebase loading
            //FirebaseApp.InitializeApp(Application.Context);

            var options = new FirebaseOptions.Builder()
                .SetApplicationId("smarthome-ab3cb")
                .SetApiKey("AIzaSyCi2Ib7FQBkzzha4GQ1G-Y9NnLT2AyG6m4")
                .SetDatabaseUrl("https://console.firebase.google.com/project/smarthome-ab3cb/database/firestore/data~2F")
                .Build();

            FirebaseApp.InitializeApp(this, options, "SmartHome");

            LoadApplication(new App(new DroidModule()));
        }
    }
}