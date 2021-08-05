using Api_Web.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Web.Controllers
{
    //The controller is a reserved word
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        ///         
        /// </summary>
        public readonly IUser _iUser;

        /// <summary>
        /// User Controller Constructor
        /// </summary>
        /// <param name="iUser"></param>
        public UserController(IUser iUser)
        {
            _iUser = iUser;
        }

        /// <summary>
        /// Post Method
        /// </summary>
        /// <param name="userToAdd"></param>
        /// <returns></returns>
        [HttpPost("create")]
        public async Task<IActionResult> Create(User userToAdd)
        {
            var result = await _iUser.CreateUser(userToAdd);
            return Ok(result);
        }

    }
}
