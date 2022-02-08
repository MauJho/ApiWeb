using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Api_Web.Models;
using Microsoft.AspNetCore.Identity;

namespace Api_Web.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public DateTime dateOfBirth { get; set; }

        public string userName { get; set; }

        //foreing key for Departments
        public Departments departments { get; set; }

        public int departmentsId { get; set; }

        //Foreing Key for rol
        public UserRole userRoles { get; set; }

        public int userRolesId { get; set; }
    }
}
