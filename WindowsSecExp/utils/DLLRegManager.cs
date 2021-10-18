using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace WindowsSecExp
{
    class DLLRegManager
    {
        static readonly IntPtr HKEY_CLASSES_ROOT = new IntPtr(unchecked((int)0x80000000));
        static readonly IntPtr HKEY_CURRENT_USER = new IntPtr(unchecked((int)0x80000001));
        static readonly IntPtr HKEY_LOCAL_MACHINE = new IntPtr(unchecked((int)0x80000002));
        static readonly IntPtr HKEY_USERS = new IntPtr(unchecked((int)0x80000003));
        static readonly IntPtr HKEY_PERFORMANCE_DATA = new IntPtr(unchecked((int)0x80000004));
        static readonly IntPtr HKEY_CURRENT_CONFIG = new IntPtr(unchecked((int)0x80000005));
        static readonly IntPtr HKEY_DYN_DATA = new IntPtr(unchecked((int)0x80000006));

        static readonly int REG_OPTION_NON_VOLATILE = 0;
        static readonly int KEY_ALL_ACCESS = 983103;

        static readonly IntPtr rk = HKEY_LOCAL_MACHINE;

        //打开子键
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegOpenKeyEx(IntPtr hKey, string lpSubKey, uint ulOptions, int samDesired, out IntPtr phkResult);

        //关闭子键
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegCloseKey(IntPtr hKey);

        //创建子键
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegCreateKeyEx(IntPtr hKey, string lpSubKey, int reserved, string type, int dwOptions, int REGSAM, IntPtr lpSecurityAttributes, out IntPtr phkResult,
                                                 out int lpdwDisposition);

        //删除子键
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegDeleteKey(IntPtr hKey, string lpSubKey);

        //设置键值
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegSetValueEx(IntPtr hKey, string lpValueName, uint unReserved, uint unType, byte[] lpData, uint dataCount);

        //删除键值
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegDeleteValue(IntPtr hKey, string lpValueName);

        //获取指定键值
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int RegQueryValueEx(IntPtr hKey, string lpValueName, int lpReserved, out uint lpType, System.Text.StringBuilder lpData, ref uint lpcbData);

        //创建子键
        public static int CreateSubKey(string path, string keyName)
        {
            int rtn = RegCreateKeyEx(rk, path + @"\" + keyName, 0, "", REG_OPTION_NON_VOLATILE, KEY_ALL_ACCESS, IntPtr.Zero, out IntPtr phk, out int lpdw);
            RegCloseKey(phk);
            return rtn;
        }

        //删除子键
        public static int DeleteSubKey(string path, string keyName)
        {
            return RegDeleteKey(rk, path + @"\" + keyName);
        }

        //创建键值
        public static int SetValue(string path, string valueName, object value, RegistryValueKind valueKind)
        {
            RegOpenKeyEx(rk, path, 0, KEY_ALL_ACCESS, out IntPtr phk);

            byte[] bytes = Encoding.Unicode.GetBytes(value.ToString());
            int rtn = RegSetValueEx(phk, valueName, 0, (uint)valueKind, bytes, (uint)bytes.Length);
            RegCloseKey(phk);

            return rtn;
        }

        //删除键值
        public static int DeleteValue(string path, string valueName)
        {
            RegOpenKeyEx(rk, path, 0, KEY_ALL_ACCESS, out IntPtr phk);

            int rtn = RegDeleteValue(phk, valueName);
            RegCloseKey(phk);

            return rtn;
        }

        //修改键值
        public static int ModifyValue(string path, string oldValueName, string newValueName, object value, RegistryValueKind valueKind)
        {
            int rtn = DeleteValue(path, oldValueName);

            if (rtn != 0)
                return rtn;

            rtn = SetValue(path, newValueName, value, valueKind);

            return rtn;
        }

        //获取指定键值
        public static int SearchValue(string path, string valueName, StringBuilder value, out RegistryValueKind valueKind)
        {

            RegOpenKeyEx(rk, path, 0, KEY_ALL_ACCESS, out IntPtr phk);

            uint size = 10000;
            uint _valueKind;

            int rtn = RegQueryValueEx(phk, valueName, 0, out _valueKind, value, ref size);
            RegCloseKey(phk);

            valueKind = (RegistryValueKind)_valueKind;

            return rtn;
        }

        //判断子键是否存在
        public static bool IsSubKeyExist(string path, string keyName)
        {

            return true;
        }

        //判断键值名称是否存在
        public static bool IsValueExist(string path, string valueName)
        {
            return true;
        }

        //获取所有子键
        public static string[] GetSubKeyNames(string path)
        {
            string[] keyNames = { "0" };
            return keyNames;
        }

        //获取所有键值名称
        public static string[] GetValueNames(string path)
        {
            string[] valueNames = { "0" };
            return valueNames;
        }
    }
}