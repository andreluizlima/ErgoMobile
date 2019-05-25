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
    class Inspecao
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string responsavel { get; set; }
        public string aplicacao { get; set; }
    }
}