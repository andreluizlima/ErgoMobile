using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace ErgoMobile
{
    [Activity(Label = "ErgoMobile", MainLauncher = true)]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            string lang = "pt";
            Button b = FindViewById<Button>(Resource.Id.novains);
            Button b2 = FindViewById<Button>(Resource.Id.inspecoes);
            Button b3 = FindViewById<Button>(Resource.Id.ajuda);
            if (Intent.GetStringExtra("Lang") != null)
            {
                lang = Intent.GetStringExtra("Lang");
                if (lang == "en")
                {
                    b2.Text = "INSPECTIONS";
                    b.Text = "NEW INSPECTION";
                    b3.Text = "HELP";
                }
            }
            

            Button pt = FindViewById<Button>(Resource.Id.pt);
            Button en = FindViewById<Button>(Resource.Id.en);

            b.Click += delegate
            {
                Intent i = new Intent(this, typeof(NovaInspecaoActivity));
                i.PutExtra("Lang", lang);
                StartActivity(i);
                //StartActivity(typeof(NovaInspecaoActivity));
            };
            
            b2.Click += delegate
            {
                //StartActivity(typeof(InspecoesActivity));
                Intent i = new Intent(this, typeof(InspecoesActivity));
                i.PutExtra("Lang", lang);
                StartActivity(i);
            };
            
            en.Click += delegate
            {
                lang = "en";
                b2.Text = "INSPECTIONS";
                b.Text = "NEW INSPECTION";
                b3.Text = "HELP";
            };
            
            pt.Click += delegate
            {
                lang = "pt";
                b2.Text = "INSPEÇÕES";
                b.Text = "NOVA INSPEÇÃO";
                b3.Text = "AJUDA";
            };
            
            
        }


    }
}

