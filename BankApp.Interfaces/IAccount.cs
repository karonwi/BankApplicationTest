using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Interfaces
{
    public interface IAccount
    {
       Task<List<Account>>  GetAllAccounts();
       Task<bool> UpdateAccount(Account model);
       Task<List<Account>> GetAllAccountByCustomer(string Id);

       Task<bool> AddAccount(Account model);
       Task<Account> GetAccountDetails(string accountNumber);
    }
}
