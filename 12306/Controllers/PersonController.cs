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
        private static List<_Station> Station = new List<_Station>();
        private List<string> Seat= new List<string> { "","商务座","特等座","一等座","二等座" };

        [HttpGet]
        public IActionResult information()
        {
            ReturnModels.Person_Information Result = new ReturnModels.Person_Information();
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            Result.Myuser = U;
            Result.Mypassenger = new List<_Passenger>();
            OracleSqlTools.GetPassenger(Containers._Current_User.Instance.UserID, Result.Mypassenger, true);
            _User U_temp = Result.Myuser;
            if(U_temp.UserGender=="1")
            {
                U_temp.UserGender = "男";
            }
            else
            {
                U_temp.UserGender = "女";
            }
            Result.Myuser = U_temp;
            return View(Result);
        }
        [HttpPost]
        public IActionResult information(string email,string address)
        {
            ReturnModels.Person_Information Result = new ReturnModels.Person_Information();
            _User U_temp = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U_temp, true);
            Result.Mypassenger = new List<_Passenger>();
            OracleSqlTools.GetPassenger(Containers._Current_User.Instance.UserID, Result.Mypassenger, true);
            U_temp.UserEmail = email;
            U_temp.UserAddr = address;
            //_Current_User.Instance.UserID = "330881200301030073";
            int t = OracleSqlTools.UpdateUser(U_temp, true);
            if (U_temp.UserGender == "1")
            {
                U_temp.UserGender = "男";
            }
            else
            {
                U_temp.UserGender = "女";
            }
            Result.Myuser = U_temp;
            if(t!=-1)
            {
                Result.Deal_message = "modify failed";
            }
            else
            {
                Result.Deal_message = "modify success";
            }
            return View(Result);
        }

        [HttpGet]
        public IActionResult ticket()
        {
            Station.Clear();
            OracleSqlTools.GetAllStation(Station, true);
            ReturnModels.Person_Tickets Result = new ReturnModels.Person_Tickets();
            Result.Seat_level = new List<string>();
            List<_Order> Orders = new List<_Order>();
            Result.Tickets = new List<_Order>();
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            Result.Myuser = U;
            OracleSqlTools.GetOrder(Containers._Current_User.Instance.UserID, Orders, true);
            for (int i=0;i<Orders.Count;i++)
            {
                _Order O = Orders[i];
                string startSt = null;
                string endSt = null;
                foreach (_Station m in Station)
                {
                    if (m.StationNo == Orders[i].StartStNo)
                    {
                        startSt = m.StationName;
                    }
                    if (m.StationNo == Orders[i].EndStNo)
                    {
                        endSt = m.StationName;
                    }
                    if (startSt != null && endSt != null)
                    {
                        break;
                    }
                }
                O.StartStNo = startSt;
                O.EndStNo = endSt;
                _Passenger P = new _Passenger();
                OracleSqlTools.GetPassenger(O.OrderID, ref P, true);
                //P.PassengerPID = Crypto.MyCrypto.Encrypt(P.PassengerPID);
                O.Passenger = P;
                O.OrderCreate = OracleSqlTools.GetTime(O.OrderCreate);
                if(O.Passenger.PassengerRName==null)
                {
                    _Passenger temp = O.Passenger;
                    temp.PassengerRName = U.UserRName;
                    O.Passenger = temp;
                }
                Result.Tickets.Add(O);
                Result.Seat_level.Add(Seat[O.SeatLevel]);
            }


            return View(Result);
        }
        [HttpGet]
        public IActionResult t_cancel(string Order_ID)
        {
            ReturnModels.Login_Staus Result = new ReturnModels.Login_Staus();
            int t;
            t = OracleSqlTools.CancelOrder(Order_ID, Containers._Current_User.Instance.UserID,true);
            Result.IsLogin = t;
            return View(Result);
        }
        [HttpGet]
        public IActionResult account()
        {
            ReturnModels.Person_account Result = new ReturnModels.Person_account();
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            Result.Myuser = U;
            return View(Result);
        }

        [HttpPost]
        public IActionResult account(string oldPassword,string newPassword)
        {
            int t = OracleSqlTools.ChangePWD(Containers._Current_User.Instance.UserID,oldPassword, newPassword, true);
            ReturnModels.Person_account Result = new ReturnModels.Person_account();
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            Result.Myuser = U;
            if(t==-1)
            {
                Result.Deal_message = "Password modify success";
            }
            else
            {
                Result.Deal_message = "Password modify failed";
            }
            return View(Result);
        }
        public IActionResult addPassenger(string pID,string pName)
        {
            ReturnModels.Person_Information Result = new ReturnModels.Person_Information();
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            if (U.UserGender == "1")
            {
                U.UserGender = "男";
            }
            else
            {
                U.UserGender = "女";
            }
            Result.Myuser = U;
            _Passenger P = new _Passenger();
            P.PassengerPID = pID;
            P.PassengerRName = pName;
            P.UserID = Containers._Current_User.Instance.UserID;
            int t=OracleSqlTools.AddPassenger(P, true);
            if(t!=-1)
            {
                Result.Deal_message = "Add Passenger failed";
            }
            else
            {
                Result.Deal_message = "Add Passenger success";
            }
            Result.Mypassenger = new List<_Passenger>();
            OracleSqlTools.GetPassenger(Containers._Current_User.Instance.UserID, Result.Mypassenger, true);
            return View("information",Result);
        }
        public IActionResult deletePassenger(string PassengerName, string PassengerPID)
        {
            ReturnModels.Person_Information Result = new ReturnModels.Person_Information();
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            if (U.UserGender == "1")
            {
                U.UserGender = "男";
            }
            else
            {
                U.UserGender = "女";
            }
            Result.Myuser = U;
            int t=OracleSqlTools.DeletePassenger(Containers._Current_User.Instance.UserID, PassengerPID);
            if(t!=-1)
            {
                Result.Deal_message = "Unfinished Order exists,modify failed";
            }
            else
            {
                Result.Deal_message = "Passenger modify success";
            }
            Result.Mypassenger = new List<_Passenger>();
            OracleSqlTools.GetPassenger(Containers._Current_User.Instance.UserID, Result.Mypassenger, true);
            return View("information",Result);
        }
    }
}
