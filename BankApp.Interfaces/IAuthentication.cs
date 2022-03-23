using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Interfaces
{
    public interface IAuthentication
    {
        Task<Customer> Login(string email, string password);
    }
}
