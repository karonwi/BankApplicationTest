using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankApp.Implementation;
using BankApp.Interfaces;
using BankApp.Models;
using Moq;
using Xunit;

namespace BankApp.Test
{
    public class AccountOperationTest
    {
        
        private readonly Mock<IAccount> _mockAccount;
        private readonly Mock<ITransaction> _mockTransaction;
        

        public AccountOperationTest()
        {
            _mockAccount = new Mock<IAccount>();
            _mockTransaction = new Mock<ITransaction>();
        }

        [Theory]
        [InlineData("123456789", "5000", true)]
        [InlineData("112233445", "1000", false)]
        [InlineData("1233222220", "200", false)]
        public async void Deposit_Should(string accountNumber, string amount, bool expected)
        {
            AccountDetailsMock();
            _mockTransaction.Setup(x => x.AddTransaction(It.IsAny<Transaction>())).ReturnsAsync(true);

            var accountOperation = new AccountOperation(_mockTransaction.Object, _mockAccount.Object);

            var actual = await accountOperation.Deposit(accountNumber, amount);
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData("123456789", "4000", true)]
        [InlineData("112233445", "10000", false)]
        [InlineData("1233222220", "200", false)]
        public async void Withdraw_Should(string accountNumber, string withdrawalAmount,bool expected)
        {
            AccountDetailsMock();
            _mockTransaction.Setup(x => x.AddTransaction(It.IsAny<Transaction>())).ReturnsAsync(true);

            var accountOperation = new AccountOperation(_mockTransaction.Object, _mockAccount.Object);

            var actual = await accountOperation.Withdraw(accountNumber, withdrawalAmount);

            Assert.Equal(expected,actual);
        }
      
        #region Account Detail Implementation

        private void AccountDetailsMock()
        {
            Account account = new Account()
            {
                AccountNumber = "123456789",
                AccountType = "Savings",
                Balance = 5000,
                CustomerId = "123333"
            };
            _mockAccount.Setup(x => x.GetAccountDetails("123456789")).ReturnsAsync(account);
            _mockAccount.Setup(x => x.UpdateAccount(account)).ReturnsAsync(true);
        }

        
        #endregion
    }
}