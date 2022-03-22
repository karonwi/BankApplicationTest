using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Created_at { get; set; }= DateTime.Now;

        private List<Account> Accounts { get; set; }
    }
}
