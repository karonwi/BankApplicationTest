using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Interfaces
{
    public interface ICustomer
    {
        Task<List<Customer>> GetAllCustomers();

        Task<bool> AddCustomer(Customer model);

        Task<Customer> GetCustomerById(string Id);
    }
}
