using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Containers;
using ServerSqlTools;

namespace _12306.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult center()
        {
            return View();
        }
        [HttpGet]
        public IActionResult information()
        {
            _User U_temp = new _User();
            //_Current_User.Instance.UserID = "330881200301030073";
            if(OracleSqlTools.GetUser(_Current_User.Instance.UserID, ref U_temp, true)!=-1)
            {
                return View();
            }
            if(U_temp.UserGender=="1")
            {
                U_temp.UserGender = "男";
            }
            else
            {
                U_temp.UserGender = "女";
            }
            U_temp.UserID = U_temp.UserPID;
            return View(U_temp);
        }
        [HttpPost]
        public IActionResult information(string UserPID,string UserPWD,string UserPhone,string UserRname,string UserGender,string Email,string Address)
        {
            _User U_temp = new _User();
            U_temp.UserAddr = Address;
            U_temp.UserEmail = Email;
            U_temp.UserGender = (UserGender == "男") ? ("1") : ("0");
            U_temp.UserID = Containers._Current_User.Instance.UserID;
            U_temp.UserPhone = UserPhone;
            U_temp.UserPID = UserPID;
            U_temp.UserPWD = UserPWD;
            U_temp.UserRName = UserRname;
            //_Current_User.Instance.UserID = "330881200301030073";
            int t = OracleSqlTools.UpdateUser(U_temp, true);
            ReturnModels.Operation_staus Result = new ReturnModels.Operation_staus();
            Result.IsVaild = t;
            return View("center", Result);
        }

        [HttpGet]
        public IActionResult ticket()
        {

            return View();
        }
        public IActionResult t_cancel()
        {
            return View();
        }
        [HttpGet]
        public IActionResult account()
        {
            return View();
        }

        [HttpPost]
        public IActionResult account(string newPassword)
        {
            int t = OracleSqlTools.ChgPwd(Containers._Current_User.Instance.UserID, newPassword, true);
            ReturnModels.Operation_staus Result = new ReturnModels.Operation_staus();
            Result.IsVaild = t;
            return View("center", Result);
        }
    }
}
