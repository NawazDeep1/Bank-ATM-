using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjBankAccount
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            string info = "Are you sure you want to Quit ?";
            string title = "Application Closing Warning ";

            if (MessageBox.Show(info,title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand)==DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void mnuATM_Click(object sender, EventArgs e)
        {
            FrmATM myfrm = new FrmATM();
            myfrm.MdiParent = this;
            myfrm.Show();
        }
    }
}
