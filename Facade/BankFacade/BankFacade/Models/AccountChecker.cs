using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFacade.Models
{
    public  class AccountChecker
    {
        private String accName;
        private String secCode;
        private List<Dictionary<String,String>> listAccount = new List<Dictionary<String, String>>();

        
        public void GetData()
        {
            Dictionary<string, string> account1 = new Dictionary<string, string>();
            account1.Add("dung1", "123");
            listAccount.Add(account1);

            Dictionary<string, string> account2 = new Dictionary<string, string>();
            account2.Add("dung2", "456");
            listAccount.Add(account2);

            Dictionary<string, string> account3 = new Dictionary<string, string>();
            account3.Add("dung3", "678");
            listAccount.Add(account3);
        }
        public AccountChecker(String accountName,String securityCode)
        {
            accName = accountName;
            secCode = securityCode;


        }

        public bool isValid(String accountName, String securityCode)
        {
            GetData();

            foreach (var acc in listAccount)
            {
                if(acc.ContainsKey(accountName) && acc[accountName] == secCode)
                {
                    return true;
                }
                
            }
            return false;



        }
    }
}
