using Containers;
using ServerSqlTools;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12306.Controllers
{
   
    public class TrainController : Controller
    {
        private static List<_Station> Station = new List<_Station> ();
        private static List<string> Seat_Level = new List<string> { "VIP", "EX", "first", "second" };
        public IActionResult Index()
        {
            Station.Clear();
            OracleSqlTools.GetAllStation(Station, true);
            ReturnModels.Train_Index Result = new ReturnModels.Train_Index();
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            Result.Myuser = U;
            Result.Station = Station;
            return View(Result);
        }
        [HttpGet]
        public IActionResult Buy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Buy(string start_station,string end_station,string date,string datem,string dated)
        {
            List<_TrainTicket> trainTickets = new List<_TrainTicket> { };
            string start =null;
            string end = null;
            foreach(_Station m in Station)
            {
                if(m.StationName==start_station)
                {
                    start = m.StationNo;
                }
                if(m.StationName==end_station)
                {
                    end = m.StationNo;
                }
                if(start!=null&&end!=null)
                {
                    break;
                }
            }
            OracleSqlTools.SearchTrainTicket(start, end, Convert.ToInt32(date), Convert.ToInt32(datem), Convert.ToInt32(dated), trainTickets, true);
            ReturnModels.Train_Buy_Model ReturnModel = new ReturnModels.Train_Buy_Model { };
            ReturnModel.Start_station = start_station;
            ReturnModel.End_station = end_station;
            ReturnModel.TrainTickets = trainTickets;
            ReturnModel.Station = Station;
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            ReturnModel.Myuser = U;
            for(int i=0;i<trainTickets.Count;i++)
            {
                List<_ParkingStation> Temp = trainTickets[i].Parkstations;
                for(int j=0;j<Temp.Count;j++)
                {
                    foreach (_Station m in Station)
                    {
                        if (m.StationNo == Temp[j].StationNo)
                        {
                            _ParkingStation x = Temp[j];
                            x.StationNo = m.StationName;
                            Temp[j] = x;
                            break;
                        }
                    }
                }
            }
            //return View("../Home/Index",train);
            return View(ReturnModel);
        }
        [HttpGet]
        public IActionResult reBuy(string Order_ID)
        {
            _Order O_temp = new _Order();
            if(OracleSqlTools.GetOneOrder(Order_ID,ref O_temp,true)!=-1)
            {
                return Content("Order_id error");
            }
            ReturnModels.Train_reBuy_Model ReturnModel = new ReturnModels.Train_reBuy_Model { };
            string start = null;
            string end = null;
            foreach (_Station m in Station)
            {
                if (m.StationName == O_temp.StartStNo)
                {
                    start = m.StationName;
                }
                if (m.StationName == O_temp.EndStNo)
                {
                    end = m.StationName;
                }
                if (start != null && end != null)
                {
                    break;
                }
            }
            ReturnModel.Start_station = start;
            ReturnModel.End_station = end;
            ReturnModel.Order_ID = Order_ID;
            myDate._Date temp = new myDate._Date("1900/01/01 01:00:00");
            ReturnModel.Leaving_time = temp;


            //return View("../Home/Index",train);
            return View(ReturnModel);
        }
        [HttpPost]
        public IActionResult reBuy(string Order_ID,string date, string datem, string dated)
        {
            List<_TrainTicket> trainTickets = new List<_TrainTicket> { };
            _Order O_temp = new _Order();
            if (OracleSqlTools.GetOneOrder(Order_ID, ref O_temp, true) != -1)
            {
                return Content("Order_id error");
            }
            myDate._Date leaving = new myDate._Date();
            leaving.Year = Convert.ToInt32(date);
            leaving.Month= Convert.ToInt32(datem);
            leaving.Day = Convert.ToInt32(dated);
            OracleSqlTools.SearchTrainTicket(O_temp.StartStNo, O_temp.EndStNo, leaving.Year, leaving.Month, leaving.Day, trainTickets, true);
            int old_train;
            for (old_train = 0; old_train < trainTickets.Count; old_train++)
            {
                if (trainTickets[old_train].TrainID == O_temp.TrainID)
                {
                    break;
                }
            }
            trainTickets.RemoveAt(old_train);
            ReturnModels.Train_reBuy_Model ReturnModel = new ReturnModels.Train_reBuy_Model { };
            string start = null;
            string end = null;
            foreach (_Station m in Station)
            {
                if (m.StationName == O_temp.StartStNo)
                {
                    start = m.StationNo;
                }
                if (m.StationName == O_temp.EndStNo)
                {
                    end = m.StationNo;
                }
                if (start != null && end != null)
                {
                    break;
                }
            }
            ReturnModel.Start_station = start;
            ReturnModel.End_station = end;
            leaving.Year = leaving.Year;
            leaving.Month = leaving.Month;
            leaving.Day = leaving.Day;
            ReturnModel.Leaving_time = leaving;
            ReturnModel.TrainTickets = trainTickets;
            ReturnModel.Order_ID = Order_ID;

            //return View("../Home/Index",train);
            return View(ReturnModel);
        }
        [HttpGet]
        public IActionResult Pay(string train_id,string start_station,string end_station,string date)
        {
            if(Containers._Current_User.Instance.UserID==null)
            {
                return RedirectToAction("Index", "Login");
            }
            ReturnModels.Train_Pay_Model return_model = new ReturnModels.Train_Pay_Model { };
            return_model.Start_station = start_station;
            return_model.End_station = end_station;
            return_model.Train_ID = train_id;
            foreach (_Station m in Station)
            {
                if (m.StationName == start_station)
                {
                    start_station = m.StationNo;
                }
                else if (m.StationName == end_station)
                {
                    end_station = m.StationNo;
                }
            }
            _TrainTicket ticket = new _TrainTicket();
            OracleSqlTools.SearchTrainTicket(train_id, start_station, end_station, date, ref ticket, true);
            return_model.TrainTicket = ticket;
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            return_model.Myuser = U;
            return_model.MyPassengers = new List<_Passenger>();
            OracleSqlTools.GetPassenger(Containers._Current_User.Instance.UserID, return_model.MyPassengers,true);
            return View(return_model);
        }
        public class passenger_info
        {
            private string idcard;
            private string name;
            private string seat;

            public string Idcard { get => idcard; set => idcard = value; }
            public string Name { get => name; set => name = value; }
            public string Seat { get => seat; set => seat = value; }
        }
        [HttpPost]
        public IActionResult Pay(string train_id,string start_station,string end_station,List<string> PID,List<string> seat,string date)
        {
            List<_Seat> seats = new List<_Seat> { };
            ReturnModels.Train_Result_Model Result = new ReturnModels.Train_Result_Model { };

            for(int i=0;i<PID.Count;i++)
            {
                _Seat seat_temp = new _Seat();
                string start=null;
                string end =null;
                foreach (_Station m in Station)
                {
                    if (m.StationName == start_station)
                    {
                        start = m.StationNo;
                    }
                    if (m.StationName == end_station)
                    {
                        end = m.StationNo;
                    }
                    if (start!=null && end!=null)
                    {
                        break;
                    }
                }
                if (OracleSqlTools.SearchSeat(train_id, start,end, 1+Seat_Level.IndexOf(seat[i]),0,ref seat_temp,year,month,day,true)!=-1)
                {
                    continue;
                }
                seats.Add(seat_temp);
                if (seats[i].TrainID == null)
                {
                    break;
                }
                _Order order_temp = new _Order();
                //Containers._Current_User.Instance.UserID = "330881200301030073";
                int temp = OracleSqlTools.CreateOrder(Containers._Current_User.Instance.UserID, PID[i], seats[i], ref order_temp, true);
                if (temp == -1)
                {
                    foreach (_Station m in Station)
                    {
                        if (m.StationNo == order_temp.StartStNo)
                        {
                            order_temp.StartStNo = m.StationName;
                        }
                        else if (m.StationNo == order_temp.EndStNo)
                        {
                            order_temp.EndStNo = m.StationName;
                        }
                    }
                    Result.Order_info.Add(order_temp);
                }
            }
            //return View("Result",Result);
            return View("order_result",Result);
        }
        [HttpGet]
        public IActionResult rePay(string order_id, string train_id, string start_station, string end_station,int year,int month,int day)
        {
            _Order old_order = new _Order();
            OracleSqlTools.GetOneOrder(order_id, ref old_order, true);
            _Seat new_seat = new _Seat();
            string start = null;
            string end = null;
            foreach (_Station m in Station)
            {
                if (m.StationName == start_station)
                {
                    start = m.StationNo;
                }
                if (m.StationName == end_station)
                {
                    end = m.StationNo;
                }
                if (start!=null && end!=null)
                {
                    break;
                }
            }
            if (OracleSqlTools.SearchSeat(train_id, start,end, old_order.SeatLevel, 0, ref new_seat,year,month ,day,true) != -1)
            {
                return Content("new seat notfound");
            }
            _Order new_Order = new _Order();
            int temp = OracleSqlTools.CreateOrder(Containers._Current_User.Instance.UserID, old_order.Passenger.PassengerPID, new_seat, ref new_Order, true);
            if(temp!=-1)
            {
                return Content("new order create failed");
            }
            OracleSqlTools.CancelOrder(old_order.OrderID, Containers._Current_User.Instance.UserID, true);


            ReturnModels.Train_Result_Model Result = new ReturnModels.Train_Result_Model { };
            Result.Order_info.Add(new_Order);
            Result.Passenger_name.Add(old_order.Passenger.PassengerRName);
            start = null;
            end = null;
            foreach (_Station m in Station)
            {
                if (m.StationName == new_Order.StartStNo)
                {
                    start = m.StationName;
                }
                if (m.StationName == new_Order.EndStNo)
                {
                    end = m.StationName;
                }
                if (start != null && end != null)
                {
                    break;
                }
            }
            Result.Start_station = start;
            Result.End_station = end;
            return View("order_result",Result);
        }
        [HttpGet]
        public IActionResult order_result()
        {
            return View();
        }
    }
    
}
