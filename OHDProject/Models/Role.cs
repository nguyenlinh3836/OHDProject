using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHDProject.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public int RoleName { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
