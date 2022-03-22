using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankApp.Interfaces;
using BankApp.Models;

namespace BankApp.Implementation
{
    public class TransactionImplementation : ITransaction
    {
        private readonly IReadWriteToJson _dbContext;
        private readonly string transactionFile = "Transaction.json";

        public TransactionImplementation(IReadWriteToJson dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddTransaction(Transaction model)
        {
            try
            {
                return await _dbContext.WriteJson(model, transactionFile);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Transaction>> GetAllTransactionsForAnAccount(string accountNumber)
        {
            List<Transaction> transactions = (List<Transaction>) await _dbContext.ReadJson<Transaction>(transactionFile);
            List<Transaction> result = new List<Transaction>();
            if (transactions != null)
            {
                foreach (var item in transactions)
                {
                    if (item.AccountNumber == accountNumber)
                    {
                        result.Add(item);
                    }
                    
                }
            }

            return result;
        }
    }
}
