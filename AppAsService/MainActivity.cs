using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using AppAsService.Services;

namespace AppAsService
{
    [Activity(Label = "AppAsService", MainLauncher = true, Theme = "@android:style/Theme.NoDisplay")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);

            //Button button = FindViewById<Button>(Resource.Id.button1);

            //button.Click += delegate
            //{
            //    Toast.MakeText(this, "Service is starting!", ToastLength.Long).Show();
            //    var serviceIntent = new Intent(this, typeof(XamarinService));
            //    StartService(serviceIntent);

            //};
        }
    }
}

