using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OHDProject.Models;

namespace OHDProject.Controllers
{
    public class CustomerController : Controller
    {
        private OHDDbContext _context;
        public CustomerController(OHDDbContext ctx)
        {
            _context = ctx;
        }
        public IActionResult Index()
        {
            var List = _context.Facilities.ToList();
            return View(List);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRequest([Bind("RequestId,Subject,Detail,CreateTime,FacilityId,requestorId")] Request request,Account account,Facility facility)
        {
            if (ModelState.IsValid)
            {
                request.CreateTime = DateTime.Now;
                request.requestorId = account.AccountId;
                request.FacilityId = facility.FacilityId;
                _context.Add(request);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Request);
        }


    }
}
