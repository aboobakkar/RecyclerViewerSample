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

namespace RecyclerViewer
{
    [Activity(Label = "RecyclerViewer", MainLauncher = true, Icon = "@drawable/icon",
               Theme = "@android:style/Theme.Material.Light.DarkActionBar")]
    public class SecondActivity:Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Second);

        }

        }
    }