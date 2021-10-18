using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSecExp
{
    public partial class COMForm : Form
    {
        public COMForm()
        {
            InitializeComponent();
        }

        private void uibtnCOMFact_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = Convert.ToInt32(uitbxCOMFact.Text);
            }
            catch (Exception)
            {
                return;
            }
            int result = COMManager.comFact("7566E188-D9EF-4BDF-A88C-98393D87FD98", n);
            uitbxCOMFactRslt.Text = result.ToString();
        }

        private void uibtnCOMSplt_Click(object sender, EventArgs e)
        {
            string s;
            s = uitbxCOMSplt.Text;
            string[] result = COMManager.comSplt("7566E188-D9EF-4BDF-A88C-98393D87FD98", s);

            uitbxCOMSpltRslt.Text = string.Join(", ", result);
        }
    }
}
