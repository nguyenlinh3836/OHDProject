using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHDProject.Models
{
    public class IRepository
    {
        IQueryable<Account> Accounts { get; }
        IQueryable<Request> Requests { get; }
        IQueryable<Facility> Facilities { get; }
        IQueryable<Role> Roles { get; }
    }
}
