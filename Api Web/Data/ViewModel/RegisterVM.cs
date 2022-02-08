using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Web.Data.ViewModel
{
    public class RegisterVM
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        [Required]
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
    }
}
