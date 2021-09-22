using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IUsers
    {
        int Balance { get; set; }
        string Name { get; set; }
        string GetBalanceData();

      
    }
}
