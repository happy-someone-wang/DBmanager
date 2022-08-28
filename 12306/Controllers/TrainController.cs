using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12306.Controllers
{
    public class TrainController : Controller
    {
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
        public IActionResult Buy(string 始发站,string 终点站,string date,string datem,string dated)
        {
            pia train = new pia();
            train.start = 始发站;
            train.end = 终点站;
            train.year = date;
            train.month = datem;
            train.day = dated;
            //return View("../Home/Index",train);
            return View("Buy");
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
