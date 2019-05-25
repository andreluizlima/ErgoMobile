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
    [Activity(Label = "Inspeções")]
    public class InspecoesActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.listainspecao);
            //string[] nomes = new String[] { "Inspeção Facebook", "Inspeção WhatsApp", "Inspeção Sistema", "Aplicação Web", "Teste de Inspeção"};
            var lista = new List<Inspecao>();
            Data d = new Data();

            string lang = "pt";
            if (Intent.GetStringExtra("Lang") != null)
            {
                lang = Intent.GetStringExtra("Lang");
                if (lang == "en")
                {
                    Button voltarm = FindViewById<Button>(Resource.Id.voltarmenu);
                    this.Title = "Inspections";
                    voltarm.Text = "Return";                    
                }
            }

            //ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.ListStyle2, nomes);
            lista = d.getInsp();
            ListView list = FindViewById<ListView>(Resource.Id.list2);
            Button b = FindViewById<Button>(Resource.Id.voltarmenu);
            b.Click += delegate
            {
                Intent i = new Intent(this, typeof(MainActivity));
                i.PutExtra("Lang", lang);
                StartActivity(i);
            };
            var adapter = new CustomAdapterInspecao(this, lista);
            list.Adapter = adapter;
            list.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                String titulo = (args.View.FindViewById<TextView>(Resource.Id.NomeInspecao).Text);
                Intent i = new Intent(this, typeof(ChecklistActivity));
                i.PutExtra("Nome", titulo);
                i.PutExtra("Lang", lang);
                StartActivity(i);
            };
        }
    }
}