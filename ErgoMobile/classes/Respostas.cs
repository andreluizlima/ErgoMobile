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

namespace ErgoMobile.classes
{
    class Respostas
    {
        //private String[] presteza;
        //private String[] agrLocalizacao;
        //private String[] agrFormato;
        //private String[] feedback;
        //private String[] legibilidade;
        //private String[] concisao;
        //private String[] acoesMinimas;
        //private String[] densidadeInformacional;
        //private String[] acoesExplicitas;
        //private String[] controleUsuario;
        //private String[] flexibilidade;
        //private String[] expUsuario;
        //private String[] protecaoContraErros;
        //private String[] msgsErro;
        //private String[] correcaoErros;
        //private String[] consistencia;
        //private String[] significados;
        //private String[] compatibilidade;
        private string nome;
        private string aplicativo;
        private string funcionalidade;
        private List<String[]> lista;

        public Respostas()
        {
            lista = new List<string[]>();
            nome = "";
            aplicativo = "";
            funcionalidade = "";
        }

        public string Nome { get => nome; set => nome = value; }
        public string Aplicativo { get => aplicativo; set => aplicativo = value; }
        public string Funcionalidade { get => funcionalidade; set => funcionalidade = value; }
        public List<string[]> Lista { get => lista; set => lista = value; }

    }
}