using Api_Web.Data;
using Api_Web.Data.ViewModel;
using Api_Web.Models;
using Api_Web.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.core;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Api_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public AuthenticationController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,
          DataContext context,
          IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
            _configuration = configuration;
        }



        [HttpPost("Register-user")]
        public async Task<IActionResult> Register([FromBody] RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Please, provide all the required fields.");
            }
            var userExist = await _userManager.FindByIdAsync(registerVM.email);
            if (userExist != null)
            {
                return BadRequest($"User {registerVM.email} already exist");
            }
            User newUser = new User()
            {
                name = registerVM.name,
                lastName = registerVM.lastName,
                email = registerVM.email,
                userName = registerVM.userName,
                SecurityStamp = Guid.NewGuid().ToString()

            };
            var result = await _userManager.CreateAsync(newUser, registerVM.password);
            var emailuserwrong = "";
            if (result.Succeeded)
            {
                return Ok("User Created");
            }
            return BadRequest("User could not be created");
        }




    }



}
