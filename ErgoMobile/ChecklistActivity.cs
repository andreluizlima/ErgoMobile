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
    [Activity(Label = "Nova Inspeção")]
    public class ChecklistActivity : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.lista2);
            String inspecao="";
            Respostas respostas = new Respostas();
            ControlesJSON cjson = new ControlesJSON();
            
            Data data = new Data();
            ///////////
            string[] nomes = new String[] { "Presteza", "Agrupamento por localização", "Agrupamento por formato", "Feedback", "Legibilidade", "Concisão", "Ações Mínimas", "Densidade Informacional", "Ações Explícitas", "Controle de Usuário", "Flexibilidade", "Experiencia de Usuário", "Proteção contra erros", "Mensagens de erro", "Correção de erros", "Consistência", "Significados", "Compatibilidade" };
            string lang = "pt";
            if (Intent.GetStringExtra("Lang") != null)
            {
                lang = Intent.GetStringExtra("Lang");
                if (lang == "en")
                {
                    Button voltar = FindViewById<Button>(Resource.Id.voltarr);
                    Button results = FindViewById<Button>(Resource.Id.resultados);
                    voltar.Text = "Return";
                    results.Text = "Results";
                    nomes = new string[] { "Spotting", "Grouping by location", "Grouping by format", "Feedback", "Readability", "Conciseness", "Minimal Actions", "Informational Density", "Explicit Actions", "User Control", "Flexibility", "User Experience", "Error Protection", "Error Messages", "Error Correction", "Consistency", "Meanings", "Compatibility"};
                }
            }
            //////////////
            if (Intent.GetStringExtra("Nome") != null)
            {
                string valor = Intent.GetStringExtra("Nome");
                this.Title = valor;
                inspecao = valor;
                
            }
            respostas = data.Abrir(inspecao);
            if (Intent.GetStringArrayExtra("Dados") != null)
            {
                String[] dados = Intent.GetStringArrayExtra("Dados");
                String categoria = Intent.GetStringExtra("Categoria");
                respostas = data.Salvar(respostas, dados, categoria, inspecao);
            }
      ////////////
            
            
            ListView l = FindViewById<ListView>(Resource.Id.list1);
            Button b = FindViewById<Button>(Resource.Id.voltarr);
            b.Click += delegate
              {
                  Intent i = new Intent(this, typeof(MainActivity));
                  i.PutExtra("Lang", lang);
                  StartActivity(i);
              };

            Button resultados = FindViewById<Button>(Resource.Id.resultados);
            resultados.Click += delegate
            {
                string text = "Gerando resultados!\n     Aguarde...";
                if (lang == "en") text = "Generating results!\n   Please wait...";
                Toast.MakeText(Application.Context, text, ToastLength.Short).Show();
                
                message(lang, inspecao);
          
            };

            var lista = new List<ItemLista>();
            for (int i = 0; i < 18; i++)
            {
                if (i < respostas.Lista.Count)
                {
                    //area válida
                    int respondido = -1;
                    for (int j = 0; j < respostas.Lista.ElementAt(i).Length; j++)
                    {
                        if (respostas.Lista.ElementAt(i)[j] != "-1")
                        {
                            respondido += 1;
                        }
                    }
                    lista.Add(new ItemLista
                    {
                        nome = nomes[i],
                        info = +respondido + "/" + (respostas.Lista.ElementAt(i).Length-1)

                    });
                }
                else
                {
                    //teste
                    lista.Add(new ItemLista
                    {
                        nome = nomes[i],
                        info = +0 + "/" + 10

                    });
                }
                
            }

            var adapter = new CustomAdapterChecklist(this, lista);
            l.Adapter = adapter;
            l.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                String titulo = (args.View.FindViewById<TextView>(Resource.Id.lado1).Text);                
                Intent i = new Intent(this, typeof(QuestionarioActivity));
                i.PutExtra("Nome", inspecao);
                i.PutExtra("Lang", lang);
                i.PutExtra("Label", titulo);
                i.PutExtra("Categoria", nomes);
                string[] dados=null;
                for (int k = 0; k < lista.Count; k++)
                {
                    if (titulo == lista.ElementAt(k).nome) {
                        
                        int n = k;

                        dados = respostas.Lista.ElementAt(n);
                        i.PutExtra("Dados", dados);
                        //Console.WriteLine("\n\n\n\n" + n + "\n\n\n");
                    }
                    
                }

                //Console.WriteLine("\n\n\n"+String.Join(",", dados)+"\n\n\n");
                StartActivity(i);
            };


        }

        private void message(string lang, string inspecao)
        {
            
            Intent i = new Intent(this, typeof(ResultScreenActivity));
            i.PutExtra("Lang", lang);
            i.PutExtra("Nome", inspecao);
            StartActivity(i);
        }

    }
}