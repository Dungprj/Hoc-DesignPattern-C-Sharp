using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankFacade.Models
{
    public  class CashManager
    {
        private double cashInAccount;

        public String GetCashInAccount()
        {
            return cashInAccount.ToString();
        }
        public CashManager(String name) 
        {
            CashData cashData = new CashData();
            this.cashInAccount = cashData.GetCash(name);
        }

        public void deposit(double cashAmount)
        {
            cashInAccount += cashAmount;
            MessageBox.Show("so tien moi la : " + cashInAccount);
        }
        public bool haveEnoughMoney(double cashAmount)
        {
            return cashInAccount >= cashAmount;
        }

        public void withdraw(double cashAmount)
        {
            cashInAccount -= cashAmount;
            MessageBox.Show("so tien moi la : " + cashInAccount);

        }
    }
}
