using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Implementation;
using BankApp.Models;
using BankApp.Interfaces;
using Moq;
using Xunit;

namespace BankApp.Test
{
    public class CustomerImplementationTest
    {
        private readonly Mock<IReadWriteToJson> _dbContext;

        public CustomerImplementationTest()
        {
            _dbContext = new Mock<IReadWriteToJson>();
        }

        [Fact]
        public async void ShouldGetAllCustomers()
        {
            var customer = Helper.GetCustomers();
            _dbContext.Setup(x => x.ReadJson<Customer>("Customer.json")).ReturnsAsync(customer);

            var result = new CustomerImplementation(_dbContext.Object);
            var actual = await result.GetAllCustomers();

            Assert.Equal(customer,actual);
            Assert.Equal(customer.Count,actual.Count);
            Assert.IsType<List<Customer>>(actual);
        }

        [Fact]
        public void ShouldThrowExceptionAllCustomerWhenWrongJsonParam()
        {
            var customer = Helper.GetCustomers();
            _dbContext.Setup(x => x.ReadJson<Customer>("Customer.json")).Throws<Exception>();

            var result = new CustomerImplementation(_dbContext.Object);
            

            Assert.ThrowsAsync<Exception>(()=> result.GetAllCustomers());
         
        }

        [Fact]
        public async void ShouldAddCustomerWhenNoError()
        {
            var customer = new Customer
            {
                Id = Guid.NewGuid().ToString(), Email = "sammmykay@gmail.uk", FullName = "Olaoluwa Adebayo",
                Password = "7676aaafb027c825bd9abab78b2340e702702752f625b752e55e55b48e607e358",
                Created_at = DateTime.Now
            };

            _dbContext.Setup(x => x.WriteJson<Customer>(customer, "Customer.json")).ReturnsAsync(true);
            var result = new CustomerImplementation(_dbContext.Object);
            var actual =await result.AddCustomer(customer);

            Assert.True(actual);
            _dbContext.Verify(x=>x.WriteJson<Customer>(customer,"Customer.json"),Times.Once);
        }
        [Fact]
        public  void ShouldAddCustomerWhenThereIsError()
        {
            var customer = new Customer
            {
                
            };

            _dbContext.Setup(x => x.WriteJson<Customer>(customer, "Customer.json")).Throws<Exception>();
            var result = new CustomerImplementation(_dbContext.Object);

            Assert.ThrowsAsync<Exception>(() => result.AddCustomer(customer));
        }

        [Fact]
        public async void ShouldReturnCustomerWhenIdIsCorrect()
        {
            var customer = Helper.GetCustomers();
            _dbContext.Setup(x => x.ReadJson<Customer>("Customer.json")).ReturnsAsync(customer);

            var result = new CustomerImplementation(_dbContext.Object);
            var actual = await result.GetCustomerById("e29844c5-10eb-44a5-a0a9-b922b1cdec9b");

            Assert.NotNull(actual);
            Assert.IsType<Customer>(actual);
        }

        [Fact]
        public async void ShouldReturnCustomerWhenIdIsNotCorrect()
        {
            var customer = Helper.GetCustomers();
            _dbContext.Setup(x => x.ReadJson<Customer>("Customer.json")).ReturnsAsync(customer);

            var result = new CustomerImplementation(_dbContext.Object);
            var actual = await result.GetCustomerById("e29844c5");

            Assert.Null(actual);
        }
    }   

}
