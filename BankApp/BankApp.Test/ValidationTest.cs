using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using BankApp.Commons;
using Xunit;

namespace BankApp.Test
{
    public class ValidationTest
    {
        private Validators _validate;

        public ValidationTest()
        {
            _validate = new Validators();
        }

        [Theory]
        [InlineData("samuelkaronwi@gmail.com",true)]
        [InlineData("samuel.karonwi@gmail.com",true)]
        [InlineData("samuel.karonwi@gmail.uk",true)]
        [InlineData("samuel.karonwi.gmail.com",false)]
        [InlineData("samuel@karonwi@gmail.com",false)]
        
        public void ShouldValidateEmail(string email , bool expected)
        {


            bool actual = _validate.CheckEmail(email);

            Assert.Equal(expected,actual);
            Assert.IsType<bool>(actual);

        }

        [Theory]
        [InlineData("Karonwi", true)]
        [InlineData("KAronwi", true)]
        [InlineData("karonwi", false)]

        public void ShouldValidateFirstName(string name , bool expected)
        {
            
            bool actual = _validate.CheckName(name);
            Assert.Equal(expected,actual);
            Assert.IsType<bool>(actual);
        }

        [Theory]
        [InlineData("Samuel", true)]
        [InlineData("SAMUEL", true)]
        [InlineData("sAmuel", false)]
        [InlineData("samuel",false)]
       
        public void ShouldValidateLastName(string name ,bool expected)
        {
            bool actual = _validate.CheckName(name);
            Assert.Equal(expected, actual);
            Assert.IsType<bool>(actual);
        }

        [Theory]
        [InlineData("Samuel7413#", true)]
        [InlineData("Samuel7413#$", true)]
        [InlineData("samuel74", false)]
        [InlineData("samuel",false)]

        public void ShouldValidPassword( string password , bool expected)
        {
            bool actual = _validate.CheckPassword(password);
            Assert.Equal(expected,actual);
            Assert.IsType<bool>(actual);
        }
        
    }
}
