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
using Newtonsoft.Json;

namespace ErgoMobile.classes
{
    class ControlesJSON
    {
               
        public Respostas ConverterJSON(String json)
        {
            return JsonConvert.DeserializeObject<Respostas>(json);
        }

        public String ConverterString(Respostas respostas)
        {
            return JsonConvert.SerializeObject(respostas);
        }

    }
}