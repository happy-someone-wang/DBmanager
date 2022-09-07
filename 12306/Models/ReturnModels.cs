using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Containers;
using myDate;

namespace ReturnModels
{
    public class Login_Staus
    {
        private int isLogin;
        private _User myuser;

        public int IsLogin { get => isLogin; set => isLogin = value; }
        public _User Myuser { get => myuser; set => myuser = value; }
    }
    public class Register
    {
        private int isVaild;

        public int IsVaild { get => isVaild; set => isVaild = value; }
    }

    public class Login
    {
        private int isVaild;

        public int IsVaild { get => isVaild; set => isVaild = value; }
    }
    public class New_PWD
    {
        private string pwd;

        public string Pwd { get => pwd; set => pwd = value; }
    }
    public class UserList
    {
        private List<_User> list;
        public List<_User> List { get => list; set => list = value; }

        // 得到包含所有已注册用户信息的list
        // 在页面中显示除密码外的所有用户信息
    }
    public class OrderList
    {
        private _User myuser;
        private List<_Order> list;
        private List<string> start_station;
        private List<string> end_station;
        private List<string> seat_level;

        public List<_Order> List { get => list; set => list = value; }
        public List<string> Start_station { get => start_station; set => start_station = value; }
        public List<string> End_station { get => end_station; set => end_station = value; }
        public List<string> Seat_level { get => seat_level; set => seat_level = value; }
        public _User Myuser { get => myuser; set => myuser = value; }
        // 得到一个_Order类型(订单编号,乘坐人,起始站,终点站,发车日期,出发时间,到达时间)的list以表格形式显示在页面中
    }
    public class TrainList
    {
        private _User myuser;
        private List<_TrainManager> list;
        private List<string> start_station;
        private List<string> end_station;
        public List<_TrainManager> List { get => list; set => list = value; }
        public List<string> Start_station { get => start_station; set => start_station = value; }
        public List<string> End_station { get => end_station; set => end_station = value; }
        public _User Myuser { get => myuser; set => myuser = value; }

        // 得到一个...类型的(列车编号,起始站,终点站,发车日期,出发时间,到达时间,剩余座位)list以表格形式显示在页面中
    }

    public class Train_Buy_Model
    {
        private _User myuser;
        private string start_station;
        private string end_station;
        private myDate._Date leaving_time;
        private List<_TrainTicket> trainTickets;
        private List<_Station> station;

        public string Start_station { get => start_station; set => start_station = value; }
        public string End_station { get => end_station; set => end_station = value; }
        public List<_TrainTicket> TrainTickets { get => trainTickets; set => trainTickets = value; }
        public _Date Leaving_time { get => leaving_time; set => leaving_time = value; }

        public _User Myuser { get => myuser; set => myuser = value; }
        public List<_Station> Station { get => station; set => station = value; }
    }

    public class Train_Pay_Model
    {
        private _User myuser;
        private string train_ID;
        private string start_station;
        private string end_station;
        private _TrainTicket trainTicket;
        private List<_Passenger> myPassengers;

        public string Train_ID { get => train_ID; set => train_ID = value; }
        public string Start_station { get => start_station; set => start_station = value; }
        public string End_station { get => end_station; set => end_station = value; }
        public List<_Passenger> MyPassengers { get => myPassengers; set => myPassengers = value; }
        public _User Myuser { get => myuser; set => myuser = value; }
        public _TrainTicket TrainTicket { get => trainTicket; set => trainTicket = value; }
    }

    public class Train_Result_Model
    {
        private _User myuser;
        private List<_Order> order_info;

        public List<_Order> Order_info { get => order_info; set => order_info = value; }
        public _User Myuser { get => myuser; set => myuser = value; }

        public Train_Result_Model()
        {
            Order_info = new List<_Order> { };
        }

    }
    public class Person_Tickets
    {
        private _User myuser;
        private List<_Order> tickets;

        public List<_Order> Tickets { get => tickets; set => tickets = value; }
        public _User Myuser { get => myuser; set => myuser = value; }
    }
    public class Train_reBuy_Model
    {
        private _User myuser;
        private string start_station;
        private string end_station;
        private myDate._Date leaving_time;
        private List<_TrainTicket> trainTickets;
        private List<_Station> station;
        private string order_ID;

        public string Start_station { get => start_station; set => start_station = value; }
        public string End_station { get => end_station; set => end_station = value; }
        public List<_TrainTicket> TrainTickets { get => trainTickets; set => trainTickets = value; }
        public _Date Leaving_time { get => leaving_time; set => leaving_time = value; }
        public string Order_ID { get => order_ID; set => order_ID = value; }
        public _User Myuser { get => myuser; set => myuser = value; }
        public List<_Station> Station { get => station; set => station = value; }
    }
    public class Person_Information
    {
        private _User myuser;
        private List<_Passenger> mypassenger;//不包括自己
        private string deal_message;

        public _User Myuser { get => myuser; set => myuser = value; }
        public List<_Passenger> Mypassenger { get => mypassenger; set => mypassenger = value; }
        public string Deal_message { get => deal_message; set => deal_message = value; }
    }
    public class Train_Index
    {
        private _User myuser;
        private List<_Station> station;
        public _User Myuser { get => myuser; set => myuser = value; }
        public List<_Station> Station { get => station; set => station = value; }
    }
    public class Person_account
    {
        private _User myuser;

        public _User Myuser { get => myuser; set => myuser = value; }
    }
}
