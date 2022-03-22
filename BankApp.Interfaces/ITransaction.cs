using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Interfaces
{
    public interface ITransaction
    {
        Task<bool> AddTransaction(Transaction model);
        Task<List<Transaction>> GetAllTransactionsForAnAccount(string accountNumber);
    }
}
