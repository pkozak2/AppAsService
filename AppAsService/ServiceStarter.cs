using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppAsService.Services;

namespace AppAsService
{
    [BroadcastReceiver]
    [IntentFilter(new[] { Intent.ActionBootCompleted })]
    public class ServiceStarter : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Toast.MakeText(context, "Service is starting!", ToastLength.Long).Show();
            var serviceIntent = new Intent(context, typeof(XamarinService));
            context.StartService(serviceIntent);
        }
    }
}