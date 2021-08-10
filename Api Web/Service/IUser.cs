using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Web.Service
{
    public interface IUser
    {
        Task<User> CreateUser(User userToAdd);
        Task<User> updateUser(User userUpdate);
        Task<User> GetUser(int id);
        Task<List<User>> GetAll();
        Task<User> DeleteUser(int id);
    }
}
