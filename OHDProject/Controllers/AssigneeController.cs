﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OHDProject.Controllers
{
    public class AssigneeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
