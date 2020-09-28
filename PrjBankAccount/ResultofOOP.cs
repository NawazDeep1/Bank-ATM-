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
        //public struct Time
        //{
        //    public int Hour;
        //    public int Minute;
        //    public int Second;
        //}

        public ResultofOOP()
        {
            InitializeComponent();
        }
        //private Time Initialize(int hour, int minute, int second)
        //{
        //    Time anyt;
        //    anyt.Hour = hour;
        //    anyt.Minute = minute;
        //    anyt.Second = second;
        //    return anyt;
        //}
        clsStudent mystud;
        private void ResultofOOP_Load(object sender, EventArgs e)
        {
            mystud = new clsStudent();
            //clsTime rv = new clsTime();
            //rv.Hour = 24;
            //rv.Minute = 3;
            //rv.Second = 55;
            //lblResult1.Text = rv.DisplayUniversal();
            //lblResult2.Text = rv.DisplayStandard();

            //clsDate mydate = new clsDate();
            //mydate.Day = 11;
            //mydate.Month = 11;
            //mydate.Year = 1111;
            //lblDateResult1.Text = mydate.toNumber();
            //lblresultDate2.Text = mydate.ToLetter();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int day = dateBday.Value.Day;
            int month = dateBday.Value.Month;
            int year = dateBday.Value.Year;

            mystud.Register(name, day, month, year);
            btnRegister.Enabled = false;
        }

        private void btnToGrade_Click(object sender, EventArgs e)
        {
            Single grade = Convert.ToSingle(txtGrade.Text);

            if(mystud.ToGrade(grade)== true)
            {
                MessageBox.Show("Grading Succeeded");
            }
            else
            {
                MessageBox.Show("Grading failed invalid grades");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblInfo.Text = mystud.Display();
        }

        private void txtGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
