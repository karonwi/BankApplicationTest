using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankApp.Interfaces;
using BankApp.Models;

namespace BankApp.Implementation
{
    public class CustomerImplementation : ICustomer
    {
        private readonly IReadWriteToJson _dbContext;
        private readonly string customerFile = "Customer.json";

        public CustomerImplementation(IReadWriteToJson dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Customer>> GetAllCustomers()
        {
            try
            {
                return (List<Customer>) await _dbContext.ReadJson<Customer>(customerFile);
            }
            catch (Exception )
            {
                throw;
            }
        }

        public async Task<bool> AddCustomer(Customer model)
        {
            try
            {
                return await _dbContext.WriteJson(model, customerFile);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Customer> GetCustomerById(string Id)
        {
            List<Customer> customers = (List<Customer>) await _dbContext.ReadJson<Customer>(customerFile);
            if (customers != null)
            {
                foreach (var customer in customers)
                {
                    if (customer.Id == Id)
                    {
                        return customer;
                    }
                }
            }
            return null;
        }
    }
}
