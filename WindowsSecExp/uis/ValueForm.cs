using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsSecExp
{
    public partial class ValueForm : Form
    {
        public ValueForm()
        {
            InitializeComponent();

            //设置下拉列表
            uicbxValKind.Items.Insert(0, RegistryValueKind.String);
            uicbxValKind.Items.Insert(1, RegistryValueKind.Binary);
            uicbxValKind.Items.Insert(2, RegistryValueKind.DWord);
            uicbxValKind.Items.Insert(3, RegistryValueKind.QWord);
            uicbxValKind.Items.Insert(4, RegistryValueKind.MultiString);
            uicbxValKind.Items.Insert(5, RegistryValueKind.ExpandString);
            uicbxValKind.SelectedIndex = 0;
        }

        //设置TextBox
        public void SetTextBox(string valueName, RegistryValueKind valueKind, object valueData)
        {
            uitbxValName.Text = valueName;

            switch (valueKind)
            {
                case RegistryValueKind.String:
                    uicbxValKind.SelectedIndex = 0;
                    break;
                case RegistryValueKind.Binary:
                    uicbxValKind.SelectedIndex = 1;
                    break;
                case RegistryValueKind.DWord:
                    uicbxValKind.SelectedIndex = 2;
                    break;
                case RegistryValueKind.QWord:
                    uicbxValKind.SelectedIndex = 3;
                    break;
                case RegistryValueKind.MultiString:
                    uicbxValKind.SelectedIndex = 4;
                    break;
                case RegistryValueKind.ExpandString:
                    uicbxValKind.SelectedIndex = 5;
                    break;
                default:
                    break;
            }

            uitbxValData.Text = valueData.ToString();
        }

        private void uibtnCfm_Click(object sender, EventArgs e)
        {
            string valueName = uitbxValName.Text;
            RegistryValueKind valueKind = (RegistryValueKind)Enum.Parse(typeof(RegistryValueKind), uicbxValKind.SelectedItem.ToString());
            object valueData = uitbxValData.Text;
            //传递Value给父窗体
            RegeditForm f = this.Owner as RegeditForm;
            f.SetValue(valueName, valueKind, valueData);
            //设置OK
            this.DialogResult = DialogResult.OK;
            //关闭窗口
            this.Close();
        }
    }
}
