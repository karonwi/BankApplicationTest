using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    public class Account
    {
        public string CustomerId { get; set; }
        public string AccountNumber { get; set; }

        public double Balance { get; set; }

        public string AccountType { get; set; }

        
    }
}
