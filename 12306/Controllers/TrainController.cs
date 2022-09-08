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
            ReturnModel.Month = Convert.ToInt32(datem);
            ReturnModel.Day = Convert.ToInt32(dated);
            ReturnModel.Year = Convert.ToInt32(date);
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
            Station.Clear();
            OracleSqlTools.GetAllStation(Station, true);
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
                if (m.StationNo == O_temp.StartStNo)
                {
                    start = m.StationName;
                }
                if (m.StationNo == O_temp.EndStNo)
                {
                    end = m.StationName;
                }
                if (start != null && end != null)
                {
                    break;
                }
            }
            O_temp.StartStNo = start;
            O_temp.EndStNo = end;
            ReturnModel.Old_Order = O_temp;
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            ReturnModel.Myuser = U;
            ReturnModel.Station = Station;
            ReturnModel.TrainTickets = null;
            ReturnModel.Deal_message = "Please input new date to search your train";
            //return View("../Home/Index",train);
            return View(ReturnModel);
        }
        [HttpPost]
        public IActionResult reBuy(string Order_ID,string date, string datem, string dated)
        {
            ReturnModels.Train_reBuy_Model ReturnModel = new ReturnModels.Train_reBuy_Model();
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
                if (trainTickets[old_train].TrainID == O_temp.TrainID && trainTickets[old_train].TrainDate == O_temp.TrainDate)//已修改
                {
                    trainTickets.RemoveAt(old_train);
                }
                for (int j=0; j < trainTickets[old_train].Parkstations.Count;j++)
                    {
                    foreach (_Station m in Station)
                    {
                        if (m.StationNo == trainTickets[old_train].Parkstations[j].StationNo)
                        {
                            _ParkingStation temp = trainTickets[old_train].Parkstations[j];
                            temp.StationNo = m.StationName;
                            trainTickets[old_train].Parkstations[j] = temp;
                        }
                    }
                }
            }
            string start = null;
            string end = null;
            foreach (_Station m in Station)
            {
                if (m.StationNo == O_temp.StartStNo)
                {
                    start = m.StationName;
                }
                if (m.StationNo == O_temp.EndStNo)
                {
                    end = m.StationName;
                }
                if (start != null && end != null)
                {
                    break;
                }
            }
            O_temp.StartStNo = start;
            O_temp.EndStNo = end;
            ReturnModel.Old_Order = O_temp;
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            ReturnModel.Myuser = U;
            ReturnModel.Station = Station;
            ReturnModel.TrainTickets = trainTickets;
            ReturnModel.Month = Convert.ToInt32(datem);
            ReturnModel.Day = Convert.ToInt32(dated);
            ReturnModel.Year = Convert.ToInt32(date);

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
            int j = 0;
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
                while (seat[j] == "zero")
                {
                    j++;
                }
                if (OracleSqlTools.SearchSeat(train_id, start,end, 1+Seat_Level.IndexOf(seat[j]),0,ref seat_temp,date,true)!=-1)
                {
                    continue;
                }
                j++;
                seats.Add(seat_temp);
                if (seats[i].TrainID == null)
                {
                    break;
                }
                _Order order_temp = new _Order();
                //Containers._Current_User.Instance.UserID = "330881200301030073";
                
                int temp = OracleSqlTools.CreateOrder(Containers._Current_User.Instance.UserID, PID[i], seats[i], ref order_temp, true);
                _Passenger P = new _Passenger();
                OracleSqlTools.GetOnePassenger(Containers._Current_User.Instance.UserID, PID[i],ref P, true);
                order_temp.Passenger = P;
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
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            Result.Myuser = U;
            //return View("Result",Result);
            return View("order_result",Result);
        }
        [HttpGet]
        public IActionResult rePay(string order_id, string train_id, string start_station, string end_station,string date)
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
            if (OracleSqlTools.SearchSeat(train_id, start,end, old_order.SeatLevel, 0, ref new_seat,date,true) != -1)
            {
                return Content("new seat notfound");
            }
            _Order new_Order = new _Order();
            _Passenger P = new _Passenger();
            OracleSqlTools.GetPassenger(old_order.OrderID, ref P, true);
            old_order.Passenger = P;
            int temp = OracleSqlTools.CreateOrder(Containers._Current_User.Instance.UserID, old_order.Passenger.PassengerPID, new_seat, ref new_Order, true);
            if(temp!=-1)
            {
                return Content("new order create failed");
            }
            OracleSqlTools.CancelOrder(old_order.OrderID, Containers._Current_User.Instance.UserID, true);


            ReturnModels.Train_Result_Model Result = new ReturnModels.Train_Result_Model();
            _User U = new _User();
            OracleSqlTools.GetUser(Containers._Current_User.Instance.UserID, ref U, true);
            Result.Myuser = U;

            //Result.Passenger_name.Add(old_order.Passenger.PassengerRName);
            start = null;
            end = null;
            foreach (_Station m in Station)
            {
                if (m.StationNo == new_Order.StartStNo)
                {
                    start = m.StationName;
                }
                if (m.StationNo == new_Order.EndStNo)
                {
                    end = m.StationName;
                }
                if (start != null && end != null)
                {
                    break;
                }
            }
            new_Order.StartStNo = start;
            new_Order.EndStNo = end;
            OracleSqlTools.GetOnePassenger(Containers._Current_User.Instance.UserID,P.PassengerPID , ref P, true);
            new_Order.Passenger = P;
            Result.Order_info.Add(new_Order);
            if(new_Order.OrderValue>old_order.OrderValue)
            {
                Result.Deal_message = "Still need ot pay " + (new_Order.OrderValue - old_order.OrderValue) + " RMB";
            }
            else
            {
                Result.Deal_message = "Refund amount " + (old_order.OrderValue - new_Order.OrderValue) + " RMB";
            }
            //Result.Start_station = start;
            //Result.End_station = end;
            return View("order_result",Result);
        }
    }
    
}
