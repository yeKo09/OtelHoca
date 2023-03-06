using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelHoca.UI.Common
{
    public class Musteri
    {

        public string AdSoyad { get; set; }

        public string TCNo { get; set; }

        public string TelNo { get; set; }

        public string Yas { get; set; }

        public override string ToString()
        {
            return AdSoyad;
        }

    }
}
