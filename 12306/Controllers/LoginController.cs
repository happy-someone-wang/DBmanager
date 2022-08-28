using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Containers;
using ReturnModels;
using ServerSqlTools;

namespace _12306.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ChangePWD()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username,string password)
        {
            if(string.IsNullOrEmpty(username))
            {
                ViewBag.notice = "用户名不能为空！";
                return View();
            }
            if(string.IsNullOrEmpty(password))
            {
                ViewBag.notice = "密码不能为空！";
                return View();
            }
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
            t = ServerSqlTools.OracleSqlTools.Login(U);
            if (t==-1)
            {
                ViewBag.notice = "登陆成功，正在跳转";
                Console.WriteLine("success!");
                //return Json(U);
                ReturnModels.Login a = new ReturnModels.Login();
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
