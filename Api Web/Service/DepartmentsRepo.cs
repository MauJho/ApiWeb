using Api_Web.Data;
using Api_Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            return departmentId;
        }

        public async Task<Departments> UpdateDepartment(Departments departmentToUpdate)
        {
            _dataContext.Update(departmentToUpdate);

            await _dataContext.SaveChangesAsync();

            return departmentToUpdate;
        }
    }
}
