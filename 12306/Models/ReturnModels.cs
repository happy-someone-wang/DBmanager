using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Containers;
using myDate;

namespace ReturnModels
{
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
    public class UserList
    {
        public List<_User> list;
        public List<_User> List { get => list; set => list = value; }

        // 得到包含所有已注册用户信息的list
        // 在页面中显示除密码外的所有用户信息
    }
    public class OrderList
    {
         public List<_Order> list;

         public List<_Order> List { get => list; set => list = value; }
        // 得到一个_Order类型(订单编号,乘坐人,起始站,终点站,发车日期,出发时间,到达时间)的list以表格形式显示在页面中
    }
    public class TrainList
    {
        // public List<...> list;

        // public List<...> List { get => list; set => list = value; }

        // 剩余座位数 = 总座位数(VIPAmout+EXAmount+FirstAmount+SecondAmount) - 已售出票数(?)
        // 得到一个...类型的(列车编号,起始站,终点站,发车日期,出发时间,到达时间,剩余座位)list以表格形式显示在页面中
    }

    public class Train_Buy_Model
    {
        private string start_station;
        private string end_station;
        private myDate._Date leaving_time;
        private List<_TrainTicket> trainTickets;

        public string Start_station { get => start_station; set => start_station = value; }
        public string End_station { get => end_station; set => end_station = value; }
        public List<_TrainTicket> TrainTickets { get => trainTickets; set => trainTickets = value; }
        public _Date Leaving_time { get => leaving_time; set => leaving_time = value; }
    }

}
