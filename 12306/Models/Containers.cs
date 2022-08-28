using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Containers
{
    public class _User
    {
        [DisplayFormat]
        [Required,StringLength(maximumLength:30,MinimumLength =1)]
        public string UserID    { get; set;}
        [Required, StringLength(maximumLength: 30, MinimumLength = 1)]
        public string UserPWD   { get; set;}
        [Required, StringLength(maximumLength: 30, MinimumLength = 1)]
        public string UserPhone { get; set;}
        [Required, StringLength(maximumLength: 30, MinimumLength = 1)]
        public string UserEmail { get; set;}
        [Required, StringLength(maximumLength: 30, MinimumLength = 1)]
        public string UserRName { get; set;}

        [Required, StringLength(maximumLength: 1, MinimumLength = 1)]
        public string UserGender{ get; set;}
        [Required, StringLength(maximumLength: 30, MinimumLength = 1)]
        public string UserAddr  { get; set;}
        [Required, StringLength(maximumLength: 30, MinimumLength = 1)]
        public string UserPID   { get; set;}
        
        public _User(string ID, string PWD, string Phone, string Email, string RName, int Type, string Gender, string Addr, string PID)
        {
            this.UserID     = ID;
            this.UserPWD    = PWD;
            this.UserPhone  = Phone;
            this.UserEmail  = Email;
            this.UserRName  = RName;
            this.UserGender = Gender;
            this.UserAddr   = Addr;
            this.UserPID    = PID;
        }

        public _User()
        {
        }
    }

    public struct _Station
    {
        public int StationNo{ get; set;}
        public string StationName{ get; set;}

        public _Station(int No, string Name)
        {
            this.StationNo   = No;
            this.StationName = Name;
        }
    }
    
    public struct _TrainType
    {
        public string TrainType   { get; set;}
        public int    CargCnt     { get; set;}
        public int    VIPAmount   { get; set;}
        public int    EXAmount    { get; set;}
        public int    FirstAmount { get; set;}
        public int    SecondAmount{ get ;set;}

        public _Carriage VIPInfo   { get; set;}
        public _Carriage EXInfo    { get; set;}
        public _Carriage FirstInfo { get; set;}
        public _Carriage SecondInfo{ get; set;}

    }
    public struct _Train
    {
        public int    TrainNum    { get; set;}
        public string TrainType   { get; set;}
        public int    TrainState  { get; set;}

        public _Train(int TrainNum, string TrainType, int TrainState)
        {
            this.TrainNum     = TrainNum;
            this.TrainType    = TrainType;
            this.TrainState   = TrainState;
        }

    }

    public struct _Carriage
    {
        public string TrainType  { get; set;}
        public int    SeatLevel  { get; set;}
        public int    SeatRowCnt { get; set;}
        public int    SeatColCnt { get; set;}

        public _Carriage(string TrainType, int SeatLevel, int SeatRowCnt, int SeatColCnt)
        {
            this.TrainType   = TrainType;
            this.SeatLevel   = SeatLevel;
            this.SeatRowCnt  = SeatRowCnt;
            this.SeatColCnt  = SeatColCnt;
        }
    }

    public struct _TrainParking
    {
        public string   TrainID     { get; set;}
        public int      StationNo   { get; set;}
        public DateTime ArriveTime  { get; set;}
        public DateTime LeavingTime { get; set;}
        public int      ParkingTime { get; set;}
        public int      NextStNo    { get; set;}

        public _TrainParking(string TrainID, int StationNo, DateTime ArriveTime, DateTime LeavingTime, int ParkingTime, int NextStNo)
        {
            this.TrainID     = TrainID;
            this.StationNo   = StationNo;
            this.ArriveTime  = ArriveTime;
            this.LeavingTime = LeavingTime;
            this.ParkingTime = ParkingTime;
            this.NextStNo    = NextStNo;
        }
    }

    public struct _TrainManager
    {
        public string              TrainID     { get; set;}
        public int                 TrainNo     { get; set;}
        public int                 StartStNo   { get; set;}
        public int                 EndStNo     { get; set;}
        public int                 RunningTime { get; set;}
        public List<_TrainParking> Parking     { get; set;}
        public _TrainManager(string TrainID, int TrainNo, int StartStNo, int EndStNo, int RunningTime, List<_TrainParking> Parking)
        {
            this.TrainID     = TrainID;
            this.TrainNo     = TrainNo;
            this.StartStNo   = StartStNo;
            this.EndStNo     = EndStNo;
            this.Parking     = Parking;
            this.RunningTime = RunningTime;
        }
    }

    public struct _TrainTicket
    {
        public string  TrainID     { get; set;}
        public string  StartStName { get; set;}
        public string  EndStName   { get; set;}
        public string  LeavingTime { get; set;}
        public string  ArriveTime  { get; set;}
        public string  TotalTime   { get; set;}
        public int     VIPAmount   { get; set;}
        public int     EXAmount    { get; set;}
        public int     FirstAmount { get; set;}
        public int    SecondAmount{ get; set;}

        public _TrainTicket(string TrainID, string StartStName, string EndStName, string LeavingTime, string ArriveTime, string TotalTime, int VIPAmount, int EXAmount, int FirstAmount, int SecondAmount)
        {
            this.TrainID      = TrainID;
            this.StartStName  = StartStName;
            this.EndStName    = EndStName;
            this.LeavingTime  = LeavingTime;
            this.ArriveTime   = ArriveTime;
            this.TotalTime    = TotalTime;
            this.VIPAmount    = VIPAmount;
            this.EXAmount     = EXAmount;
            this.FirstAmount  = FirstAmount;
            this.SecondAmount = SecondAmount;
        }
    }
}