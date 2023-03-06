using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelHoca.UI.Common
{
    public class Oda
    {

        public byte Kapasite { get; set; }

        public int Numarasi { get; set; }

        public double Fiyat 
        {
            get
            {
                return 50 * Kapasite;
            }
                
        }

        public OdaDurumu OdaDurumu { get; set; }

    }
}
