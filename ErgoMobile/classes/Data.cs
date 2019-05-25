using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace ErgoMobile.classes
{
    class Data
    {
        string pasta;
        string caminho;
        string name; string appp; string func;

        public Data()
        {
            pasta = "";
            caminho = "";
            name = "";
            appp = "";
            func = "";

        }
        public Respostas Abrir(string nome)
        {
            Respostas r = new Respostas();
            ControlesJSON controles = new ControlesJSON();
            pasta = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            caminho = Path.Combine(pasta, "ErgoMobile", (nome+".json"));
            StreamReader leitor;
            try
            {
                leitor = new StreamReader(caminho);
                string s = leitor.ReadToEnd();
                //Console.WriteLine("CODIGOOOOOOO: "+s);
                r = controles.ConverterJSON(s);
                leitor.Dispose();
                //Console.Write("\n\n\n\n\n\n");
                //for (int i = 0; i < r.Lista.Count; i++)
                //{
                //    Console.WriteLine(r.Lista.ElementAt(i)[0]);
                //}
                
                //Console.Write("\n\n\n\n\n\n");
                //String[] j = r.Lista.ElementAt(1);
                
            }
            catch(Exception e)
            {
                Console.WriteLine("\n\n\n\nERROOOOOOOOOOOOOOOOOOO\n\n\n\n" + e);
                //System.Diagnostics.Debug.WriteLine("\n\n\n\nERROOOOOOOOOOOOOOOOOOO\n\n\n\n"+e);

                Toast.MakeText(Application.Context, "Arquivo JSON inexistente ou com falhas!", ToastLength.Short).Show();
            }
            

            return r;
        }

        public Respostas Salvar(Respostas r, string[] dados, string categoria, string nome)
        {
            ////portugues
            int cat=-1;
            if (categoria == "Presteza") cat = 0;
            if (categoria == "Agrupamento por localização") cat = 1;
            if (categoria == "Agrupamento por formato") cat = 2;
            if (categoria == "Feedback") cat = 3;
            if (categoria == "Legibilidade") cat = 4;
            if (categoria == "Concisão") cat = 5;
            if (categoria == "Ações Mínimas") cat = 6;
            if (categoria == "Densidade Informacional") cat = 7;
            if (categoria == "Ações Explícitas") cat = 8;
            if (categoria == "Controle de Usuário") cat = 9;
            if (categoria == "Flexibilidade") cat = 10;
            if (categoria == "Experiencia de Usuário") cat = 11;
            if (categoria == "Proteção contra erros") cat = 12;
            if (categoria == "Mensagens de erro") cat = 13;
            if (categoria == "Correção de erros") cat = 14;
            if (categoria == "Consistência") cat = 15;
            if (categoria == "Significados") cat = 16;
            if (categoria == "Compatibilidade") cat = 17;
            ////ingles
            if (categoria == "Spotting") cat = 0;
            if (categoria == "Grouping by location") cat = 1;
            if (categoria == "Grouping by format") cat = 2;
            if (categoria == "Feedback") cat = 3;
            if (categoria == "Readability") cat = 4;
            if (categoria == "Conciseness") cat = 5;
            if (categoria == "Minimal Actions") cat = 6;
            if (categoria == "Informational Density") cat = 7;
            if (categoria == "Explicit Actions") cat = 8;
            if (categoria == "User Control") cat = 9;
            if (categoria == "Flexibility") cat = 10;
            if (categoria == "User Experience") cat = 11;
            if (categoria == "Error Protection") cat = 12;
            if (categoria == "Error Messages") cat = 13;
            if (categoria == "Error Correction") cat = 14;
            if (categoria == "Consistency") cat = 15;
            if (categoria == "Meanings") cat = 16;
            if (categoria == "Compatibility") cat = 17;
            //////
            Respostas retorno = new Respostas();

            retorno.Nome = r.Nome;
            retorno.Aplicativo = r.Aplicativo;
            retorno.Funcionalidade = r.Funcionalidade;

            ControlesJSON controles = new ControlesJSON();
            pasta = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            caminho = Path.Combine(pasta, "ErgoMobile", (nome + ".json"));
            StreamWriter criar = new StreamWriter(caminho, false);
                for (int i = 0; i < r.Lista.Count; i++)
                {
                    if (i == cat)
                    {
                        retorno.Lista.Add(dados);
                    }
                    else
                    {
                        retorno.Lista.Add(r.Lista.ElementAt(i));

                        //for (int j = 0; j < r.Lista.ElementAt(i)[j].Length; j++)
                        //{
                        //    String[] ss = new String[r.Lista.ElementAt(i)[j].Length];
                        //    string v = r.Lista.ElementAt(i)[j];
                        //    if (v == null)
                        //    {
                        //        ss[j] = "0";
                        //    }
                        //    else
                        //    {
                        //        ss[j] = v;
                        //    }
                        //}
                    }

                }
            
            criar.WriteLine(controles.ConverterString(retorno));
            criar.Dispose();
            return retorno;
        }

        Respostas criar(string caminho, string pasta)
        {
            ControlesJSON controles = new ControlesJSON();
            Respostas r = new Respostas();
            
            r.Nome = name;
            r.Aplicativo = appp;
            r.Funcionalidade = func;

            //Console.WriteLine(r.Nome+" AAAAAAA " + r.Aplicativo + "                   OI");
            r.Lista.Add("#01,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#02,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#03,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#04,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#05,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#06,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#07,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#08,-1,-1,-1,-1,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#09,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#10,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#11,-1,-1,-1".Split(','));
            r.Lista.Add("#12,-1,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#13,-1,-1,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#14,-1,-1,-1,-1,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#15,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#16,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#17,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1".Split(','));
            r.Lista.Add("#18,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1".Split(','));

            if (!Directory.Exists(Path.Combine(pasta, "ErgoMobile")))
            {
                Directory.CreateDirectory(Path.Combine(pasta, "ErgoMobile"));
            }
            
            StreamWriter criar = new StreamWriter(caminho, false);
            criar.WriteLine(controles.ConverterString(r));
            criar.Dispose();
            return r;
        }

        public void Novo(string nome, string app, string funcionalidade)
        {
            pasta = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            caminho = Path.Combine(pasta, "ErgoMobile", (nome + ".json"));
            appp = app;
            func = funcionalidade;
            name = nome;
            Respostas r = criar(caminho, pasta);
            
            

            string pasta2 = Path.Combine(pasta, "ErgoMobile");
            if (!Directory.Exists(Path.Combine(pasta2, "info")))
            {
                Directory.CreateDirectory(Path.Combine(pasta2, "info"));
            }
            caminho = Path.Combine(pasta, "ErgoMobile", "info", "data.dat");
            StreamWriter stream = new StreamWriter(caminho, true);
            stream.WriteLine(nome+"%"+app+"%"+funcionalidade);
            stream.Dispose();
        }

        public List<Inspecao> getInsp()
        {
            List<Inspecao> l = new List<Inspecao>();
            pasta = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            caminho = Path.Combine(pasta, "ErgoMobile", "info", ("data.dat"));
            StreamReader leitor;
            try
            {
                leitor = new StreamReader(caminho);
                string s;
                while (!leitor.EndOfStream)
                {
                    s = leitor.ReadLine();
                    string[] recuperada = s.Split('%');
                    l.Add(new Inspecao{ nome = recuperada[0], aplicacao = recuperada[1], responsavel = recuperada[2] });
                }
                leitor.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine("\n\n\n\nERROOOOOOOOOOOOOOOOOOO\n\n\n\n" + e);

                //l = criar(caminho, pasta);
            }


            return l;
        }
    }
}