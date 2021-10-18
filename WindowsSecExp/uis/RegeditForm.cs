using System;
using System.Collections;
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
    public partial class RegeditForm : Form
    {
        string curPath = @"SOFTWARE\Test";
        Value value = new Value();
        Stack stack = new Stack();

        public RegeditForm()
        {
            InitializeComponent();

            RefreshGridView();

            uidgvReg.SelectedIndex = 0;
        }

        //设置Value
        public void SetValue(string valueName, RegistryValueKind valueKind, object valueData)
        {
            value.SetValue(valueName, valueKind, valueData);
        } 

        //刷新网格
        private void RefreshGridView()
        {
            uidgvReg.Rows.Clear();

            //获取所有键值
            string[] valueNames = APIRegManager.GetValueNames(this.curPath);
            //添加到网格中
            foreach (string valueName in valueNames)
            {
                int index = uidgvReg.Rows.Add();
                uidgvReg.Rows[index].Cells[0].Value = valueName;
                uidgvReg.Rows[index].Cells[1].Value = "Value";
                uidgvReg.Rows[index].Cells[2].Value = APIRegManager.GetValueKind(this.curPath, valueName).ToString();
                uidgvReg.Rows[index].Cells[3].Value = APIRegManager.GetValue(this.curPath, valueName).ToString();
            }

            //获取所有子键
            string[] keyNames = APIRegManager.GetSubKeyNames(this.curPath);
            //添加到网格中
            foreach (string keyName in keyNames)
            {
                int index = uidgvReg.Rows.Add();
                uidgvReg.Rows[index].Cells[0].Value = keyName;
                uidgvReg.Rows[index].Cells[1].Value = "Key";
                uidgvReg.Rows[index].Cells[2].Value = "----";
                uidgvReg.Rows[index].Cells[3].Value = "----";
            }
        }

        //获取指定名称对应的Index
        private int GetIndex(string name, string type)
        {
            //Linq模糊查询  
            IEnumerable<DataGridViewRow> enumerableList = uidgvReg.Rows.Cast<DataGridViewRow>();

            var row = (from item in enumerableList
                       where item.Cells[0].Value.ToString().Equals(name) && item.Cells[1].Value.ToString().Equals(type)
                       select item).ToList()[0];

            return row.Index;
        }

        private void uibtnRefrh_Click(object sender, EventArgs e)
        {
            //刷新网格
            RefreshGridView();
        }

        private void uibtnCrtKey_Click(object sender, EventArgs e)
        {
            string name = uitbxCrtKey.Text;

            if (name == "")
            {
                MessageBox.Show("请输入创建子键名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            APIRegManager.CreateSubKey(this.curPath, name);

            //刷新网格
            RefreshGridView();

            uidgvReg.SelectedIndex = GetIndex(name, "Key");
        }

        private void uibtnDelChs_Click(object sender, EventArgs e)
        {
            int index = uidgvReg.SelectedIndex;

            if (index < 0)
                return;

            string name = uidgvReg.Rows[index].Cells[0].Value.ToString();
            string type = uidgvReg.Rows[index].Cells[1].Value.ToString();

            if (MessageBox.Show(string.Format("确定要永久删除 {0} {1} 吗？", type, name), "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (type == "Value")
                    APIRegManager.DeleteValue(this.curPath, name);
                else
                    APIRegManager.DeleteSubKeyTree(this.curPath, name);

                //刷新网格
                RefreshGridView();
            }

            if (index == uidgvReg.RowCount)
                uidgvReg.SelectedIndex = index - 1;
            else
                uidgvReg.SelectedIndex = index;
        }

        private void uibtnSetVal_Click(object sender, EventArgs e)
        {
            ValueForm valueForm = new ValueForm();
            valueForm.Text = "设置键值";
            if (valueForm.ShowDialog(this) == DialogResult.OK)
            {
                //设置键值
                APIRegManager.SetValue(this.curPath, this.value.GetValueName(), this.value.GetValueData(), this.value.GetValueKind());

                //刷新网格
                RefreshGridView();

                uidgvReg.SelectedIndex = GetIndex(this.value.GetValueName(), "Value");
            }
        }

        private void uibtnBack_Click(object sender, EventArgs e)
        {
            if (this.curPath == @"SOFTWARE\Test")
            {
                MessageBox.Show("为了安全起见，不允许返回到 SOFTWARE 目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.curPath = stack.Pop().ToString();
            uilblPath.Text = @"当前路径: HKEY_LOCAL_MACHINE\" + this.curPath;

            //刷新网格
            RefreshGridView();
        }

        private void uidgvReg_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = uidgvReg.SelectedIndex;
            string name = uidgvReg.Rows[index].Cells[0].Value.ToString();
            string type = uidgvReg.Rows[index].Cells[1].Value.ToString();

            //如果是键值
            if (type == "Value")
            {
                ValueForm valueForm = new ValueForm();
                valueForm.SetTextBox(name, APIRegManager.GetValueKind(this.curPath, name), APIRegManager.GetValue(this.curPath, name));
                valueForm.Text = "修改键值";
                if (valueForm.ShowDialog(this) == DialogResult.OK)
                {
                    //修改键值
                    APIRegManager.ModifyValue(this.curPath, name, this.value.GetValueName(), this.value.GetValueData(), this.value.GetValueKind());

                    //刷新网格
                    RefreshGridView();

                    uidgvReg.SelectedIndex = GetIndex(this.value.GetValueName(), "Value");
                }
            }
            //如果是子键
            else
            {
                stack.Push(this.curPath);
                this.curPath += (@"\" + name);
                uilblPath.Text = @"当前路径: HKEY_LOCAL_MACHINE\" + this.curPath;
                RefreshGridView();
            }
        }
    }
}
