using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnveilerN.Utils
{
    internal class Unveiler
    {
        /// <summary>
        /// 找 unveiler 路径
        /// </summary>
        /// <returns></returns>
        public static string FindExecutePath()
        {
            foreach (var file in Directory.EnumerateFiles(".", "unveiler*.exe"))
            {
                string fileName = Path.GetFileNameWithoutExtension(file); 
                if (!fileName.StartsWith("UnveilerN", StringComparison.OrdinalIgnoreCase))
                {
                    return Path.GetFullPath(file);
                }
            }

            return null;
        }
    }
}
