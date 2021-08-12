using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Web.Models
{
    public class Department
    {
        [Key]
        public int DepartmentEmployeeId { get; set; }
        public string Departments{ get; set; }
        public string Division{ get; set; }
        public string Workstream { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
