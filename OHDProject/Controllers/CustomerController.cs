using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using OHDProject.Models;



namespace OHDProject.Controllers
{
    public class CustomerController : Controller
    {
        private OHDDbContext _context;
        private IRepository repository;
        public CustomerController(OHDDbContext ctx)
        {
            _context = ctx;
        }
        public CustomerController(IRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            var List = _context.Facilities.ToList();
            return View(List);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRequest(Request request,Account account,Facility facility)
        {
            if (ModelState.IsValid)
            {
                request.CreateTime = DateTime.Now;
                _context.Add(request);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Request);
        }


    }
}
