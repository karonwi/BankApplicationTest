using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankApp.Interfaces;
using BankApp.Models;

namespace BankApp.Implementation
{
    public class CustomerRoleImplementation : ICustomerInRole
    {
        private readonly IReadWriteToJson _dbContext;
        private readonly string customerInRoleFile = "CustomerInRole.json";
        private readonly string roleFile = "Roles.json";

        public CustomerRoleImplementation(IReadWriteToJson dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddUserToRole(string customerId, int roleId)
        {
            CustomerInRoles customerInRoles = new CustomerInRoles()
            {
                RoleId = roleId,
                CustomerId = customerId
            };
            try
            {
                return await _dbContext.WriteJson<CustomerInRoles>(customerInRoles, customerInRoleFile);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public async Task<string> GetUserRoles(string userId)
        {
            var customerRoles = await _dbContext.ReadJson<CustomerInRoles>(customerInRoleFile);
            var roles = await GetAllRoles();
            List<Roles> rolesList = null;
            if (customerRoles != null)
            {
                foreach (var item in customerRoles)
                {
                    if (item.CustomerId == userId)
                    {
                        rolesList = roles.FindAll(x => x.Id == item.RoleId);
                        return rolesList[0].RoleName;
                    }
                }
            }

            return null;
        }

        public async Task<List<Roles>> GetAllRoles()
        {
            try
            {
                return (List<Roles>)await _dbContext.ReadJson<Roles>(roleFile);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
