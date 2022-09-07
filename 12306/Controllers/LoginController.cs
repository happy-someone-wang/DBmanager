using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Containers;
using ReturnModels;
using ServerSqlTools;
using Microsoft.AspNetCore.Http;
using Log;

namespace _12306.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Containers._Current_User.Instance.UserID = null;
            return View();
        }
        [HttpGet]
        public IActionResult ChangePWD()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ChangePWD(string UserID,string UserPhone)
        {
            ReturnModels.New_PWD Result = new ReturnModels.New_PWD { };
            string new_pwd="";
            OracleSqlTools.ResetPwd(UserID, UserPhone, ref new_pwd, true);
            Result.Pwd = new_pwd;
            return View(Result);
        }

        [HttpPost]
        public IActionResult Index(string username,string password)
        {
            _User U = new _User();
            if(username.Length==11)
            {
                U.UserPhone = username;
            }
            else 
            {
                U.UserPID = username;
            }
            U.UserPWD = password;
            int t;
            t = ServerSqlTools.OracleSqlTools.Login(U,true);
            if (t==-1)
            {
                ViewBag.notice = "登陆成功，正在跳转";
                Console.WriteLine("success!");
                ReturnModels.Login a = new ReturnModels.Login();

                Containers._Current_User.Instance.UserID = OracleSqlTools.Login_D(U, true);
                //return Json(U);
                a.IsVaild = t;
                return View(a);
                //return RedirectToAction("Index", "Train");
            }
            else
            {
                ViewBag.notice = "failed";
                ReturnModels.Login a = new ReturnModels.Login();
                a.IsVaild = t;
                return View(a);
                //return Json(U);
            }
        }

    }
}
