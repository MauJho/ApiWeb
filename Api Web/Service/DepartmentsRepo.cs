using Api_Web.Data;
using Api_Web.Exceptions;
using Api_Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api_Web.Service
{
    public class DepartmentsRepo : IDepartment
    {
        public readonly DataContext _dataContext;

        public DepartmentsRepo (DataContext datacontext)
        {
            _dataContext = datacontext;
        }
        public async Task<Departments> AddDepartment(Departments departmentToAdd)
        {
            await _dataContext.AddAsync(departmentToAdd);
            var result = await _dataContext.SaveChangesAsync();

            if(result > 0)
            {
                return departmentToAdd;
            }
            return null;
        }

        public async Task<Departments> GetDepartment(int id)
            {
            
                    Departments departmentId = await _dataContext.Departments.Where(department => department.Id == id).FirstOrDefaultAsync();

                    if (departmentId != null)
                    {
                        return departmentId;
                    } 

                      return null;
            }

        public async Task<Departments> UpdateDepartment(Departments departmentToUpdate)
        {
            _dataContext.Update(departmentToUpdate);

            await _dataContext.SaveChangesAsync();

            return departmentToUpdate;
        }

        public async Task<Departments> DeleteDepartment(int id)
        {
            var users =  _dataContext.Users.Any(u => u.DepartmentsId == id);
            if (!users)
            {
                var dep = await GetDepartment(id);
                _dataContext.Departments.Remove(dep);
                await _dataContext.SaveChangesAsync();
                return dep;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Departments>> GetAllDepartments()
        {
            List<Departments> listOfDepartments = await _dataContext.Departments.ToListAsync();
            return listOfDepartments;
        }
    }
}
