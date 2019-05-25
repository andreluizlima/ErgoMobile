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
    [Activity(Label = "QuestionarioActivity")]
    public class QuestionarioActivity : Activity
    {
        Button btnMtoRuim;
        Button btnRuim;
        Button btnRegular;
        Button btnBom;
        Button btnMtoBom;
        Button voltar;
        Button proximo;
        String selected;
        String title;
        String[] respostas;
        String categoria = "";
        Questoes q;
        string lang;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Questionario);
            selected = "-1";
            q = new Questoes("pt");
            List<string> questions = new List<string>();

            ////
            TextView questao = FindViewById<TextView>(Resource.Id.pergunta);

            btnMtoRuim = FindViewById<Button>(Resource.Id.btnMtoRuim);
            btnRuim = FindViewById<Button>(Resource.Id.btnRuim);
            btnRegular = FindViewById<Button>(Resource.Id.btnRegular);
            btnBom = FindViewById<Button>(Resource.Id.btnBom);
            btnMtoBom = FindViewById<Button>(Resource.Id.btnMtoBom);

            voltar = FindViewById<Button>(Resource.Id.voltar);
            proximo = FindViewById<Button>(Resource.Id.proximo);
            ////
            if (Intent.GetStringArrayExtra("Dados") != null)
            {
                respostas = Intent.GetStringArrayExtra("Dados");
            }
            lang = "pt";
            if (Intent.GetStringExtra("Lang") != null)
            {
                lang = Intent.GetStringExtra("Lang");
                if (lang == "en")
                {
                    q = new Questoes("en");
                    TextView atrb = FindViewById<TextView>(Resource.Id.atrbnota);
                    atrb.Text = "Assign an evaluation:";
                    btnMtoRuim.Text = "TOO BAD";
                    btnRuim.Text = "BAD";
                    btnRegular.Text = "REGULAR";
                    btnBom.Text = "GOOD";
                    btnMtoBom.Text = "VERY GOOD";

                    voltar.Text = "Return";
                    proximo.Text = "Next";                    
                }
            }
            string[] nomes= { };
            if (Intent.GetStringArrayExtra("Categoria") != null)
            {
                nomes = Intent.GetStringArrayExtra("Categoria");
            }

            SetButtons(1);


            if (Intent.GetStringExtra("Label") != null)
            {
                TextView item = FindViewById<TextView>(Resource.Id.item);
                string valor = Intent.GetStringExtra("Label");
                string nome = Intent.GetStringExtra("Nome");
                
                this.Title = nome;
                title = nome;
                item.Text = "< "+valor;
                categoria = valor;
                if(valor == nomes[0])
                {
                    questions.Clear();
                    int qtd = q.Presteza.Count;
                    //respostas = new String[qtd];
                    for (int i=0; i<qtd; i++)
                    {
                        //if(respostas[i]==null) respostas[i] = "0";
                        questions.Add(q.Presteza.ElementAt(i));
                    }                    
                }
                else if (valor == nomes[1])
                {
                    questions.Clear();
                    int qtd = q.AgrLocalizacao.Count;
                    //respostas = new String[qtd];
                    for (int i = 0; i < qtd; i++)
                    {
                        //respostas[i] = "0";
                        questions.Add(q.AgrLocalizacao.ElementAt(i));
                    }
                }
                else if (valor == nomes[2])
                {
                    questions.Clear();
                    int qtd = q.AgrFormato.Count;
                    //respostas = new String[qtd];
                    for (int i = 0; i < qtd; i++)
                    {
                        //respostas[i] = "0";
                        questions.Add(q.AgrFormato.ElementAt(i));
                    }
                }
                else if (valor == nomes[3])
                {
                    questions.Clear();
                    int qtd = q.Feedback.Count;
                    //respostas = new String[qtd];
                    for (int i = 0; i < qtd; i++)
                    {
                        //respostas[i] = "0";
                        questions.Add(q.Feedback.ElementAt(i));
                    }
                }
                else if (valor == nomes[4])
                {
                    questions.Clear();
                    int qtd = q.Legibilidade.Count;
                    //respostas = new String[qtd];
                    for (int i = 0; i < qtd; i++)
                    {
                        //respostas[i] = "0";
                        questions.Add(q.Legibilidade.ElementAt(i));
                    }
                }
                else if (valor == nomes[5])
                {
                    questions.Clear();
                    int qtd = q.Concisao.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.Concisao.ElementAt(i));
                    }
                }
                else if (valor == nomes[6])
                {
                    questions.Clear();
                    int qtd = q.AcoesMinimas.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.AcoesMinimas.ElementAt(i));
                    }
                }
                else if (valor == nomes[7])
                {
                    questions.Clear();
                    int qtd = q.DensidadeInformacional.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.DensidadeInformacional.ElementAt(i));
                    }
                }
                else if (valor == nomes[8])
                {
                    questions.Clear();
                    int qtd = q.AcoesExplicitas.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.AcoesExplicitas.ElementAt(i));
                    }
                }
                else if (valor == nomes[9])
                {
                    questions.Clear();
                    int qtd = q.ControleUsuario.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.ControleUsuario.ElementAt(i));
                    }
                }
                else if (valor == nomes[10])
                {
                    questions.Clear();
                    int qtd = q.Flexibilidade.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.Flexibilidade.ElementAt(i));
                    }
                }
                else if (valor == nomes[11])
                {
                    questions.Clear();
                    int qtd = q.ExpUsuario.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.ExpUsuario.ElementAt(i));
                    }
                }
                else if (valor == nomes[12])
                {
                    questions.Clear();
                    int qtd = q.ProtecaoContraErros.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.ProtecaoContraErros.ElementAt(i));
                    }
                }
                else if (valor == nomes[13])
                {
                    questions.Clear();
                    int qtd = q.MsgsErro.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.MsgsErro.ElementAt(i));
                    }
                }
                else if (valor == nomes[14])
                {
                    questions.Clear();
                    int qtd = q.CorrecaoErros.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.CorrecaoErros.ElementAt(i));
                    }
                }
                else if (valor == nomes[15])
                {
                    questions.Clear();
                    int qtd = q.Consistencia.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.Consistencia.ElementAt(i));
                    }
                }
                else if (valor == nomes[16])
                {
                    questions.Clear();
                    int qtd = q.Significados.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.Significados.ElementAt(i));
                    }
                }
                else if (valor == nomes[17])
                {
                    questions.Clear();
                    int qtd = q.Compatibilidade.Count;
                    for (int i = 0; i < qtd; i++)
                    {
                        questions.Add(q.Compatibilidade.ElementAt(i));
                    }
                }
            }


            questao.Text = questions.ElementAt(0);
            int cont = 0;

            voltar.Enabled = false;
            TextView menucheck = FindViewById<TextView>(Resource.Id.menucheck);
            menucheck.Click += delegate
            {                
                Intent i = new Intent(this, typeof(ChecklistActivity));
                i.PutExtra("Nome", title);
                i.PutExtra("Dados", respostas);
                i.PutExtra("Lang", lang);
                i.PutExtra("Categoria", categoria);
                StartActivity(i);               
            };
            
            
            //adiar.Background = Resources.GetDrawable(Resource.Drawable.bselected);
            bool mr = false, r = false, reg = false, b=false, mb = false;
            btnMtoRuim.Click += delegate
            {
                ResetButtons();
                if (mr)
                {
                    mr = false;
                }
                else
                {

                    r = false; reg = false; b = false; mb = false;
                    mr = true;
                    btnMtoRuim.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                    selected = "1";
                }
                
                
            };
            btnRuim.Click += delegate
            {
                //ResetButtons();
                //btnRuim.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                //selected = "2";
                ResetButtons();
                if (r)
                {
                    r = false;                    
                }
                else
                {
                    mr = false; reg = false; b = false; mb = false;
                    r = true;
                    btnRuim.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                    selected = "2";
                }
            };
            btnRegular.Click += delegate
            {
                //ResetButtons();
                //btnRegular.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                //selected = "3";
                ResetButtons();
                if (reg)
                {
                    reg = false;
                    
                }
                else
                {
                    mr = false; r = false; b = false; mb = false;
                    reg = true;
                    btnRegular.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                    selected = "3";
                }
            };
            btnBom.Click += delegate
            {
                //ResetButtons();
                //btnBom.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                //selected = "4";
                ResetButtons();
                if (b)
                {
                    b = false;
                    
                }
                else
                {
                    mr = false; r = false; reg = false; mb = false;
                    b = true;
                    btnBom.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                    selected = "4";
                }
            };
            btnMtoBom.Click += delegate
            {
                //ResetButtons();                
                //btnMtoBom.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                //selected = "5";
                ResetButtons();
                if (mb)
                {
                    mb = false;
                    
                }
                else
                {
                    mr = false; r = false; reg = false; b = false; 
                    mb = true;
                    btnMtoBom.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                    selected = "5";
                }

            };

            voltar.Click += delegate
            {
                cont--;
                SetButtons(cont+1);
                if (cont == 0)
                {
                    voltar.Enabled = false;
                }
                if (cont < questions.Count && cont >= 0 )
                {
                    proximo.Enabled = true;
                    questao.Text = questions.ElementAt(cont);
                }

                mr = false; r = false; reg = false; b = false;
                mb = false;
            };
            proximo.Click += delegate
            {
                
                Responder(categoria, cont+1, selected);

                //Toast.MakeText(Application.Context, "Questão registrada!", ToastLength.Short).Show();
                

                cont++;
                SetButtons(cont+1);
                if (cont == questions.Count)
                {
                    string text = "    Questões respondidas! \nVolte para o Menu CheckList";
                    if (lang == "en") text = "    Questions answered!\nBack to the CheckList Menu";
                    Toast.MakeText(Application.Context, text, ToastLength.Short).Show();
                    proximo.Enabled = false;
                    
                }
                if (cont < questions.Count && cont >= 0)
                {
                    voltar.Enabled = true;
                    questao.Text = questions.ElementAt(cont);
                }
                mr = false; r = false; reg = false; b = false;
                mb = false;
            };

            
           


        }
        
        ////
        public override void OnBackPressed()
        {
            Intent i = new Intent(this, typeof(ChecklistActivity));
            i.PutExtra("Nome", title);
            i.PutExtra("Dados", respostas);
            i.PutExtra("Lang", lang);
            i.PutExtra("Categoria", categoria);
            StartActivity(i);
        }
        ////

        void SetButtons(int n)
        {
            if (n >= respostas.Length) return;
            ResetButtons();
            selected = "-1";
            if (respostas[n] == "1")
            {                
                btnMtoRuim.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                selected = "1";
            }
            else if (respostas[n] == "2")
            {
                btnRuim.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                selected = "2";
            }
            else if (respostas[n] == "3")
            {
                btnRegular.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                selected = "3";
            }
            else if (respostas[n] == "4")
            {
                btnBom.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                selected = "4";
            }
            else if (respostas[n] == "5")
            {
                btnMtoBom.Background = Resources.GetDrawable(Resource.Drawable.bselected);
                selected = "5";
            }
        }
        void ResetButtons()
        {
            selected = "-1";
            btnMtoRuim.Background = Resources.GetDrawable(Resource.Drawable.bn);
            btnRuim.Background = Resources.GetDrawable(Resource.Drawable.bn);
            btnRegular.Background = Resources.GetDrawable(Resource.Drawable.bns);
            btnBom.Background = Resources.GetDrawable(Resource.Drawable.bs);
            btnMtoBom.Background = Resources.GetDrawable(Resource.Drawable.bs);
        }
        void Responder(string valor, int qNum, string resposta)
        {

            respostas[qNum] = resposta;            
            
        }
    }
}