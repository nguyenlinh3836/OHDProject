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
        public async Task<IActionResult> ListAssignee()
        {
            var List = await _context.Accounts.Where(p => p.RoleID == 3).ToListAsync();
            return View(List);
        }
    }
}
