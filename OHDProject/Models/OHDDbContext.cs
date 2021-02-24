using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHDProject.Models
{
    public class OHDDbContext : DbContext
    {
        public OHDDbContext() { }
        public OHDDbContext(DbContextOptions<OHDDbContext> options)
            : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=OHD;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Facility> Facilities { get; set; }
    }
}
