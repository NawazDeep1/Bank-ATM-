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
    public partial class ResultofOOP : Form
    {
        public struct Time
        {
            public int Hour;
            public int Minute;
            public int Second;
        }

        public ResultofOOP()
        {
            InitializeComponent();
        }
        private Time Initialize(int hour, int minute, int second)
        {
            Time anyt;
            anyt.Hour = hour;
            anyt.Minute = minute;
            anyt.Second = second;
            return anyt;
        }

        private void ResultofOOP_Load(object sender, EventArgs e)
        {
            clsTime rv = new clsTime();
            rv.Hour = 24;
            rv.Minute = 3;
            rv.Second = 55;
            lblResult1.Text = rv.DisplayUniversal();
            lblResult2.Text = rv.DisplayStandard();

            clsDate mydate = new clsDate();
            mydate.Day = 11;
            mydate.Month = 11;
            mydate.Year = 1111;
            lblDateResult1.Text = mydate.toNumber();
            lblresultDate2.Text = mydate.ToLetter();

        }
    }
}
