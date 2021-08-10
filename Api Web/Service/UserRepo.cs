using Api_Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api_Web.Service
{
    public class UserRepo : IUser
    {
        public readonly DataContext _dataContext;

        /// <summary>
        /// Main Controller
        /// </summary>
        /// <param name="dataContext"></param>
        public UserRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// This method create a new User
        /// </summary>
        /// <param name="userToAdd"></param>
        /// <returns></returns>
        public async Task<User> CreateUser(User userToAdd)
        {
            //add User
            await _dataContext.AddAsync(userToAdd);
            var result = await _dataContext.SaveChangesAsync();

            if (result > 0)
                return userToAdd;

            return null;
        }

        public async Task<User> DeleteUser(int id)
        {
            var user = await GetUser(id);
            if (user != null)
            {
                _dataContext.Users.Remove(user);
                await _dataContext.SaveChangesAsync();
                return user;
            }
            return null;
        }

        public async Task<List<User>> GetAll()
        {
            List<User> users = await _dataContext.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetUser(int id)
        {
            User userId = await _dataContext.Users.Where(user => user.Id == id).FirstOrDefaultAsync();
            return userId;
        }

        public async Task<User> updateUser(User userUpdate)
        {
            _dataContext.Update(userUpdate);
            await _dataContext.SaveChangesAsync();

            return userUpdate;
        }
    }
}
