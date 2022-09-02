using System;
using System.IO;

namespace Log
{
    class Constants
    {
        public const string LogPath = ".\\log";
        public static readonly string[] LogOP = new string[3] { "LOGIN", "REGISTER", "ORDER" };
        public static readonly string[] OrderOP = new string[2] { "CREATE", "CANCEL" };

        public enum LogType
        {
            LOGIN,
            REGISTER,
            ORDER
        }

        public enum OrderType
        {
            CREATE,
            Cancel
        }
    }
    class MyLogger
    {
        static int LoggerType;
        static string LoggerDate = "";
        static string LoggerState = "";
        //[Time] [OP] [OPINFO]
        //[STATE] [STATEINFO]
        static string OPInfo = "";
        static string LoggerTime = "";
        static string StateInfo = "";
        public static void LogLogin(string UserID, int State, string Info)
        {
            LoggerType = (int)Constants.LogType.LOGIN;
            LoggerTime = DateTime.Now.ToString();
            if (State == 1)
            {
                LoggerState = "Success";
            }
            else
            {
                LoggerState = "Failure";
            }
            GetLoggerDate(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            OPInfo = "User(UID = " + UserID + ") try to Login 12306";
            StateInfo = Info;
            string LogStr1 = "[" + LoggerTime + "] [" + Constants.LogOP[LoggerType] + "] " + OPInfo;
            string LogStr2 = "[" + LoggerState + "] " + " " + StateInfo;
            WriteLog(LogStr1, LogStr2);
        }

        public static void LogRegister(string UserPID, int State, string Info)
        {
            LoggerType = (int)Constants.LogType.REGISTER;
            LoggerTime = DateTime.Now.ToString();
            if (State == 1)
            {
                LoggerState = "Success";
            }
            else
            {
                LoggerState = "Failure";
            }
            GetLoggerDate(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            OPInfo = "User(PID = " + UserPID + ") try to Register 12306";
            StateInfo = Info;
            string LogStr1 = "[" + LoggerTime + "] [" + Constants.LogOP[LoggerType] + "] " + OPInfo;
            string LogStr2 = "[" + LoggerState + "] " + " " + StateInfo;
             WriteLog(LogStr1, LogStr2);
        }

        public static void LogOrder(string UserID, string OrderID, string TrainID, int OP, int State, string Info)
        {
            LoggerType = (int)Constants.LogType.ORDER;
            LoggerTime = DateTime.Now.ToString();
            if (State == 1)
            {
                LoggerState = "Success";
            }
            else
            {
                LoggerState = "Failure";
            }
            GetLoggerDate(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (OP == (int)Constants.OrderType.CREATE)
            {
                OPInfo = "User(PID = " + UserID + ") try to Create Order(OID = " + OrderID + ",TID = " + TrainID + ")";
            }
            else
            {
                OPInfo = "User(PID = " + UserID + ") try to Cancel Order(OID = " + OrderID + ",TID = " + TrainID + ")";
            }
            StateInfo = Info;
            string LogStr1 = "[" + LoggerTime + "] [" + Constants.LogOP[LoggerType] + "] [" + Constants.OrderOP[OP] + "] " + OPInfo;
            string LogStr2 = "[" + LoggerState + "] " + " " + StateInfo;
            WriteLog(LogStr1, LogStr2);
        }

        static void GetLoggerDate(int Year, int Month, int Day)
        {
            LoggerDate = Year.ToString();
            LoggerDate += "-";
            if (Month < 10)
            {
                LoggerDate += "0";
            }
            LoggerDate += Month.ToString();
            LoggerDate += "-";
            if (Day < 10)
            {
                LoggerDate += "0";
            }
            LoggerDate += Day.ToString();
        }

        public static void WriteLog(string str1, string str2)
        {   
            Console.WriteLine(Constants.LogPath + "\\" + LoggerDate);
            string FilePath = Constants.LogPath + "\\" + LoggerDate + "\\" + Constants.LogOP[LoggerType];
            StreamWriter sw = File.AppendText(FilePath);
            sw.WriteLine(str1);
            sw.WriteLine(str2);
            sw.Close();
        }

        public static void InitLog()
        {
            GetLoggerDate(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (!Directory.Exists(Constants.LogPath))
            {
                Directory.CreateDirectory(Constants.LogPath);
            }

            string DirectoryPath = Constants.LogPath + "\\" + LoggerDate;
            Console.WriteLine(DirectoryPath);
            if (!Directory.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
                string FilePathLogin = DirectoryPath + "\\" + "LOGIN";
                string FilePathRegister = DirectoryPath + "\\" + "REGISTER";
                string FilePathOrder = DirectoryPath + "\\" + "ORDER";
                File.Create(FilePathLogin);
                File.Create(FilePathOrder);
                File.Create(FilePathRegister);
                
            }
        }

    }
}