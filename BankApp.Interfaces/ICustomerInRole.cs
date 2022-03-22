using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.Interfaces
{
    public interface ICustomerInRole
    {
        Task<bool> AddUserToRole(string userId, int roleId);

        Task<string> GetUserRoles(string userId);

        Task<List<Roles>> GetAllRoles();
    }
}
