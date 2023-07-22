using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnveilerN.Utils
{
    internal class ConsoleOutput
    {
        public static string RemoveAnsiColor(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            return Regex.Replace(value, @"\x1b\[\d{2}m", string.Empty);
        }
    }
}
