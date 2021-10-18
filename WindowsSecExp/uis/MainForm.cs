using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace WindowsSecExp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //第一个Page
            FileMgtForm fileMgtForm = new FileMgtForm();
            UIPanel uiPanel1 = fileMgtForm.Controls[0] as UIPanel;
            uiPanel1.Parent = uiTabControl.TabPages[0];

            //第二个Page
            RegeditForm regeditForm = new RegeditForm();
            UIPanel uiPanel2 = regeditForm.Controls[0] as UIPanel;
            uiPanel2.Parent = uiTabControl.TabPages[1];

            //第三个Page
            DLLForm dllForm = new DLLForm();
            UIPanel uiPanel3 = dllForm.Controls[0] as UIPanel;
            uiPanel3.Parent = uiTabControl.TabPages[2];

            //第四个Page
            COMForm comForm = new COMForm();
            UIPanel uiPanel4 = comForm.Controls[0] as UIPanel;
            uiPanel4.Parent = uiTabControl.TabPages[3];
        }


    }
}
