using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHDProject.Models
{
    public class EFRepository:IRepository
    {
        private OHDDbContext context;
        public EFRepository(OHDDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Account> Accounts => context.Accounts;
        public IQueryable<Request> Requests => context.Requests;
        public IQueryable<Facility> Facilities  => context.Facilities;
        public IQueryable<Role> Roles => context.Roles;
    }
}
