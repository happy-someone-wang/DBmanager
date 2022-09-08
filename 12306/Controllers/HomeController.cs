using _12306.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _12306.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ReturnModels.Login_Staus Result= new ReturnModels.Login_Staus();
            if(Containers._Current_User.Instance.UserID==null)
            {
                Result.IsLogin = 0;
                
            }
            else
            {
                Result.IsLogin = 1;
                Containers._User U = new Containers._User();
                ServerSqlTools.OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
                Result.Myuser = U;
            }
            return View(Result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
