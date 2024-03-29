using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFacade.Models
{
    public class CashData
    {
        private List<Dictionary<String, double>> listCashAccount = new List<Dictionary<String, double>>();
        public CashData() {
            Dictionary<string, double> account1 = new Dictionary<string, double>();
            account1.Add("dung1", 150000);
            listCashAccount.Add(account1);

            Dictionary<string, double> account2 = new Dictionary<string, double>();
            account2.Add("dung2", 50000);
            listCashAccount.Add(account2);

            Dictionary<string, double> account3 = new Dictionary<string, double>();
            account3.Add("dung3", 200000);
            listCashAccount.Add(account3);
        }

        public double GetCash(String Name)
        {
            foreach (var acc in listCashAccount)
            {
                if (acc.ContainsKey(Name))
                {
                    return acc[Name];
                }
                
            }
            
             return 0;
            
        }
    }
}
