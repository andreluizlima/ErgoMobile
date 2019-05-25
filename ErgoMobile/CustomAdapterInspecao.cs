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
using Java.Lang;

namespace ErgoMobile
{
    class CustomAdapterInspecao : BaseAdapter
    {
        private Activity activity;
        private List<Inspecao> lista;
        public CustomAdapterInspecao(Activity activity, List<Inspecao> lista)
        {
            this.activity = activity;
            this.lista = lista;
        }
        public override int Count
        {
            get
            {
                return lista.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return lista[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.InspecaoLista_Layout, parent, false);
            var Nome = view.FindViewById<TextView>(Resource.Id.NomeInspecao);
            var App = view.FindViewById<TextView>(Resource.Id.Aplicacao);
            var Res = view.FindViewById<TextView>(Resource.Id.Responsavel);
            Nome.Text = lista[position].nome;
            App.Text = lista[position].aplicacao;
            Res.Text = lista[position].responsavel;

            return view;
        }
    }
}