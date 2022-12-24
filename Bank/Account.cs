using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        public static double money { get; set; } = 0;
    }

    partial class Work
    {
        Account Account = new Account();
        public double moneyWork { get; set; }
    }
}
