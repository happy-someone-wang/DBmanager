using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Containers;
using ReturnModels;
using ServerSqlTools;
using System;
using Crypto;

namespace _12306.Controllers
{
    public class AdminController : Controller
    {
        private static List<_Station> Station = new List<_Station>();
        [HttpGet]
        public IActionResult Index()
        {
            Station.Clear();
            OracleSqlTools.GetAllStation(Station, true);
            return View();
        }
        [HttpPost]
        public IActionResult Index(string  username,string password)
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
        [HttpGet]
        public IActionResult UserQuery()
        {
            ReturnModels.UserList users = new UserList();
            List<_User> list = new List<_User>();
            //_User U1 = new _User();
            OracleSqlTools.GetAllUser(list, true);
            
            //U1.UserID = "1";
            //U1.UserPWD = "1";
            //U1.UserPhone = "1";
            //U1.UserEmail = "1@1.com";
            //U1.UserRName = "张三";
            //U1.UserGender = "男";
            //U1.UserPID = "1";
            //U1.UserAddr = "上海市";

            //list.Add(U1);
            users.List = list;

            return View(users);
        }
        [HttpPost]
        public IActionResult UserQuery(string ID)
        {
            ReturnModels.UserList users = new UserList();
            List<_User> list = new List<_User>();
            _User U1 = new _User();
            string EnID = MyCrypto.Encrypt(ID);
            OracleSqlTools.GetUser(EnID,ref U1,true);

            if (U1.UserGender == "1")
            {
                U1.UserGender = "男";
            }
            else
            {
                U1.UserGender = "女";
            }
            //U1.UserID = "1";
            //U1.UserPWD = "1";
            //U1.UserPhone = "1";
            //U1.UserEmail = "1@1.com";
            //U1.UserRName = "张三";
            //U1.UserGender = "男";
            //U1.UserPID = "1";
            //U1.UserAddr = "上海市";

            list.Add(U1);
            users.List = list;

            return View(users);
        }
        [HttpGet]
        public IActionResult TrainQuery()
        {
            ReturnModels.TrainList trains = new TrainList();
            List<_TrainManager> list = new List<_TrainManager>();
            List<string> start = new List<string>();
            List<string> end = new List<string>();
            //_User U1 = new _User();
            OracleSqlTools.GetAllTrain(list, true);
            foreach (_TrainManager x in list)
            {
                string StartSt = null;
                string EndSt = null;
                foreach(_Station m in Station)
                {
                    if(m.StationName == x.StartStNo)
                    {
                        StartSt = m.StationName;
                    }
                    if (m.StationName == x.EndStNo)
                    {
                        EndSt = m.StationName;
                    }
                    if (start != null && end != null)
                    {
                        break;
                    }
                }
                start.Add(StartSt);
                end.Add(EndSt);
            }

            //U1.UserID = "1";
            //U1.UserPWD = "1";
            //U1.UserPhone = "1";
            //U1.UserEmail = "1@1.com";
            //U1.UserRName = "张三";
            //U1.UserGender = "男";
            //U1.UserPID = "1";
            //U1.UserAddr = "上海市";

            //list.Add(U1);
            trains.List = list;
            trains.Start_station = start;
            trains.End_station = end;

            return View(trains);
        }
        [HttpPost]
        public IActionResult TrainQuery(string TrainID)
        {
            ReturnModels.TrainList trains = new TrainList();
            List<_TrainManager> list = new List<_TrainManager>();
            List<string> start = new List<string>();
            List<string> end = new List<string>();
            _TrainManager T = new _TrainManager();
            OracleSqlTools.GetOneTrain(TrainID, ref T, true);

            list.Add(T);
            foreach (_TrainManager x in list)
            {
                string StartSt = null;
                string EndSt = null;
                foreach (_Station m in Station)
                {
                    if (m.StationName == x.StartStNo)
                    {
                        StartSt = m.StationName;
                    }
                    if (m.StationName == x.EndStNo)
                    {
                        EndSt = m.StationName;
                    }
                    if (start != null && end != null)
                    {
                        break;
                    }
                }
                start.Add(EndSt);
                end.Add(StartSt);
            }

            //U1.UserID = "1";
            //U1.UserPWD = "1";
            //U1.UserPhone = "1";
            //U1.UserEmail = "1@1.com";
            //U1.UserRName = "张三";
            //U1.UserGender = "男";
            //U1.UserPID = "1";
            //U1.UserAddr = "上海市";

            trains.List = list;
            trains.Start_station = start;
            trains.End_station = end;

            return View(trains);
        }
        [HttpGet]
        public IActionResult OrderQuery()
        {
            ReturnModels.OrderList orders = new OrderList();
            List<_Order> list = new List<_Order>();
            List<string> start = new List<string>();
            List<string> end = new List<string>();
            //_User U1 = new _User();
            OracleSqlTools.GetAllOrder(list, true);
            foreach(_Order x in list)
            {
                string StartSt = null;
                string EndSt = null;
                foreach (_Station m in Station)
                {
                    if (m.StationName == x.StartStNo)
                    {
                        StartSt = m.StationName;
                    }
                    if (m.StationName == x.EndStNo)
                    {
                        EndSt = m.StationName;
                    }
                    if (start != null && end != null)
                    {
                        break;
                    }
                }
                start.Add(EndSt);
                end.Add(StartSt);
            }

            //U1.UserID = "1";
            //U1.UserPWD = "1";
            //U1.UserPhone = "1";
            //U1.UserEmail = "1@1.com";
            //U1.UserRName = "张三";
            //U1.UserGender = "男";
            //U1.UserPID = "1";
            //U1.UserAddr = "上海市";

            //list.Add(U1);
            orders.List = list;
            orders.Start_station = start;
            orders.End_station = end;

            return View(orders);
        }
        [HttpPost]
        public IActionResult OrderQuery(string OrderID)
        {
            ReturnModels.OrderList orders = new OrderList();
            List<_Order> list = new List<_Order>();
            List<string> start = new List<string>();
            List<string> end = new List<string>();
            _Order O1 = new _Order();
            OracleSqlTools.GetOneOrder(OrderID, ref O1, true);

            list.Add(O1);
            foreach (_Order x in list)
            {
                string StartSt = null;
                string EndSt = null;
                foreach (_Station m in Station)
                {
                    if (m.StationName == x.StartStNo)
                    {
                        StartSt = m.StationName;
                    }
                    if (m.StationName == x.EndStNo)
                    {
                        EndSt = m.StationName;
                    }
                    if (start != null && end != null)
                    {
                        break;
                    }
                }
                start.Add(EndSt);
                end.Add(StartSt);
            }

            //U1.UserID = "1";
            //U1.UserPWD = "1";
            //U1.UserPhone = "1";
            //U1.UserEmail = "1@1.com";
            //U1.UserRName = "张三";
            //U1.UserGender = "男";
            //U1.UserPID = "1";
            //U1.UserAddr = "上海市";

            orders.List = list;
            orders.Start_station = start;
            orders.End_station = end;

            return View(orders);
        }
    }
}
