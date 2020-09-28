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

        private void mnuOOP_Click(object sender, EventArgs e)
        {
            ResultofOOP myfrm = new ResultofOOP();
            myfrm.MdiParent = this;
            myfrm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            ////collection with index
            //List<clsStudent> colStuds = new List<clsStudent>();
            //clsStudent st1 = new clsStudent("st111", "Marco Jatt", 2, 12, 2000, 89);
            //colStuds.Add(st1);
            //colStuds.Add( new clsStudent("st222", "Marco Jatt", 3, 12, 2000, 889));
            //colStuds.Add(new clsStudent("st333", " Jatt", 12, 12, 2000, 98));
            //MessageBox.Show(colStuds[0].Display());

            clsClient myClient = new clsClient("c1c1", "Brar", "Windows", "Active");


            //clsListAccount tabAccount = new clsListAccount();
            clsAccount ac1 = new clsAccount("ac11", "savings", 2, 3, 2003, "active", 25000);
            myClient.Accounts.Add(ac1);
            myClient.Accounts.Add(new clsAccount("ac22", "savings", 2, 2, 2013, "active", 22000));
            myClient.Accounts.Add(new clsAccount("ac33", "savings", 1, 12, 2014, "active", 2000));

            //tabAccount.Add(ac1);

            //tabAccount.Add(new clsAccount("ac22", "savings", 2, 2, 2013, "active", 22000));

            //tabAccount.Add(new clsAccount("ac33", "savings", 1, 12, 2014, "active", 2000));

            //MessageBox.Show(tabAccount.Display());

            //MessageBox.Show(tabAccount.Find("ac22").Consult());

            MessageBox.Show(myClient.Display());

        }
    }
}
