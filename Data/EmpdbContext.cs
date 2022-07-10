using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmpApp.Models;

namespace EmpApp.Data
{
    public class EmpdbContext : DbContext
    {
        public EmpdbContext (DbContextOptions<EmpdbContext> options)
            : base(options)
        {
        }

        public DbSet<EmpApp.Models.Employee>? Employee { get; set; }
    }
}
