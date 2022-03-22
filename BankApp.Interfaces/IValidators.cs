using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    public interface IValidators
    {
        bool CheckEmail (string email);
        bool CheckPassword (string password);
        bool CheckName (string namw);

    }
}
