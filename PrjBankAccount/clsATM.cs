using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjBankAccount
{
    public class clsATM
    {
        private decimal vBalance;
        private clsListClient vClients;
        private string vCompany;
        private string vLocation;
        private string vNumber;
        private string vStatus;

        public clsATM()
        {
            vNumber = vLocation = vCompany = vStatus = "Not Defined";
            vClients = new clsListClient();
            vBalance = -1;
        }

        public clsATM(decimal balance, clsListClient clients, string company, string location, string number, string status)
        {
            throw new System.NotImplementedException();
        }

        public decimal Balance
        {
            get => default;
            set
            {
            }
        }

        public clsListClient Clients
        {
            get => default;
            set
            {
            }
        }

        public string Company
        {
            get => default;
            set
            {
            }
        }

        public string Location
        {
            get => default;
            set
            {
            }
        }

        public string Number
        {
            get => default;
            set
            {
            }
        }

        public string Status
        {
            get => default;
            set
            {
            }
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public string Display()
        {
            throw new System.NotImplementedException();
        }

        public void Fill(decimal amount)
        {
            throw new System.NotImplementedException();
        }

        public void Open()
        {
            throw new System.NotImplementedException();
        }
    }
}