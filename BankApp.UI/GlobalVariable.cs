using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using BankApp.Models;

namespace BankApp.UI
{
    public class GlobalVariable
    {
        public static Customer GlobalCustomer { get; set; }
        public static string CustomerRole { get; set; }
    }
}
