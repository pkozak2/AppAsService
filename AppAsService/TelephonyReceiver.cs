using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Telephony;
using Android.Views;
using Android.Widget;

namespace AppAsService
{
    [BroadcastReceiver]
    [IntentFilter(new[] { "android.intent.action.PHONE_STATE" })]
    public class TelephonyReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            string state = intent.GetStringExtra(TelephonyManager.ExtraState);
            if (state.Equals(TelephonyManager.ExtraStateRinging))
            {
                String incomingNumber = intent.GetStringExtra(TelephonyManager.ExtraIncomingNumber);
                Toast.MakeText(context, "Ringing State Number is -" + incomingNumber, ToastLength.Short).Show();
            }
            if ((state.Equals(TelephonyManager.ExtraStateOffhook)))
            {
                Toast.MakeText(context, "Received State", ToastLength.Short).Show();
            }
            if (state.Equals(TelephonyManager.ExtraStateIdle))
            {
                Toast.MakeText(context, "Idle State", ToastLength.Short).Show();
            }
        }
    }
}