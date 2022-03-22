using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Interfaces
{
    public interface IAccountOperation
    {
        Task<bool> Deposit(string accountNumber, string amount);
        Task<bool> Withdraw(string accountNumber, string amount);
    }
}
