using BankFacade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankFacade.Pattern
{
    public  class BankAccountFacade
    {
        private String accountName;
        private String securityCode;

        public static AccountChecker accountChecker;
        public CashManager cashManager;

        public String GetaccountName()
        {
            return accountName;
        }
        public BankAccountFacade(string accountName, String securityCode)
        {
            
            this.accountName = accountName;
            this.securityCode = securityCode;

            accountChecker = new AccountChecker(accountName,securityCode);
            
            cashManager = new CashManager(accountName);
            
        }

        public bool depositCash(double cashAmount) { 
            
            if(accountChecker.isValid(accountName, securityCode))
            {
                cashManager.deposit(cashAmount);
                return true;
            }else
            {
                return false;
            }
        }

        public bool withdrawCash(double cashAmount)
        {
            if (accountChecker.isValid(accountName, securityCode) && cashManager.haveEnoughMoney(cashAmount))
            {
                cashManager.withdraw(cashAmount);
                return true;

            }
            else
            {
                MessageBox.Show("Tai khoan khong du tien");
                return false;
            }
        }

    }
}
