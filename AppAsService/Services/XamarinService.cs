using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AppAsService.Services
{
    [Service]
    public class XamarinService : IntentService
    {
        //private bool isRunning;
        //private Context context;

        //public override IBinder OnBind(Intent intent)
        //{
        //    return null;
        //}

        //public override void OnCreate()
        //{
        //    this.context = this;
        //    this.isRunning = false;

        //}

        //public override void OnDestroy()
        //{
        //    isRunning = false;
        //}

        //public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        //{
        //    if (!isRunning)
        //    {
        //        isRunning = true;

        //    }

        //    return StartCommandResult.Sticky;
        //}

        protected override void OnHandleIntent(Intent intent)
        {
            Log.Info("SERVICE!", "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!11 STARTING");
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Thread.Sleep(30000);
                    Log.Info("SERVICE!", "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!11 IS RUNNING");
                }
                
            });
            
            // some startup task
            
        }
    }
}