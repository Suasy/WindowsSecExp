using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CSCOM
{
    [Guid("F2874F65-E11C-48C9-903E-6B6A50426748")]
    [ComVisible(true)]
    public interface IMyInterface
    {
        [DispId(1)]
        int comFact(int n);

        [DispId(2)]
        string[] comSplt(string s);
    }
}
