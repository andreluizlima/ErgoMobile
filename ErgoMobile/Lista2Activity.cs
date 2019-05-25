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

namespace ErgoMobile
{
    [Activity(Label = "Lista2Activity")]
    public partial class Lista2Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.lista2);
            string[] nomes = new String[] { "Presteza", "Agrupamento por localização", "Agrupamento por formato", "Feedback", "Legibilidade", "Concisão", "Ações Mínimas", "Densidade Informacional", "Ações Explícitas", "Controle de Usuário", "Flexibilidade", "Experiencia de Usuário", "Proteção contra erros", "Mensagens de erro", "Correção de erros", "Consistência", "Significados", "Compatibilidade" };
            ListView l = FindViewById<ListView>(Resource.Id.list1);
            
            var lista = new List<ItemLista>();
            for(int i = 0; i < 18; i++)
            {
                Random r = new Random();
                lista.Add(new ItemLista
                {
                    nome = nomes[i],
                    info = +i +"/"+ r.Next(11, 17)               
                    
                });
            }

            var adapter = new CustomAdapterChecklist(this, lista);
            l.Adapter = adapter;
            
        }
    }
}