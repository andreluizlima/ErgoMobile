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
    public class ViewHolder : Java.Lang.Object
    {
        public TextView Name { get; set; }
        public TextView Info { get; set; }
    }
    class CustomAdapterChecklist : BaseAdapter
    {
        private Activity activity;
        private List<ItemLista> lista;
        public CustomAdapterChecklist(Activity activity,  List<ItemLista> lista)
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
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.ListStyle, parent, false);
            var Nome = view.FindViewById<TextView>(Resource.Id.lado1);
            var Info = view.FindViewById<TextView>(Resource.Id.lado2);
            Nome.Text = lista[position].nome;
            Info.Text = lista[position].info;
            return view;
        }
    }
}