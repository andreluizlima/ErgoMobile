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
using iTextSharp.text;
using iTextSharp.text.pdf;
using OxyPlot;
using OxyPlot.Series;

namespace ErgoMobile.classes
{
    class ExportThings
    {
        int mb = 0;
        int mr = 0;
        int b = 0;
        int r = 0;
        int reg = 0;
        int nr = 0;
        Respostas respostas;
        string lang;
        public ExportThings(Respostas respostas, string lang)
        {
            this.respostas = respostas;
            this.lang = lang;
        }
        public void ExportPDFTotal()
        {
            string pasta;
            string caminho;
            pasta = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            caminho = Path.Combine(pasta, "ErgoMobile", "Exported", "temp", "99total.pdf");
            if (!Directory.Exists(Path.Combine(pasta, "ErgoMobile", "Exported", "temp")))
            {
                Directory.CreateDirectory(Path.Combine(pasta, "ErgoMobile", "Exported", "temp"));
            }

            using (var stream = File.Create(caminho))
            {
                //595  842      298   421
                var pdfExporter = new PdfExporter { Width = 595, Height = 842 };
                pdfExporter.Export(CreateModel(30), stream);                
                stream.Close();
                stream.Dispose();
            }
            WriteAbout(-1);
        }
        public void ExportPDF()
        {
            string pasta;
            string caminho;            
            pasta = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            if (!Directory.Exists(Path.Combine(pasta, "ErgoMobile", "Exported", "temp")))
            {
                Directory.CreateDirectory(Path.Combine(pasta, "ErgoMobile", "Exported", "temp"));
            }

            for(int i=0; i < respostas.Lista.Count; i++)
            {
                char c = (char)(41 + i);
                caminho = Path.Combine(pasta, "ErgoMobile", "Exported", "temp", (i+1)+ c + ".pdf");
                using (var stream = File.Create(caminho))
                {
                    //595  842      298   421
                    var pdfExporter = new PdfExporter { Width = 595, Height = 842 };
                    pdfExporter.Export(CreateCategoryModel(i), stream);
                    stream.Close();
                    stream.Dispose();
                }
                WriteAbout(i);
            }
            
        }

        public void WriteAbout(int n)
        {
            string pasta;
            pasta = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            if (!Directory.Exists(Path.Combine(pasta, "ErgoMobile", "Exported", "temp","new")))
            {
                Directory.CreateDirectory(Path.Combine(pasta, "ErgoMobile", "Exported", "temp","new"));
            }

            char c = (char)(41 + n);
            string oldFile;
            string newFile;
            if (n >= 0)
            {
                oldFile = Path.Combine(pasta, "ErgoMobile", "Exported", "temp", (n + 1) + c + ".pdf");
                newFile = Path.Combine(pasta, "ErgoMobile", "Exported", "temp", "new", (n + 1) + c + ".pdf");
            }
            else
            {
                oldFile = Path.Combine(pasta, "ErgoMobile", "Exported", "temp", "99total.pdf");
                newFile = Path.Combine(pasta, "ErgoMobile", "Exported", "temp", "new", "99total.pdf");
            }

            // open the reader
            PdfReader reader = new PdfReader(oldFile);
            Rectangle size = reader.GetPageSizeWithRotation(1);
            Document document = new Document(size);

            // open the writer
            if(File.Exists(newFile)) File.Delete(newFile);
            FileStream fs = new FileStream(newFile, FileMode.Create, FileAccess.Write);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            
            document.Open();
            

            // the pdf content
            PdfContentByte cb = writer.DirectContent;

            // select the font properties
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetColorFill(BaseColor.DARK_GRAY);
            cb.SetFontAndSize(bf, 17);

            // write the text in the pdf content
            string Text = "Total respondido: " + (mr + r + reg + b + mb) + "       Não respondido: " + nr;
            if (lang == "en") Text = "Total answered: " + (mr + r + reg + b + mb) + "       Not answered: "+ nr;
            cb.BeginText();
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, Text, 296, 760, 0);
            cb.EndText();
            cb.BeginText();

            Text = "Muito ruim: "+mr+"     Ruim: "+r+ "     Regular: " + reg+"     Bom: " + b+"     Muito bom: " + mb;
            if (lang == "en") Text = "Too bad: " + mr + "     Bad: " + r + "     Regular: " + reg + "     Good: " + b + "     Very good: " + mb;

            // put the alignment and coordinates here
            cb.ShowTextAligned(1, Text, 296, 740, 0);
            cb.EndText();

            // create the new page and add it to the pdf
            PdfImportedPage page = writer.GetImportedPage(reader, 1);
            cb.AddTemplate(page, 0, 0);

            // close the streams and voilá the file should be changed :)
            document.Close();
            fs.Close();
            writer.Close();
            reader.Close();
        }
        public PlotModel CreateCategoryModel(int n)
        {
            mb = 0;
            mr = 0;
            b = 0;
            r = 0;
            reg = 0;
            nr = 0;
            string cat="Fail";
            string[] valores = respostas.Lista.ElementAt(n);

            for (int j = 0; j < valores.Length; j++)
            {
                string pivo = valores[j];
                switch (pivo)
                {
                    case "-1":
                        nr++;
                        break;
                    case "1":
                        mr++;
                        break;
                    case "2":
                        r++;
                        break;
                    case "3":
                        reg++;
                        break;
                    case "4":
                        b++;
                        break;
                    case "5":
                        mb++;
                        break;
                }
            }

            if(lang == "en")
            {
                if (valores[0] == "#01") cat = "Spotting";
                if (valores[0] == "#02") cat = "Grouping by location";
                if (valores[0] == "#03") cat = "Grouping by format";
                if (valores[0] == "#04") cat = "Feedback";
                if (valores[0] == "#05") cat = "Readability";
                if (valores[0] == "#06") cat = "Conciseness";
                if (valores[0] == "#07") cat = "Minimal Actions";
                if (valores[0] == "#08") cat = "Informational Density";
                if (valores[0] == "#09") cat = "Explicit Actions";
                if (valores[0] == "#10") cat = "User Control";
                if (valores[0] == "#11") cat = "Flexibility";
                if (valores[0] == "#12") cat = "User Experience";
                if (valores[0] == "#13") cat = "Error Protection";
                if (valores[0] == "#14") cat = "Error Messages";
                if (valores[0] == "#15") cat = "Error Correction";
                if (valores[0] == "#16") cat = "Consistency";
                if (valores[0] == "#17") cat = "Meanings";
                if (valores[0] == "#18") cat = "Compatibility";
            }
            else
            {
                if (valores[0] == "#01") cat = "Presteza";
                if (valores[0] == "#02") cat = "Agrupamento por localização";
                if (valores[0] == "#03") cat = "Agrupamento por formato";
                if (valores[0] == "#04") cat = "Feedback";
                if (valores[0] == "#05") cat = "Legibilidade";
                if (valores[0] == "#06") cat = "Concisão";
                if (valores[0] == "#07") cat = "Ações Mínimas";
                if (valores[0] == "#08") cat = "Densidade Informacional";
                if (valores[0] == "#09") cat = "Ações Explícitas";
                if (valores[0] == "#10") cat = "Controle de Usuário";
                if (valores[0] == "#11") cat = "Flexibilidade";
                if (valores[0] == "#12") cat = "Experiencia de Usuário";
                if (valores[0] == "#13") cat = "Proteção contra erros";
                if (valores[0] == "#14") cat = "Mensagens de erro";
                if (valores[0] == "#15") cat = "Correção de erros";
                if (valores[0] == "#16") cat = "Consistência";
                if (valores[0] == "#17") cat = "Significados";
                if (valores[0] == "#18") cat = "Compatibilidade";
            }

            string naorespondido = "Não respondido";
            string muitobom = "Muito bom";
            string muitoruim = "Muito ruim";
            string ruim = "Ruim";
            string bom = "Bom";

            if(lang == "en")
            {
                naorespondido = "Not answered";
                muitobom = "Very good";
                muitoruim = "Too bad";
                bom = "Good";
                ruim = "Bad";
            }



            PlotModel modelo = new PlotModel { Title = cat, TitleFontSize = 45};

            dynamic seriesP1 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 , FontSize = 30, Diameter = 0.75};

            seriesP1.Slices.Add(new PieSlice(naorespondido, nr) { IsExploded = false, Fill = OxyColors.PaleVioletRed });
            seriesP1.Slices.Add(new PieSlice(muitobom, mb) { IsExploded = true });
            seriesP1.Slices.Add(new PieSlice(bom, b) { IsExploded = true });
            seriesP1.Slices.Add(new PieSlice("Regular", reg) { IsExploded = true });
            seriesP1.Slices.Add(new PieSlice(ruim, r) { IsExploded = true });
            seriesP1.Slices.Add(new PieSlice(muitoruim, mr) { IsExploded = true });

            modelo.Series.Add(seriesP1);

            return modelo;
        }
        public PlotModel CreateModel(int size)
        {
            mb = 0;
            mr = 0;
            b = 0;
            r = 0;
            reg = 0;
            nr = 0;

            for (int i = 0; i < respostas.Lista.Count; i++)
            {
                string[] valores = respostas.Lista.ElementAt(i);
                for (int j = 0; j < valores.Length - 1; j++)
                {
                    string pivo = valores[j];
                    switch (pivo)
                    {
                        case "-1":
                            nr++;
                            break;
                        case "1":
                            mr++;
                            break;
                        case "2":
                            r++;
                            break;
                        case "3":
                            reg++;
                            break;
                        case "4":
                            b++;
                            break;
                        case "5":
                            mb++;
                            break;
                    }
                }
            }
            string naorespondido = "Não respondido";
            string muitobom = "Muito bom";
            string muitoruim = "Muito ruim";
            string ruim = "Ruim";
            string bom = "Bom";
            string visaogeral = "Visão geral";

            if (lang == "en")
            {
                naorespondido = "Not answered";
                muitobom = "Very good";
                muitoruim = "Too bad";
                bom = "Good";
                ruim = "Bad";
                visaogeral = "Overview";
            }
            
            PlotModel modelo = new PlotModel { Title = visaogeral, TitleFontSize = size * 1.5 };
            if (size == 14) modelo.TextColor = OxyColors.White;

            dynamic seriesP1 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0, FontSize = size, Diameter = 0.75 };

            seriesP1.Slices.Add(new PieSlice(naorespondido, nr) { IsExploded = false, Fill = OxyColors.PaleVioletRed });
            seriesP1.Slices.Add(new PieSlice(muitobom, mb) { IsExploded = true });
            seriesP1.Slices.Add(new PieSlice(bom, b) { IsExploded = true });
            seriesP1.Slices.Add(new PieSlice("Regular", reg) { IsExploded = true });
            seriesP1.Slices.Add(new PieSlice(ruim, r) { IsExploded = true });
            seriesP1.Slices.Add(new PieSlice(muitoruim, mr) { IsExploded = true });

            modelo.Series.Add(seriesP1);

            return modelo;
        }

    }
}