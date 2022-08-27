using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Containers;
using ServerSqlTools;

namespace _12306.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult agreement()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Index1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index1(Containers._User U)
        {
            int t;
            //ServerSqlTools.OracleSqlTools.resetUser();
            t = ServerSqlTools.OracleSqlTools.Register(U);
            if (t == -1)
            {
                return Content("ok");
            }
            else
            {
                return Content(t.ToString());
            }
        }

        [HttpPost]
        public ActionResult Index(string user_ID, string user_password, string user_phone_number, string user_email, string user_real_name,string user_gender,string user_address,string user_person_ID)
        {
            _User U = new _User();
            U.UserID = user_ID;
            U.UserPWD = user_password;
            U.UserPhone = user_phone_number;
            U.UserEmail = user_email;
            U.UserRName = user_real_name;
            U.UserGender = user_gender;
            U.UserPID = user_person_ID;
            U.UserAddr = user_address;
            Console.WriteLine(U);
            int t;
            //ServerSqlTools.OracleSqlTools.resetUser();
            t = ServerSqlTools.OracleSqlTools.Register(U);
            if(t==-1)
            {
                Console.WriteLine("register success");
                ReturnModels.Register result = new ReturnModels.Register();
                result.IsVaild = t;
                return View(result);
                //return RedirectToAction("Index","Login");
            }
            else
            {
                Console.WriteLine("register failed");
                ReturnModels.Register result = new ReturnModels.Register();
                result.IsVaild = t;
                return View(result);
                //return View("Index",U);
                //return Json(U);
            }
        }
    }
}
