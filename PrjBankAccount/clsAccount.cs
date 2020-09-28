using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjBankAccount
{
    public class clsAccount
    {
        // Fields will store the value og properties
        private decimal vBalance;
        private string vNumber;
        private clsDate vOpenDate;
        private string vStatus;
        private string vType;

        //consttructor
        public clsAccount()
        {
           vNumber= vType=vStatus = "Not Defined";
            vOpenDate = new clsDate();
            vBalance = -1;
        }

        public clsAccount(string number, string type, int day, int month, int year, string status, decimal balance)
        {
            vNumber = number;
            vType = type;
            vOpenDate = new clsDate(day, month, year);
            vStatus = status;
            vBalance = balance;
        }

        //Properties
        public decimal Balance //Read only
        {
            get => vBalance;

        }

        public string Number //Read only
        {
            get {
                return vNumber;
            } 
            
        }

        public clsDate OpenDate //Read only
        {
            get => OpenDate;
        }

        public string Status //Read only
        {
            get =>vStatus;
        }

        public string Type
        {
            get => vType;
            set
            {
                vType = value;

            }
        }
            //Methods
        public void Close()
        {
            vStatus = "Closed";
        }

        public string Consult()
        {
            string info = "Number: " + vNumber + "\nType: " + 
                vType +
               "\nOpenDate: " + vOpenDate.toNumber()+ 
               "\nStatus: " +
               vStatus + "\nBalance - " + vBalance + "$\n";

            return info;
        }

        /// <summary>
        /// Return true if amount is between 2 and 20,000 else false        /// </summary>

        public bool Deposit(decimal amount)
        {
            if(amount >= 2 && amount <= 20000)
            {
                vBalance = vBalance + amount;
                return true;
            }
            else { return false; }

        }

        public void open(string number, string type)
        {
            vNumber = number;
            Type = type;
            vOpenDate.Initialize(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            vStatus = "Active";
            vBalance = 0;
        }
        
        /// Return 0 (for sucess), 1(for Maximum), 2 (for Minimum), -1 (for Multiple 20), -2 (for insufficent funds)
        
        public int Withdraw(decimal amount)
        {
            if (amount > 500)
            { return 1; }

            else if (amount < 20)
            { return 2; }

            else if ((amount % 20) != 0)
            { return -1; }

            else if (amount > vBalance)
            { return -2; }

            else
            {
                vBalance = vBalance - amount; // or vbalance -= amount;
            }
            return 0;

        }
    }
}