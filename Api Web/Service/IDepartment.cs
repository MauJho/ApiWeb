using Api_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Web.Service
{
    public interface IDepartment
    {
        Task<Departments> AddDepartment(Departments departmentToAdd);

        Task<Departments> GetDepartment(int id);

        Task<Departments> UpdateDepartment(Departments departmentToUpdate);

        Task<Departments> DeleteDepartment(int id);

        Task<List<Departments>> GetAllDepartments();
    }
}
