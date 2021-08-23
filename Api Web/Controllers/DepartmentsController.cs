using Api_Web.Models;
using Api_Web.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        public readonly IDepartment _iDepartment;

        public DepartmentsController(IDepartment iDepartment)
        {
            _iDepartment = iDepartment;
        }
        /// <summary>
        /// Add a department to the User
        /// </summary>
        /// <param name="departmentToAdd"></param>
        /// <returns></returns>
        [HttpPost("adddepartment")]
        public async Task<IActionResult> AddDepartment(Departments departmentToAdd)
        {
            var result = await _iDepartment.AddDepartment(departmentToAdd);
            return Ok(result);
        }

        /// <summary>
        /// get the information of the department where the user belong
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartment(int id)
        {
            var retrive = await _iDepartment.GetDepartment(id);
            return Ok(retrive);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateUserDepartment(Departments departmentToUpdate)
        {
            var result = await _iDepartment.UpdateDepartment(departmentToUpdate);
            return Ok(result);
        }
    }
}
