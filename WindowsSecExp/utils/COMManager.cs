using CSCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSecExp
{
    class COMManager
    {
        public static IMyInterface CreateIMyInterface(string _guid)
        {
            IMyInterface iMyInterface = null;

            Guid guid = new Guid(_guid);
            Type myInterfaceType = Type.GetTypeFromCLSID(guid);
            object myInterface = Activator.CreateInstance(myInterfaceType);
            iMyInterface = myInterface as IMyInterface;

            return iMyInterface;
        }

        public static int comFact(string guid, int n)
        {
            IMyInterface iMyInterface = CreateIMyInterface(guid);
            return iMyInterface.comFact(n);
        }

        public static string[] comSplt(string guid, string s)
        {
            IMyInterface iMyInterface = CreateIMyInterface(guid);
            return iMyInterface.comSplt(s);
        }
    }
}
