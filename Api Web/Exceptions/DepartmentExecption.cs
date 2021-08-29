using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Web.Exceptions
{
    public class DepartmentExecption: Exception
    {
        public DepartmentExecption(string message): base(message)
        {

        }
    }
}
