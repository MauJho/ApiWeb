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
    public class RoleController : ControllerBase
    {
        public readonly IUserRole _iUserRole;

        public RoleController(IUserRole iUserRole)
        {
            _iUserRole = iUserRole;
        }

        /// <summary>
        /// Add a Role to the User
        /// </summary>
        /// <param name="addRole"></param>
        /// <returns></returns>
        [HttpPost("addrole")]
        public async Task<IActionResult> AddRole(UserRole addRole)
        {
            var result = await _iUserRole.AddRole(addRole);
            return Ok(result);
        }
    }
}
