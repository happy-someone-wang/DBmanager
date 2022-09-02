using myDate;
using System.Collections.Generic;

namespace Containers
{
    public struct _Current_User
    {
        private string userID;

        public string UserID { get => userID; set => userID = value; }

        public static _Current_User Instance;

    }
    public struct _User
    {
        public string UserID { get; set; }
        public string UserPWD { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }
        public string UserRName { get; set; }
        public string UserGender { get; set; }
        public string UserAddr { get; set; }
        public string UserPID { get; set; }

        public _User(string ID, string PWD, string Phone, string Email, string RName, string Gender, string Addr, string PID)
        {
            this.UserID = ID;
            this.UserPWD = PWD;
            this.UserPhone = Phone;
            this.UserEmail = Email;
            this.UserRName = RName;
            this.UserGender = Gender;
            this.UserAddr = Addr;
            this.UserPID = PID;
        }

    }
    public class _Admin
    {
        private string adminID;
        private string adminPWD;

        public string AdminID { get => adminID; set => adminID = value; }
        public string AdminPWD { get => adminPWD; set => adminPWD = value; }
    }

    public struct _Station
    {
        public int StationNo { get; set; }
        public string StationName { get; set; }

        public _Station(int No, string Name)
        {
            this.StationNo = No;
            this.StationName = Name;
        }
    }

    public struct _TrainType
    {
        public string TrainType { get; set; }
        public int CargCnt { get; set; }
        public int VIPAmount { get; set; }
        public int EXAmount { get; set; }
        public int FirstAmount { get; set; }
        public int SecondAmount { get; set; }

        public _Carriage VIPInfo { get; set; }
        public _Carriage EXInfo { get; set; }
        public _Carriage FirstInfo { get; set; }
        public _Carriage SecondInfo { get; set; }

    }
    public struct _Train
    {
        public int TrainNum { get; set; }
        public string TrainType { get; set; }
        public int TrainState { get; set; }

        public _Train(int TrainNum, string TrainType, int TrainState)
        {
            this.TrainNum = TrainNum;
            this.TrainType = TrainType;
            this.TrainState = TrainState;
        }

    }

    public struct _Carriage
    {
        public string TrainType { get; set; }
        public int SeatLevel { get; set; }
        public int SeatRowCnt { get; set; }
        public int SeatColCnt { get; set; }

        public _Carriage(string TrainType, int SeatLevel, int SeatRowCnt, int SeatColCnt)
        {
            this.TrainType = TrainType;
            this.SeatLevel = SeatLevel;
            this.SeatRowCnt = SeatRowCnt;
            this.SeatColCnt = SeatColCnt;
        }
    }

    public struct _TrainParking
    {
        public string TrainID { get; set; }
        public int StationNo { get; set; }
        public _Date ArriveTime { get; set; }
        public _Date LeavingTime { get; set; }
        public int ParkingTime { get; set; }
        public int NextStNo { get; set; }

        public _TrainParking(string TrainID, int StationNo, _Date ArriveTime, _Date LeavingTime, int ParkingTime, int NextStNo)
        {
            this.TrainID = TrainID;
            this.StationNo = StationNo;
            this.ArriveTime = ArriveTime;
            this.LeavingTime = LeavingTime;
            this.ParkingTime = ParkingTime;
            this.NextStNo = NextStNo;
        }
    }

    public struct _TrainManager
    {
        public string TrainID { get; set; }
        public int TrainNo { get; set; }
        public int StartStNo { get; set; }
        public int EndStNo { get; set; }
        public int RunningTime { get; set; }
        public List<_TrainParking> Parking { get; set; }
        public _TrainManager(string TrainID, int TrainNo, int StartStNo, int EndStNo, int RunningTime, List<_TrainParking> Parking)
        {
            this.TrainID = TrainID;
            this.TrainNo = TrainNo;
            this.StartStNo = StartStNo;
            this.EndStNo = EndStNo;
            this.Parking = Parking;
            this.RunningTime = RunningTime;
        }
    }

    public struct _TrainTicket
    {
        public string TrainID { get; set; }
        public string StartStName { get; set; }
        public string EndStName { get; set; }
        public string LeavingTime { get; set; }
        public string ArriveTime { get; set; }
        public string TotalTime { get; set; }
        public int VIPAmount { get; set; }
        public int EXAmount { get; set; }
        public int FirstAmount { get; set; }
        public int SecondAmount { get; set; }

        public _TrainTicket(string TrainID, string StartStName, string EndStName, string LeavingTime, string ArriveTime, string TotalTime, int VIPAmount, int EXAmount, int FirstAmount, int SecondAmount)
        {
            this.TrainID = TrainID;
            this.StartStName = StartStName;
            this.EndStName = EndStName;
            this.LeavingTime = LeavingTime;
            this.ArriveTime = ArriveTime;
            this.TotalTime = TotalTime;
            this.VIPAmount = VIPAmount;
            this.EXAmount = EXAmount;
            this.FirstAmount = FirstAmount;
            this.SecondAmount = SecondAmount;
        }
    }

    public struct _Carriage_Seat
    {
        public int CarriageNo { get; set; }
        public string SeatInfo { get; set; }

        public int SeatRowCnt { get; set; }
        public int SeatColCnt { get; set; }

        public _Carriage_Seat(int CarriageNo, string SeatInfo, int SeatRowCnt, int SeatColCnt)
        {
            this.CarriageNo = CarriageNo;
            this.SeatInfo = SeatInfo;
            this.SeatRowCnt = SeatRowCnt;
            this.SeatColCnt = SeatColCnt;
        }
    }

    public struct _Seat
    {
        public string TrainID { get; set; }
        public int StartStNo { get; set; }
        public int EndStNo { get; set; }
        public int CarriageNo { get; set; }
        public int SeatLevel { get; set; }
        public int SeatRow { get; set; }
        public int SeatCol { get; set; }

        public _Seat(string TrainID, int StartStNo, int EndStNo, int CarriageNo, int SeatLevel, int SeatRow, int SeatCol)
        {
            this.TrainID = TrainID;
            this.StartStNo = StartStNo;
            this.EndStNo = EndStNo;
            this.CarriageNo = CarriageNo;
            this.SeatLevel = SeatLevel;
            this.SeatRow = SeatRow;
            this.SeatCol = SeatCol;
        }

    }

    public struct _Order
    {
        public string OrderID { get; set; }
        public string TrainID { get; set; }
        public int StartStNo { get; set; }
        public int EndStNo { get; set; }
        public int CarriageNo { get; set; }
        public string SeatNo { get; set; }
        public int OrderValue { get; set; }
        public string OrderCreate { get; set; }
        public int OrderState { get; set; }

        public string ArriveTime { get; set; }
        public string LeavingTime { get; set; }

    }

    public struct _Tmp_Result
    {
        public int CarriageNo { get; set; }
        public int SeatLevel { get; set; }
        public char[] Bitmap { get; set; }
    }
}

