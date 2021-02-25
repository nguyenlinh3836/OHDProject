using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OHDProject.Models;
using Microsoft.AspNetCore.Http;

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
        public IActionResult WelCome()
        {
            return View();
        }
        public IActionResult Information()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRequest(Request request)
        {
            if (ModelState.IsValid)
            {
                request.CreateTime = DateTime.Now;
                request.requestorId = HttpContext.Session.GetInt32("id").Value;
                _context.Add(request);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Request);
        }

    }
}
