using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHDProject.Models.ViewModel
{
    public class UserViewModel
    {
        public IEnumerable<Facility> Facilities { get; set; }
        public IEnumerable<Request> Requests { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
        public IEnumerable<Role> Roles { get; set; }
        public PageInfo PageInfo { get; set; }
        public string CurrentGenre { get; set; }
    }
}
