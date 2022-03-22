using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Implementation;
using BankApp.Interfaces;
using BankApp.Models;
using Moq;
using Xunit;

namespace BankApp.Test
{
    public class AccountImplementationTest
    {
        private readonly Mock<IReadWriteToJson> _dBContext;

        public AccountImplementationTest()
        {
            _dBContext = new Mock<IReadWriteToJson>();
        }

        [Fact]
        public async void ShouldAddAccountWhenNoError()
        {
            var account = new Account()
            {
                CustomerId = "e29844f5-10eb-44a5-a0a9-b922b1cdec9b", AccountNumber = "1233099", AccountType = "Savings",
                Balance = 10000
            };
            _dBContext.Setup(x => x.WriteJson<Account>(account, "Accounts.json")).ReturnsAsync(true);
            var result = new AccountImplementation(_dBContext.Object);
            var actual = await result.AddAccount(account);

            Assert.True(actual);
            _dBContext.Verify(x=> x.WriteJson<Account>(account,"Accounts.json"),Times.Once);
        }

        [Fact]
        public void ShouldAddAccountWhenThereIsError()
        {
            var account = new Account()
            {
            };
            _dBContext.Setup(x => x.WriteJson<Account>(account, "Accounts.json")).Throws<Exception>();
            var result = new AccountImplementation(_dBContext.Object);

            Assert.ThrowsAsync<Exception>(() => result.AddAccount(account));

        }

        [Fact]
        public async void ShouldGetAllAccounts()
        {
            var account = Helper.GetAccounts();
            _dBContext.Setup(x => x.ReadJson<Account>("Accounts.json")).ReturnsAsync(account);
            var result = new AccountImplementation(_dBContext.Object);
            var actual = await result.GetAllAccounts();

            Assert.Equal(account,actual);
            Assert.Equal(account.Count,actual.Count);
        }

        [Fact]
        public  void ShouldThrowExceptionWhenAllAccount()
        {
            var account = Helper.GetAccounts();
            _dBContext.Setup(x => x.ReadJson<Account>("Accounts.json")).Throws<Exception>();
            var result = new AccountImplementation(_dBContext.Object);

            Assert.ThrowsAsync<Exception>(() => result.GetAllAccounts());

        }
    }
}
