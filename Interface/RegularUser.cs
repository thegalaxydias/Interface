using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class RegularUser : IUsers
    {
        public int Balance { get; set; }
        public string Name { get; set; }
        public string GetBalanceData()
        {
            return $"`s balance is: {Balance}";
        }
    }
}
