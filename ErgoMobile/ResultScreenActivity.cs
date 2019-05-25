using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Pdf;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ErgoMobile.classes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Xamarin.Android;

namespace ErgoMobile
{
    [Activity(Label = "Resultados")]
    public class ResultScreenActivity : Activity
    {
        Respostas respostas;
        string inspecao;
        ExportThings et;
        string relatorio;
        string fileat;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ResultScreen);
            PlotView view = FindViewById<PlotView>(Resource.Id.plotView1);
            string lang="pt";
            Data data = new Data();
            Button voltar = FindViewById<Button>(Resource.Id.voltarchecklist);
            Intent i = new Intent(this, typeof(ChecklistActivity));

            relatorio = "Relatório de resultados";
            fileat = "Arquivo em: ";
            if (Intent.GetStringExtra("Lang") != null)
            {
                lang = Intent.GetStringExtra("Lang");
                i.PutExtra("Lang", lang);
                if(lang == "en")
                {
                    relatorio = "Results report";
                    fileat = "File at: ";
                    voltar.Text = "Return";
                }
            }

            if (Intent.GetStringExtra("Nome") != null)
            {

                string valor = Intent.GetStringExtra("Nome");
                i.PutExtra("Nome", valor);
                inspecao = valor;
                respostas = data.Abrir(inspecao);

            }else{
                respostas = new Respostas();
            }

            et = new ExportThings(respostas, lang);

            voltar.Click += delegate
            {
                StartActivity(i);
            };

            view.Model = et.CreateModel(14);

            ToPDF(); 
        }

        


        public void ToPDF()
        {
            string pasta;
            string caminho;
            pasta = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;

            et.ExportPDFTotal();
            et.ExportPDF();

            caminho = Path.Combine(pasta, "ErgoMobile", "Exported", "temp", "new", "0resultado.pdf");
            if (File.Exists(caminho)) File.Delete(caminho);
            using (var stream = File.Create(caminho))
            {
                var doc = new PortableDocument();
                doc.AddPage(OxyPlot.PageSize.A4);
                doc.Title = relatorio;
                doc.Author = "ErgoMobile";
                doc.SetFont("Arial", 46);
                doc.DrawText(50, 420, relatorio);
                doc.SetFont("Arial", 30);
                doc.DrawText(200, 380, "ErgoMobile");
                doc.SetFont("Arial", 25);
                doc.DrawText(40, 140, inspecao);
                doc.SetFont("Arial", 18);
                doc.DrawText(40, 120, fileat+ (Path.Combine(pasta, "ErgoMobile", "Exported")));
                doc.Save(stream);
            }


            caminho = Path.Combine(pasta, "ErgoMobile", "Exported", "temp", "new");
            CreateMergedPDF(Path.Combine(pasta, "ErgoMobile", "Exported",inspecao+".pdf"), caminho);


            ///// DELETE TEMPORARY STUFF
            caminho = Path.Combine(pasta, "ErgoMobile", "Exported", "temp");
            System.IO.DirectoryInfo di = new DirectoryInfo(caminho);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
            Directory.Delete(caminho);
            //System.Diagnostics.Process.Start(Path.Combine(pasta, "ErgoMobile", "Exported", inspecao + ".pdf"));
            //var uri = Android.Net.Uri.Parse(Path.Combine(pasta, "ErgoMobile", "Exported", inspecao + ".pdf"));   

            //ABRIR RELATORIO GERADO
            Java.IO.File fl = new Java.IO.File(Path.Combine(pasta, "ErgoMobile", "Exported", inspecao + ".pdf"));
            fl.SetReadable(true);
            
            Android.Net.Uri uri = Android.Net.Uri.FromFile(fl);
            var intent = new Intent(Intent.ActionView);
            intent.SetFlags(ActivityFlags.ClearWhenTaskReset | ActivityFlags.NewTask);
            string application = "application/pdf";
            intent.SetDataAndType(uri, application);
            this.StartActivity(intent);
        }


        
        public void CreateMergedPDF(string targetPDF, string sourceDir)
        {
            using (FileStream stream = new FileStream(targetPDF, FileMode.Create))
            {
                Document pdfDoc = new Document(iTextSharp.text.PageSize.A4);
                PdfCopy pdf = new PdfCopy(pdfDoc, stream);
                pdfDoc.Open();
                var files = Directory.GetFiles(sourceDir);
                
                int i = 1;
                foreach (string file in files)
                {
                    pdf.AddDocument(new PdfReader(file));
                    
                    i++;
                }

                if (pdfDoc != null) { }
                pdfDoc.Close();
                stream.Close();
            }
        }


    }
}