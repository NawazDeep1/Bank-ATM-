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
    public partial class FrmATM : Form
    {
        public FrmATM()
        {
            InitializeComponent();
        }

        private void FrmATM_Load(object sender, EventArgs e)
        {
            txtDeposit.Visible = false;
            lblDeposit.Visible = false;
            txtWithdraw.Visible = false;
            lblWithdraw.Visible = false;
            this.Height = 149;
        }

        private void radDeposit_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Visible = true;
            lblDeposit.Visible = true;
            txtWithdraw.Visible = false;
            lblWithdraw.Visible = false;
            txtDeposit.Focus();
        }

        private void radWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Visible = false;
            lblDeposit.Visible = false;
            txtWithdraw.Visible = true;
            lblWithdraw.Visible = true;
            txtWithdraw.Focus();
        }

        private void radConsult_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Visible = false;
            lblDeposit.Visible = false;
            txtWithdraw.Visible = false;
            lblWithdraw.Visible = false;
        }

        private void btnNextNum_Click(object sender, EventArgs e)
        {
            this.Height = 264;
        }

        private void btnNextAccount_Click(object sender, EventArgs e)
        {
            this.Height =464;
        }

        private void btnNextPin_Click(object sender, EventArgs e)
        {
            this.Height =350;
        }

        private void btnNextTransaction_Click(object sender, EventArgs e)
        {
            this.Height =631;
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            this.Height =149;
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)==false && char.IsControl(e.KeyChar)==false)
            {
                e.Handled = true;
            }
        }

        private void txtWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
