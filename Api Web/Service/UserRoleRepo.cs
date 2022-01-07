using Api_Web.Data;
using Api_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Web.Service
{
    public class UserRoleRepo : IUserRole
    {
        public readonly DataContext _dataContext;

        public UserRoleRepo(DataContext dataContext) 
            {
                _dataContext = dataContext;
            }

        public async Task<UserRole> AddRole(UserRole addRole)
        {
            await _dataContext.AddAsync(addRole);
            var result = await _dataContext.SaveChangesAsync();

            if(result > 0)
            {
                return addRole;
            }
            else
            {
                return null;
            }

        }
    }
}
