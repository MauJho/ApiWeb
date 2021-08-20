using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Api_Web.Models;

namespace Api_Web
{
    public class User
    {
        public int Id{ get; set; }

        [Required]
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        //foreing key for Departments
        public Departments Departments { get; set; }
    }
}
