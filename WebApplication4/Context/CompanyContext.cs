using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Context
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
