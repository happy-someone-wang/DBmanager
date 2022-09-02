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
        private static List<string> Station = new List<string> { "北京", "天津", "济南", "上海", "杭州", "台北", "福州", "南昌", "长沙", "广州", "昆明", "贵阳", "武汉", "南京", "郑州", "重庆", "成都", "西安", "兰州", "天津北" };
        private static List<string> Seat_Level = new List<string> { "VIP", "EX", "first", "second" };
        public IActionResult Index()
        {
            return View();
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
            int start = 1+Station.IndexOf(start_station);
            int end = 1+Station.IndexOf(end_station);
            OracleSqlTools.SearchTrain(start, end, Convert.ToInt32(date), Convert.ToInt32(datem), Convert.ToInt32(dated), trainTickets, true);
            ReturnModels.Train_Buy_Model ReturnModel = new ReturnModels.Train_Buy_Model { };
            ReturnModel.Start_station = start_station;
            ReturnModel.End_station = end_station;
            myDate._Date leaving_time = new myDate._Date();
            leaving_time.Year = Convert.ToInt32(date);
            leaving_time.Month = Convert.ToInt32(datem);
            leaving_time.Day = Convert.ToInt32(dated);
            ReturnModel.Leaving_time = leaving_time;
            ReturnModel.TrainTickets = trainTickets;

            //return View("../Home/Index",train);
            return View(ReturnModel);
        }
        [HttpPost]
        public IActionResult reBuy(string Order_ID,string start_station, string end_station, string date, string datem, string dated)
        {
            List<_TrainTicket> trainTickets = new List<_TrainTicket> { };
            int start = 1 + Station.IndexOf(start_station);
            int end = 1 + Station.IndexOf(end_station);
            OracleSqlTools.SearchTrain(start, end, Convert.ToInt32(date), Convert.ToInt32(datem), Convert.ToInt32(dated), trainTickets, true);
            ReturnModels.Train_reBuy_Model ReturnModel = new ReturnModels.Train_reBuy_Model { };
            ReturnModel.Start_station = start_station;
            ReturnModel.End_station = end_station;
            myDate._Date leaving_time = new myDate._Date();
            leaving_time.Year = Convert.ToInt32(date);
            leaving_time.Month = Convert.ToInt32(datem);
            leaving_time.Day = Convert.ToInt32(dated);
            ReturnModel.Leaving_time = leaving_time;
            ReturnModel.TrainTickets = trainTickets;
            ReturnModel.Order_ID = Order_ID;

            //return View("../Home/Index",train);
            return View(ReturnModel);
        }
        [HttpGet]
        public IActionResult Pay(string train_id,string start_station,string end_station,string leaving_time,string arrive_time)
        {
            ReturnModels.Train_Pay_Model return_model = new ReturnModels.Train_Pay_Model { };
            return_model.Start_station = start_station;
            return_model.End_station = end_station;
            return_model.Train_ID = train_id;
            return_model.Leaving_time = new myDate._Date( leaving_time);
            return_model.Arrive_time = new myDate._Date(arrive_time);
            return View(return_model);
        }
        public class passenger_info
        {
            string idcard;
            string name;
            string seat;

            public string Idcard { get => idcard; set => idcard = value; }
            public string Name { get => name; set => name = value; }
            public string Seat { get => seat; set => seat = value; }
        }
        [HttpPost]
        public IActionResult Pay(string train_id,string start_station,string end_station,List<string> idcard,string payway, List<string> name, List<string> seat)
        {
            List<_Seat> seats = new List<_Seat> { };
            ReturnModels.Train_Result_Model Result = new ReturnModels.Train_Result_Model { };

            for(int i=0;i<idcard.Count;i++)
            {
                _Seat seat_temp = new _Seat();
                if(OracleSqlTools.SearchSeat(train_id, 1+Station.IndexOf(start_station), 1+Station.IndexOf(end_station), 1+Seat_Level.IndexOf(seat[i]), 0, ref seat_temp, true)!=-1)
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
                int temp = OracleSqlTools.CreateOrder(Containers._Current_User.Instance.UserID, idcard[i], seats[i], ref order_temp, true);
                if (temp == -1)
                {
                    Result.Order_info.Add(order_temp);
                }
            }
            Result.Start_station = start_station;
            Result.End_station = end_station;
            Result.Passenger_name = name;

            //return View("Result",Result);
            return View("order_result",Result);
        }
    }
}
