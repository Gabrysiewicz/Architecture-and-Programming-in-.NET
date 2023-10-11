using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public class MyFormatter
    {
        public static string FormatUsdPrice(decimal price)
        {
            var usc = new CultureInfo("en-us");
            return price.ToString("C2", usc);
        }
        public static string FormatPlnPrice(decimal price)
        {
            var plc = new CultureInfo("pl-PL");
            return price.ToString("C2", plc);
        }
    }
}
