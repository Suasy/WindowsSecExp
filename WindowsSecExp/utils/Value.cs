using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace WindowsSecExp
{
    class Value
    {
        private string valueName;
        private RegistryValueKind valueKind;
        private object valueData;

        public string GetValueName()
        {
            return this.valueName;
        }
        public RegistryValueKind GetValueKind()
        {
            return this.valueKind;
        }
        public object GetValueData()
        {
            return this.valueData;
        }
        public void SetValue(string valueName, RegistryValueKind valueKind, object valueData)
        {
            this.valueName = valueName;
            this.valueKind = valueKind;
            this.valueData = valueData;
        }
    }
}
