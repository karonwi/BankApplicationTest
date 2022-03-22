using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using BankApp.Interfaces;

namespace BankApp.Commons
{
    public class Utilities : IUtilities
    {
        public string ComputeSha256Hash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }


        public string RandomDigits(int length)
        {
            var random = new Random();
            string ran = string.Empty;
            for (int i = 0; i < length; i++)
                ran = String.Concat(ran, random.Next(10).ToString());
            return ran;
        }

        
    }
}
