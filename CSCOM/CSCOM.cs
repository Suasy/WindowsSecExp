using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace CSCOM
{
    [Guid("7566E188-D9EF-4BDF-A88C-98393D87FD98")]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Description("自定义COM")]
    public class CSCOM : IMyInterface
    {
        public int comFact(int n)
        {
            if (n > 1)
                return n * comFact(n - 1);
            else
                return 1;
        }

        public string[] comSplt(string s)
        {
            MatchCollection mc = Regex.Matches(s, @"[A-Za-z']+");
            string[] result = new string[mc.Count];
            int i = 0;
            foreach (Match m in mc)
            {
                result[i++] = m.ToString();
            }
            return result;
        }
    }
}
