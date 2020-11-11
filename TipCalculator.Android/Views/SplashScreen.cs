using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Core;
using Android.Content.PM;

namespace TipCalculator.Android
{
    [Activity(
    Label = "@string/app_name",
    MainLauncher = true,
    Icon = "@drawable/icon",
    Theme = "@style/Theme.Splash",
    NoHistory = true,
    ScreenOrientation = ScreenOrientation.Portrait)]

    public class SplashScreen : MvxSplashScreenActivity<MvxAndroidSetup<Core.App>, Core.App>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}