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
using ErgoMobile.classes;
namespace ErgoMobile
{
    [Activity(Label = "Criar inspeção")]
    public class NovaInspecaoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.NovaInspecao);
            EditText t = FindViewById<EditText>(Resource.Id.name);
            EditText a = FindViewById<EditText>(Resource.Id.app1);
            EditText f = FindViewById<EditText>(Resource.Id.func1);
            Button b = FindViewById<Button>(Resource.Id.cadastrar);
            string lang = "pt";


            if (Intent.GetStringExtra("Lang") != null)
            {
                lang = Intent.GetStringExtra("Lang");
                if (lang == "en")
                {
                    TextView nome = FindViewById<TextView>(Resource.Id.textNome);
                    TextView app = FindViewById<TextView>(Resource.Id.textApp);
                    TextView funcionalidade = FindViewById<TextView>(Resource.Id.textFuncionalidade);
                    this.Title = "Create Inspection";
                    b.Text = "Create Inspection";
                    nome.Text = "Name:";
                    app.Text = "Application:";
                    funcionalidade.Text = "Functionality:";
                }
            }

            b.Click += delegate
            {
                string nome, app, funcionalidade;
                nome = t.Text;
                app = a.Text;
                funcionalidade = f.Text;
                Data d = new Data();
                d.Novo(nome, app, funcionalidade);
                Console.WriteLine("\n\n"+nome+" "+app+ " " + funcionalidade+"\n\n");
                Intent i = new Intent(this, typeof(ChecklistActivity));
                i.PutExtra("Nome", t.Text);
                i.PutExtra("Lang", lang);
                StartActivity(i);
            };
        }
    }
}