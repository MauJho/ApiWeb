using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Web.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string Department{ get; set; }
        public string Division{ get; set; } 
        public string Workstream { get; set; }


    }
}
