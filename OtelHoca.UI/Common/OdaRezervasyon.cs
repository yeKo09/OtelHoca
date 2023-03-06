using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelHoca.UI.Common
{
    public class OdaRezervasyon
    {

        public Oda Oda { get; set; }

        public Musteri Musteri { get; set; } = new Musteri();

        public DateTime GirisTarihi { get; set; }

        

    }
}
