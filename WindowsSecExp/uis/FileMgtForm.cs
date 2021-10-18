using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSecExp
{
    public partial class FileMgtForm : Form
    {
        string srcDir = "";
        string dstFile = "";
        string[] srcFiles;

        public FileMgtForm()
        {
            InitializeComponent();

            this.srcDir = @"D:\Study\ProgramStudy\C#Study\WindowsSecExp\WindowsSecExp\txt";
            uitbxDir.Text = this.srcDir;

            RefreshListBox();
        }

        private void RefreshListBox()
        {
            uilbxSrc.Items.Clear();
            //文件目录是否存在
            if (Directory.Exists(this.srcDir))
            {
                //获取所有文本文件名
                this.srcFiles = Directory.GetFiles(this.srcDir, "*.txt");

                //添加到列表中
                foreach (string file in this.srcFiles)
                {
                    uilbxSrc.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void uibtnChsDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = @"D:\Study\ProgramStudy\C#Study\WindowsSecExp\WindowsSecExp\txt";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.srcDir = folderBrowserDialog.SelectedPath;
                uitbxDir.Text = this.srcDir;
            }
            //刷新列表
            uibtnRefrh.PerformClick();
        }

        private void uibtnDstFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Filter = "TXT 格式|*.txt|所有|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.dstFile = saveFileDialog.FileName;
                uitbxDst.Text = this.dstFile;
            }
        }

        private void uibtnRefrh_Click(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void uibtnAdd_Click(object sender, EventArgs e)
        {
            if (uilbxSrc.SelectedIndex >= 0)
            {
                uilbxDst.Items.Add(uilbxSrc.SelectedItem);
            }
        }

        private void uibtnClear_Click(object sender, EventArgs e)
        {
            uilbxDst.Items.Clear();
        }

        private void uibtnUp_Click(object sender, EventArgs e)
        {
            int index = uilbxDst.SelectedIndex;   //选择的索引
            object obj = uilbxDst.SelectedItem;   //选择的Item
            if (index > 0)
            {
                uilbxDst.Items[index] = uilbxDst.Items[index - 1];
                uilbxDst.Items[index - 1] = obj;
                uilbxDst.SelectedIndex = index - 1;
            }
        }

        private void uibtnDown_Click(object sender, EventArgs e)
        {
            int length = uilbxDst.Count;          //列表的长度
            int index = uilbxDst.SelectedIndex;   //选择的索引
            object obj = uilbxDst.SelectedItem;   //选择的Item
            if (index >= 0 || index < length - 1)
            {
                uilbxDst.Items[index] = uilbxDst.Items[index + 1];
                uilbxDst.Items[index + 1] = obj;
                uilbxDst.SelectedIndex = index + 1;
            }
        }

        private void uibtnOpenFile_Click(object sender, EventArgs e)
        {
            if (uilbxDst.SelectedIndex >= 0)
            {
                string file = uilbxDst.SelectedItem.ToString();
                string filePath = this.srcDir + @"\" + file;
                System.Diagnostics.Process.Start("notepad.exe", filePath);
            }
        }

        private void uibtnMerge_Click(object sender, EventArgs e)
        {
            string[] fileStr = new string[uilbxDst.Count];    //所有文本文件的字符串集合
            int i = 0;
            //读出文本文件
            foreach (string item in uilbxDst.Items)
            {
                string str = "";
                using (StreamReader sr = new StreamReader(this.srcDir + @"\" + item))
                {
                    string preLine = null;
                    string curLine = null;
                    //从文件读取并显示行，直到文件的末尾
                    while ((curLine = sr.ReadLine()) != null)
                    {
                        if (preLine != null)
                            str += (preLine + "\r\n");
                        preLine = curLine;
                    }
                    str += preLine;
                }
                fileStr[i++] = str;
            }
            //打印结果
            int length = fileStr.Length;
            //换行
            if (uicbxNewLine.Checked)
                uitbxResult.Text = string.Join("\r\n", fileStr);
            //不换行
            else
                uitbxResult.Text = string.Join("", fileStr);
        }

        private void uibtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.dstFile))
                    sw.Write(uitbxResult.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请设置目标文件名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("导出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("notepad.exe", this.dstFile);
        }
    }
}
