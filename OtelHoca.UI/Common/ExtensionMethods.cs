using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelHoca.UI.Common
{
    public static class ExtensionMethods
    {


        public static bool BosVarmi(this string text)
        {
            return (string.IsNullOrEmpty(text));
        }


        public static bool NumaraVarmi(this string text)
        {
            return (text.Any(Char.IsDigit));
        }

        public static bool TcDogruMu(this string text)
        {
            return (text.Length != 11);
        }

        public static bool TelefonNoDogruMu(this string text)
        {
            return (text.Length != 14);
        }

    }
}
