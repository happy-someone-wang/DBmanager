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
        private List<string> Station = new List<string> { "", "北京", "天津", "济南", "上海", "杭州", "台北", "福州", "南昌", "长沙", "广州", "昆明", "贵阳", "武汉", "南京", "郑州", "重庆", "成都", "西安", "兰州", "天津北" };
        private List<string> Seat= new List<string> { "","商务座","特等座","一等座","二等座" };

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
            ReturnModels.OrderList Result = new ReturnModels.OrderList();
            List<_Order> Orders = new List<_Order>();
            List<string> start = new List<string>();
            List<string> end = new List<string>();
            List<string> seat = new List<string>();
            //Containers._Current_User.Instance.UserID = "330881200301030073";
            OracleSqlTools.GetOrder(Containers._Current_User.Instance.UserID, Orders, true);


            foreach (_Order x in Orders)
            {
                start.Add(Station[x.StartStNo]);
                end.Add(Station[x.EndStNo]);
                seat.Add(Seat[x.SeatLevel]);
            }
            Result.List = Orders;
            Result.Start_station = start;
            Result.End_station = end;
            Result.Seat_level = seat;

            return View(Result);
        }
        [HttpGet]
        public IActionResult t_cancel(string Order_ID)
        {
            ReturnModels.Operation_staus Result = new ReturnModels.Operation_staus();
            int t;
            t = OracleSqlTools.CancelOrder(Order_ID, Containers._Current_User.Instance.UserID,true);
            Result.IsVaild = t;
            return View(Result);
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
