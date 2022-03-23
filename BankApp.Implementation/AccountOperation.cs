using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BankApp.Interfaces;
using BankApp.Models;

namespace BankApp.Implementation
{
    public class AccountOperation : IAccountOperation
    {
        private readonly IAccount _account;
        private readonly ITransaction _transaction;

        public AccountOperation(ITransaction transaction, IAccount account)
        {
            _transaction = transaction;
            _account = account;
        }

        public async Task<bool> Deposit(string accountNumber, string amount)
        {
            
            
                Account account = await _account.GetAccountDetails(accountNumber);
                if (account != null)
                {
                        account.Balance += Convert.ToDouble(amount);
                    bool check = await _account.UpdateAccount(account);
                    if (check)
                    {
                        Transaction trans = new Transaction()
                        {
                            AccountNumber = accountNumber,
                            Description = "Deposit Money",
                            Amount = amount,
                            Balance = account.Balance.ToString()
                        };
                        await _transaction.AddTransaction(trans);
                        return true;
                    }

                    return false;
                }
                return false;
                
            
        }

        public async Task<bool> Withdraw(string accountNumber, string withdrawalAmount)
            {
                bool response = false;
                try
                {
                    Account account = await _account.GetAccountDetails(accountNumber);
                    double minBalance = account.AccountType == "Saving" ? 1000.0 : 0.0;
                    double amount = Convert.ToDouble(withdrawalAmount);
                    if (amount <= account.Balance - minBalance)
                    {
                        account.Balance -= amount;
                        bool check = await _account.UpdateAccount(account);
                        if (check)
                        {
                            Transaction transaction = new Transaction()
                            {
                                AccountNumber = accountNumber,
                                Description = "Withdraw Cash",
                                Amount = withdrawalAmount,
                                Balance = account.Balance.ToString()
                            };
                            await _transaction.AddTransaction(transaction);
                        }

                        response = true;
                    }
                    else if (amount > account.Balance - minBalance)
                    {
                        response = false;
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                return response;
            }
        }
    }

