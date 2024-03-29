using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BankFacade.Models
{
    public class SecurityCodeChecker
    {
        private int securityCode;
        public SecurityCodeChecker(int secCode) {
            securityCode = secCode;
        }

        public bool isValid(int secCode)
        {
            return securityCode == secCode;
        }

    }
}
