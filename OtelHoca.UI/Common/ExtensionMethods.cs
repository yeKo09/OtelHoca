using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelHoca.UI.Common
{
    public static class ExtensionMethods
    {


        public static bool isEmpty(this string text)
        {
            return (string.IsNullOrEmpty(text));
        }


        public static bool isNumber(this string text)
        {
            return (text.Any(Char.IsDigit));
        }

        public static bool isTcIncorrect(this string text)
        {
            return (text.Length != 11);
        }

        public static bool isTelNoIncorrect(this string text)
        {
            return (text.Length != 14);
        }

    }
}
