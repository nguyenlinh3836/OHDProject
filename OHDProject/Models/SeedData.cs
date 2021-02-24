using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHDProject.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            OHDDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<OHDDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Facilities.Any())
            {
                context.Facilities.AddRange(
                    new Facility
                    {
                        FacilityName = "Library"
                    },
                    new Facility
                    {
                        FacilityName = "Computer Room"
                    },
                    new Facility
                    {
                        FacilityName = "ClassRoom"
                    },
                    new Facility
                    {
                        FacilityName = "Swimming Pool"
                    },
                    new Facility
                    {
                        FacilityName = "Security"
                    }
                    );
                context.SaveChanges();
            }
            if (!context.Roles.Any())
            {
                context.Roles.AddRange(
                    new Role
                    {
                        RoleName = "Admin"
                    },
                    new Role
                    {
                        RoleName = "Assign"
                    },
                    new Role
                    {
                        RoleName = "Customer"
                    },
                    new Role
                    {
                        RoleName = "User"
                    }
                    );
                context.SaveChanges();
            }
        }

    }
}