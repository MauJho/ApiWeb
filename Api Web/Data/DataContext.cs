using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Department> Departments { get; set; }
    }
}
