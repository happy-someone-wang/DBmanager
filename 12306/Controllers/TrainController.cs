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
            return View("Buy",ReturnModel);
        }
        public class pia
        {
            public string start;
            public string end;
            public string year;
            public string month;
            public string day;

        }
        public class fan
        {
            public string stat;
            public string endt;
            public string ccc;
            public string fir;
            public string yi;
            public string er;

        }
        public JsonResult Buym(string start, string end, string year, string month, string day)
        {
            var stp = start;
            var enp = end;
            var ret = new fan();
            ret.stat = "7:03";
            ret.endt = "9:30";
            ret.ccc = "G0000";
            ret.fir = "有";
            ret.er = "有";
            ret.yi = "有";

            var u = new { stat = "7:03", endt = "9:30", ccc = "G0000", fir = "有", er = "有", yi = "有" };
            var d = new List<Object>();
            d.Add(u);

            var p = Json(d);
            return p;
        }
        public bool Paym(string staf, string endf, string stf, string enf, string cccf, string daaf, string idcar, string namme, string zuo)
        {
            return true;
        }
        public IActionResult Pay()
        {
            return View();
        }
    }
}
