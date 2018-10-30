using Microsoft.EntityFrameworkCore;
using Podium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podium.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
