using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace BankApp.Test
{
    public class Helper
    {
        public static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>()
            {
                new Customer
                {
                    Id = "e29844c5-10eb-44a5-a0a9-b922b1cdec9b", Email = "iyinoluwasamuel@gmail.com", FullName = "Karonwi Samuel",
                    Password = "7676aaafb027c825bd9abab78b2340e702702752f625b752e55e55b48e607e358",
                    Created_at = DateTime.Now
                },
                new Customer
                {
                    Id = Guid.NewGuid().ToString(), Email = "karonwisamuel@gmail.com", FullName = "Iyinoluwa Adebayo",
                    Password = "7676aggfb027c825bd9abrg78b2340e702702752f625b752e55e55b48e607e358",
                    Created_at = DateTime.Now
                }

            };
            return customers;
        }

        public static List<Transaction> GetTransactions()
        {
            var transactions = new List<Transaction>()
            {
                new Transaction
                {
                    AccountNumber = "1233444", Amount = "50000", Balance = "5000", Date = DateTime.Now,
                    Description = "Transaction Confirmed"
                },
               
            };
            return transactions;
        }

        public static List<Account> GetAccounts()
        {
            var accounts = new List<Account>()
            {
                new Account
                {
                    AccountNumber = "1233444", AccountType = "Savings", Balance = 5000,
                    CustomerId = "e29844f5-10eb-44a5-a0a9-b922b1cdec9b"
                },
            };
            return accounts;
        }
    }
}
