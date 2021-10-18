using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace WindowsSecExp
{
    class APIRegManager
    {
        public static RegistryKey rk = Registry.LocalMachine;

        //创建子键
        public static void CreateSubKey(string path, string keyName)
        {
            rk.CreateSubKey(path + @"\" + keyName).Close();
        }

        //删除子键
        public static void DeleteSubKeyTree(string path, string keyName)
        {
            rk.DeleteSubKeyTree(path + @"\" + keyName, true);
        }

        //创建键值
        public static void SetValue(string path, string valueName, object value, RegistryValueKind valueKind)
        {
            RegistryKey pathKey = rk.OpenSubKey(path, true);
            pathKey.SetValue(valueName, value, valueKind);
            pathKey.Close();
        }

        //删除键值
        public static void DeleteValue(string path, string valueName)
        {
            RegistryKey pathKey = rk.OpenSubKey(path, true);
            pathKey.DeleteValue(valueName, true);
            pathKey.Close();
        }

        //修改键值
        public static void ModifyValue(string path, string oldValueName, string newValueName, object value, RegistryValueKind valueKind)
        {
            DeleteValue(path, oldValueName);
            SetValue(path, newValueName, value, valueKind);
        }

        //判断子键是否存在
        public static bool IsSubKeyExist(string path, string keyName)
        {
            string[] keyNames;

            //获取path key下所有的子键
            keyNames = GetSubKeyNames(path);

            foreach (string s in keyNames)
            {
                if (s == keyName)
                    return true;
            }

            return false;
        }

        //判断键值名称是否存在
        public static bool IsValueExist(string path, string valueName)
        {
            string[] valueNames;

            //获取path key下所有的键值名称
            valueNames = GetValueNames(path);

            foreach (string s in valueNames)
            {
                if (s == valueName)
                    return true;
            }

            return false;
        }

        //获取所有子键
        public static string[] GetSubKeyNames(string path)
        {
            //打开对应path key
            RegistryKey pathKey = rk.OpenSubKey(path);

            //获取path key下所有的子键
            string[] keyNames = pathKey.GetSubKeyNames();

            pathKey.Close();

            return keyNames;
        }

        //获取所有键值名称
        public static string[] GetValueNames(string path)
        {
            //打开对应path key
            RegistryKey pathKey = rk.OpenSubKey(path);

            //获取path key下所有的键值名称
            string[] valueNames = pathKey.GetValueNames();

            pathKey.Close();

            return valueNames;
        }

        //获取键值
        public static object GetValue(string path, string valueName)
        {
            //打开对应path key
            RegistryKey pathKey = rk.OpenSubKey(path);

            object value = pathKey.GetValue(valueName);

            pathKey.Close();

            return value;
        }

        //获取键值类型
        public static RegistryValueKind GetValueKind(string path, string valueName)
        {
            //打开对应path key
            RegistryKey pathKey = rk.OpenSubKey(path);

            RegistryValueKind valueKind = pathKey.GetValueKind(valueName);

            pathKey.Close();

            return valueKind;
        }
    }
}
