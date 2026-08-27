using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Customer
    {
        public Customer()
        {
            Balance = 1;
        }

        public Customer(int _AccountNumber, string _CustomerName, int _Password, string _EMail, double _Balance)
        {
            AccountNumber = _AccountNumber;
            CustomerName = _CustomerName;
            Password = _Password;
            EMail = _EMail;
            Balance = _Balance;
        }

        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public int Password { get; set; }
        public string EMail { get; set; }
        public double Balance { get; set; }

    }
}
