using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using BankApp.Interfaces;

namespace BankApp.Commons
{
    public class Validators : IValidators
    {
        public bool CheckName(string name)
        {
            string strRegex = @"^[A-Z]";

            return PerformRegEx(strRegex, name);
        }

        public bool CheckEmail(string email)
        {
            string strRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return PerformRegEx(strRegex, email);

        }

        public bool CheckPassword(string password)
        {
            
            string strRegex = @"^[A-Za-z0-9]{6,}[@#$%^&!]{1,}$";
            return PerformRegEx(strRegex, password);
        }


        private static bool PerformRegEx(string pattern, string value)
        {
            Regex reg = new Regex(pattern);


            if (reg.IsMatch(value))
                return (true);
            else
                return (false);
        }
    }
}
