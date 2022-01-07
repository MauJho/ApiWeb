using Api_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Web.Service
{
    public interface IUserRole
    {
        Task<UserRole> AddRole(UserRole addRole);
    }
}
