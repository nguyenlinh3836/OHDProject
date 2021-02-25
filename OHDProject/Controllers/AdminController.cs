using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OHDProject.Models;

namespace OHDProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly OHDDbContext _context;
        public AdminController(OHDDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public ActionResult AssignRequest()
        {
            using (OHDDbContext db = new OHDDbContext())
            {
                List<Request> _requests = db.Requests.ToList();
                List<Facility> _facilities = db.Facilities.ToList();

                var listRequests = from r in _requests
                                   join f in _facilities on r.FacilityId equals f.FacilityId into table1
                                   from f in table1.ToList()
                                   select new ViewModel1
                                   {
                                       _requests = r,
                                       _facilities = f
                                   };
                return View(listRequests);
            }
        }
        public async Task<IActionResult> ListAccount()
        {
            return View(await _context.Accounts.ToListAsync());
        }
        public async Task<IActionResult> DetailAccount(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.AccountId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }
        public async Task<IActionResult> ListAssignee()
        {
            var List = await _context.Accounts.Where(p => p.RoleID == 3).ToListAsync();
            return View(List);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.AccountId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var role = await _context.Accounts.FindAsync(id);
            _context.Accounts.Remove(role);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListAccount));
        }
    }
}
