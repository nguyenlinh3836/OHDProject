using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OHDProject.Models;

namespace OHDProject.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListRequests()
        {
            using (OHDDbContext db = new OHDDbContext())
            {
                List<Request> _requests = db.Requests.ToList();
                List<Facility> _facilities = db.Facilities.ToList();
                List<Account> _accounts = db.Accounts.ToList();

                var listRequests =  from r in _requests
                                    join f in _facilities on r.FacilityId equals f.FacilityId into table1
                                    from f in table1.ToList()
                                    join a in _accounts on r.requestorId equals a.AccountId into table2
                                    from a in table2.ToList()
                                    select new ViewModel1
                                    {
                                        _requests = r,
                                        _facilities = f,
                                        _accounts = a
                                    };
                return View(listRequests);
            }
        }

        public ActionResult ListAccounts()
        {
            using (OHDDbContext db = new OHDDbContext())
            {
                List<Account> _accounts = db.Accounts.ToList();
                List<Role> _roles = db.Roles.ToList();
                List<Facility> _facilities = db.Facilities.ToList();

                var listAccounts = from a in _accounts
                                   join r in _roles on a.RoleID equals r.RoleId into table1
                                   from r in table1.ToList()
                                   join f in _facilities on a.FacilityId equals f.FacilityId into table2
                                   from f in table2.ToList()
                                   select new ViewModel1
                                  {
                                      _accounts = a,
                                      _roles = r,
                                      _facilities = f
                                  };
                return View(listAccounts);
            }
        }
    }
}
