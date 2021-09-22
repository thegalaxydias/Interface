using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class PremiumUser : IUsers
    {
        public int Balance { get; set; }
        public int BonusBalance { get; set; }
        public string Name { get; set; }
        public string GetBalanceData()
        {
            return $"`s balance is: {Balance} + {BonusBalance}. Attention! This is Premium user."
;
        }
    }
}
