using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankApp.Interfaces;
using BankApp.Models;

namespace BankApp.Implementation
{
    public class AccountImplementation : IAccount
    {
        private readonly IReadWriteToJson _dbContext;
        private readonly string accountFile = "Accounts.json";

        public AccountImplementation(IReadWriteToJson dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Account>> GetAllAccounts()
        {
            try
            {
                return (List<Account>) await _dbContext.ReadJson<Account>(accountFile);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateAccount(Account model)
        {
            var account = await GetAllAccounts();
            if (account != null)
            {
                foreach (var item in account)
                {
                    if (item.AccountNumber == model.AccountNumber)
                        item.Balance = model.Balance;
                }

                return await _dbContext.UpdateJson<Account>(account, accountFile);
            }

            return false;
        }

        public async Task<List<Account>> GetAllAccountByCustomer(string Id)
        {
            List<Account> accounts = (List<Account>) await _dbContext.ReadJson<Account>(accountFile);
            List<Account> result = new List<Account>();

            if (accounts != null)
            {
                foreach (var account in accounts)
                {
                    if (account.CustomerId == Id)
                    {
                        result.Add(account);
                    }
                }
            }

            return result;
        }

        public async Task<bool> AddAccount(Account model)
        {
            try
            {
                return await _dbContext.WriteJson(model, accountFile);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Account> GetAccountDetails(string accountNumber)
        {
            var accounts = await GetAllAccounts();
            foreach (var item in accounts)
            {
                if (item.AccountNumber == accountNumber)
                    return item;
            }

            return null;
        }

    }
}
