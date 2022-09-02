using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Containers;
using ReturnModels;
using ServerSqlTools;
using System;

namespace _12306.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username,string password)
        {

            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string  username,string password)
        {
            _Admin admin=new _Admin();
            admin.AdminID = username;
            admin.AdminPWD = password;
            int t;
            t = ServerSqlTools.OracleSqlTools.Login_Adm(admin, true);
            if (t == -1)
            {
                ViewBag.notice = "登陆成功，正在跳转";
                Console.WriteLine("success!");
                ReturnModels.Login a = new ReturnModels.Login();
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
        public IActionResult UserQuery()
        {
            ReturnModels.UserList users = new UserList();
            List<_User> list = new List<_User>();
            _User U1 = new _User();

            U1.UserID = "1";
            U1.UserPWD = "1";
            U1.UserPhone = "1";
            U1.UserEmail = "1@1.com";
            U1.UserRName = "张三";
            U1.UserGender = "男";
            U1.UserPID = "1";
            U1.UserAddr = "上海市";

            list.Add(U1);
            users.List = list;

            return View(users);
        }
        public IActionResult TrainQuery()
        {
            // 需要得到一个车次类型的list
            // （）
            return View();
        }
        public IActionResult OrderQuery()
        {
            // 需要得到订单类型的list
            // （）
            return View();
        }
    }
}
