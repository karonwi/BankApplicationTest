using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Interfaces;
using BankApp.Models;
using Moq;
using Xunit;
using BankApp.Implementation;

namespace BankApp.Test
{
    public class TransactionImplementationTest
    {
        private readonly Mock<IReadWriteToJson> _dBContext;

        public TransactionImplementationTest()
        {
            _dBContext = new Mock<IReadWriteToJson>();
        }

        [Fact]
        public async void ShouldAddTransactionWhenNoError()
        {
            var transactions = new Transaction()
            {
                AccountNumber = "12333333",
                Amount = "10000",
                Balance = "5000",
                Date = DateTime.Now,
                Description = "Transact"
            };

            _dBContext.Setup(x => x.WriteJson<Transaction>(transactions, "Transaction.json")).ReturnsAsync(true);
            var result = new TransactionImplementation(_dBContext.Object);
            var actual = await result.AddTransaction(transactions);

            Assert.True(actual);
            _dBContext.Verify(x => x.WriteJson<Transaction>(transactions,"Transaction.json"),Times.Once);

        }

        [Fact]
        public void ShouldAddTransactionWhenThereIsError()
        {
            var transactions = new Transaction()
            {
            };

            _dBContext.Setup(x => x.WriteJson<Transaction>(transactions, "Transaction.json")).Throws<Exception>();
            var result = new TransactionImplementation(_dBContext.Object);
       

            Assert.ThrowsAsync<Exception>(() => result.AddTransaction(transactions));

        }

        [Fact]
        public async void ShouldGetAllTransaction()
        {
            var transaction = Helper.GetTransactions();
            _dBContext.Setup(x => x.ReadJson<Transaction>("Transaction.json")).ReturnsAsync(transaction);

            var result = new TransactionImplementation(_dBContext.Object);
            var actual = await result.GetAllTransactionsForAnAccount("1233444");

            Assert.Equal(transaction,actual);
           // Assert.Equal(transaction.Count, actual.Count);
          //  Assert.IsType<List<Transaction>>(actual);
        }
    }
}
