using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    public interface IUtilities
    {
        string ComputeSha256Hash(string input);
        string RandomDigits(int length);
    }
}
