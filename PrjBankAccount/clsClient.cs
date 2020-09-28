using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjBankAccount
{
    public class clsClient
    {
        private clsListAccount vAccounts;
        private string vName;
        private string vNumber;
        private string vPin;
        private string vStatus;

        public clsClient()
        {
            vNumber = vName = vStatus = vPin = "Not defined";
            vAccounts = new clsListAccount();
        }

        public clsClient(string number, string name, string pin, string status, clsListAccount accounts)
        {
            vNumber = number;
            vName = name;
            vPin = pin;
            vStatus = status;
            vAccounts = accounts;
        }

        public clsClient(string number, string name, string pin, string status)
        {
            vNumber = number;
            vName = name;
            vPin = pin;
            vStatus = status;
            vAccounts = new clsListAccount();
        }

        public string Number
        {
            get => vNumber;
        }

        public string Name
        {
            get => vName;
            set
            {
                vName = value;
            }
        }

        public string Status
        {
            get => vStatus;
        }

        public String Pin
        {
            get => vPin;
            set
            {
                vPin = value;
            }
        }

        public clsListAccount Accounts
        {
            get => vAccounts;
            set
            {
                vAccounts = value;
            }
        }

        public void Register(string number, string name, string pin)
        {
            vNumber = number;
            Name = name;
            Pin = pin;
            vStatus = "Active";


        }

        public string Display()
        {
            string info = "\nNumber: " + vNumber + "\nName " +
                vName +
                "\nPin: " + vPin + "\nStatus: " + vStatus +
                "\nAccount:\n " + vAccounts.Display();
            return info;
        }
    }
}