using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Interfaces
{
    public interface IAuthentication
    {
        Task<Dictionary<string, Customer>> Login(string email, string password);
    }
}
