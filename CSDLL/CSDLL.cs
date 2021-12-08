using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDLL
{
    public class CSDLL
    {
        public int csMul(int a, int b)
        {
            return a * b;
        }

        public string csCpy(string a, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
                result += a;
            return result;
        }
    }
}
