using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSDLL;
using Microsoft.Win32;

namespace WindowsSecExp
{
    public partial class DLLForm : Form
    {

        [DllImport("CPPDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int cppAdd(int a, int b);

        [DllImport("CPPDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr cppMrg(StringBuilder a, StringBuilder b);

        MyCSDLL myCSDLL = new MyCSDLL();

        string curPath = @"SOFTWARE\Test";
        string valName = "Name";

        public DLLForm()
        {
            InitializeComponent();
            StringBuilder value = new StringBuilder();
            DLLRegManager.SearchValue(curPath, valName, value, out RegistryValueKind valueKind);
            uilblVal.Text = value.ToString();
        }

        private void uibtnCPPAdd_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Convert.ToInt32(uitbxCPPAddA.Text);
                b = Convert.ToInt32(uitbxCPPAddB.Text);
            }
            catch (Exception)
            {
                return;
            }
            int result = cppAdd(a, b);
            uitbxCPPAddRslt.Text = result.ToString();
        }

        private void uibtnCPPMrg_Click(object sender, EventArgs e)
        {
            string a, b;

            a = uitbxCPPMrgA.Text;
            b = uitbxCPPMrgB.Text;

            StringBuilder c = new StringBuilder(a.Length);
            c.Append(a);

            StringBuilder d = new StringBuilder(b.Length);
            d.Append(b);

            IntPtr intPtr = cppMrg(c, d);
            string str = Marshal.PtrToStringAnsi(intPtr);

            uitbxCPPMrgRslt.Text = str;
        }

        private void uibtnCSMul_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Convert.ToInt32(uitbxCSMulA.Text);
                b = Convert.ToInt32(uitbxCSMulB.Text);
            }
            catch (Exception)
            {
                return;
            }
            int result = this.myCSDLL.csMul(a, b);
            uitbxCSMulRslt.Text = result.ToString();
        }

        private void uibtnCSCpy_Click(object sender, EventArgs e)
        {
            string a;
            int n;
            try
            {
                n = Convert.ToInt32(uitbxCSCpyB.Text);
            }
            catch (Exception)
            {
                return;
            }
            a = uitbxCSCpyA.Text;
            string result = this.myCSDLL.csCpy(a, n);
            uitbxCSCpyRslt.Text = result;
        }

        private void uibtnOpenReg_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("regedit.exe");
        }

        private void uibtnMdfVal_Click(object sender, EventArgs e)
        {
            int rtn = DLLRegManager.ModifyValue(curPath, valName, valName, uitbxMdfVal.Text, RegistryValueKind.String);
            if (rtn != 0)
            {
                MessageBox.Show("更改键值错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("更改键值成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uilblVal.Text = uitbxMdfVal.Text;
        }

        private void uibtnSetVal_Click(object sender, EventArgs e)
        {
            int rtn = DLLRegManager.SetValue(curPath, uitbxSetValName.Text, uitbxSetValVal.Text, RegistryValueKind.String);
            if (rtn != 0)
            {
                MessageBox.Show("设置键值错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("设置键值成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void uibtnDelVal_Click(object sender, EventArgs e)
        {
            int rtn = DLLRegManager.DeleteValue(curPath, uitbxDelVal.Text);
            if (rtn != 0)
            {
                MessageBox.Show("删除键值错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("删除键值成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void uibtnCrtKey_Click(object sender, EventArgs e)
        {
            int rtn = DLLRegManager.CreateSubKey(curPath, uitbxCrtKey.Text);
            if (rtn != 0)
            {
                MessageBox.Show("创建子键错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("创建子键成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void uibtnDelKey_Click(object sender, EventArgs e)
        {
            int rtn = DLLRegManager.DeleteSubKey(curPath, uitbxDelKey.Text);
            if (rtn != 0)
            {
                MessageBox.Show("删除子键错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("删除子键成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
