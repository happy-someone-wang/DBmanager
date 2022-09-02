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
                return Json(U_temp);
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
        [HttpGet]
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
