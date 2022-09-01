using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12306.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult center()
        {
            return View();
        }
        public IActionResult information()
        {
            return View();
        }
        public IActionResult ticket()
        {
            return View();
        }
        public IActionResult t_cancel()
        {
            return View();
        }
    }
}
