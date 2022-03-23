using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankApp.Interfaces;
using BankApp.Models;

namespace BankApp.Implementation
{
    public class AuthImplementation : IAuthentication
    {
        private readonly ICustomer _customer;
        private readonly ICustomerInRole _customerInRole;
        private readonly IUtilities _Utilities;

        public AuthImplementation(ICustomer customer, ICustomerInRole customerInRole, IUtilities Utilities)
        {
            _customer = customer;
            _customerInRole = customerInRole;
            _Utilities = Utilities;
        }
        public async Task<Customer> Login(string email, string password)
        {
            string hashPassword = _Utilities.ComputeSha256Hash(password);
            var users = await _customer.GetAllCustomers();
            foreach (var item in users)
            {
                if (item.Email == email && item.Password == hashPassword)
                {
                    return item;
                }

            }

            return null;
        }
    }
}
