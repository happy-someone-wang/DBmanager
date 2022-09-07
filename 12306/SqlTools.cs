using System.Data.Odbc;
using myDate;
using Containers;
using Error;
using Check;
using Crypto;
using System.Collections.Generic;
using System;
using System.Linq;
using Log;

namespace ServerSqlTools
{
    class OracleSqlTools
    {
        public static OdbcConnection? conn;

        

        /*static void Main(string[] args)
{
   //Reset("Delete T_TRAIN_PARKING_CARRIAGE_INFO");
   //Reset("Delete T_TRAIN_PARKING_INFO;");
   //Reset("Delete from T_TRAIN_MANAGE_INFO;");
   //Reset("Delete from T_TRAIN_MANAGE;");
   //2 connect to the database
   string NewPwd = "";
   Console.WriteLine(ResetPwd("330881200301031111", "18621970000", ref NewPwd, true));
   Console.WriteLine(NewPwd);
   return;

   _Seat FreeSeat = new _Seat();
   FreeSeat.TrainID = "G005";
   Console.WriteLine(SearchSeat("G005", 14, 19, 2, 0, ref FreeSeat, true));
   Console.WriteLine("train id     :" + FreeSeat.TrainID);
   Console.WriteLine("start station:" + FreeSeat.StartStNo);
   Console.WriteLine("end station  :" + FreeSeat.EndStNo);
   Console.WriteLine("Carriage     :" + FreeSeat.CarriageNo);
   Console.WriteLine("SeatNo       :" + HashSeatRC2No(FreeSeat.SeatRow, FreeSeat.SeatCol));

   _Order O = new _Order();
   Console.WriteLine(CreateOrder("321027200110036314", "321027200110036314", FreeSeat, ref O, true));
   Console.WriteLine("train id     :" + O.TrainID);
   Console.WriteLine("start station:" + O.StartStNo);
   Console.WriteLine("end station  :" + O.EndStNo);
   Console.WriteLine("Carriage     :" + O.CarriageNo);
   Console.WriteLine("SeatNo       :" + O.SeatNo);
   Console.WriteLine("Order Value  :" + O.OrderValue);
   Console.WriteLine("Order State  :" + O.OrderState);
   return;
}*/

        public static int Login_Adm(_Admin admin, bool IsClose) //无需修改
        {

            //1. connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("1 Success");

            string queryStr = "Select ADM_PWD from T_ADMINISTRATORS where ADM_ID = '" + admin.AdminID + "';";
            //2 query whether the User is existed and check the password
            Console.WriteLine(queryStr);
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (!DataReader.Read()) // User dosen't exist
                {
                    DataReader.Close();
                    return (int)LoginErrorCode.ERR_UUNEXIST;
                }
                else // check password
                {
                    if (DataReader[0].ToString() != admin.AdminPWD)
                    {
                        DataReader.Close();
                        return (int)LoginErrorCode.ERR_PWD;
                    }
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            Console.WriteLine("2 Success");

            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }

            return -1;
        }
        public static int ChangePWD(string UserID,string PWD,bool IsClose)
        {
            int ret = -1;
            //1. check string security
            if ((ret = checkUser.checkUserPWD(PWD)) != -1)
            {
                return ret;
            }

            //2. connect to the database
            if (!Connect())
            {
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //3. do md5 trans
            string EnUserPWD = MyCrypto.Encrypt(PWD);

            //6. insert users
            string queryStr = "UPDATE T_USER SET USER_PASSWORD='" + PWD + "'WHERE USER_ID='" + UserID + "';";

            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                return ret;
            }

            //close the connection
            if (IsClose)
            {
                Close();
            }
            return -1;
        }
        public static int UpdateUser(_User U, bool IsClose)//无需修改
        {
            int ret = -1;
            //1. check string security
            if ((ret = checkUser.checkRegister(U)) != -1)
            {
                return ret;
            }

            //2. connect to the database
            if (!Connect())
            {
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //3. do md5 trans
            string EnUserPID = MyCrypto.Encrypt(U.UserPID);
            string EnUserPWD = MyCrypto.Encrypt(U.UserPWD);
            string EnUserPhone = MyCrypto.Encrypt(U.UserPhone);
            string EnUserRName = MyCrypto.Encrypt(U.UserRName);
            string EnUserID = EnUserPID;

            //6. insert users
            string queryStr = "UPDATE T_USER SET USER_EMAIL='"+U.UserEmail +"',USER_ADDRESS='"+U.UserAddr+"' WHERE USER_ID='"+U.UserID+"';";

            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                return ret;
            }

            //close the connection
            if (IsClose)
            {
                Close();
            }
            return -1;
        }
        public static int Register(_User U, bool IsClose)//无需修改
        {
            int ret = -1;
            //1. check string security
            if ((ret = checkUser.checkRegister(U)) != -1)
            {
                MyLogger.LogRegister(U.UserPID, 0, "Security Error");
                return ret;
            }

            //2. connect to the database
            if (!Connect())
            {
                MyLogger.LogRegister(U.UserPID, 0, "Connection Failed");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //3. do md5 trans
            string EnUserPID = MyCrypto.Encrypt(U.UserPID);
            string EnUserPWD = MyCrypto.Encrypt(U.UserPWD);
            string EnUserPhone = MyCrypto.Encrypt(U.UserPhone);
            string EnUserRName = MyCrypto.Encrypt(U.UserRName);
            string EnUserID = EnUserPID;

            //4. query whether user has been registered(using PID)
            string queryStr = "SELECT count(*) from T_USER where USER_PERSON_ID ='" + EnUserPID + "';";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read() && DataReader[0].ToString() != "0")
                {
                    DataReader.Close();
                    MyLogger.LogRegister(U.UserPID, 0, "Already Same PID Existed");
                    return (int)RegErrorCode.ERR_UEXIST;
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                MyLogger.LogRegister(U.UserPID, 0, ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            //5. query whether phone number has been used
            queryStr = "SELECT count(*) from T_USER where USER_PHONE_NUMBER = '" + EnUserPhone + "';";
            sqlcmd.CommandText = queryStr;
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read() && DataReader[0].ToString() != "0")
                {
                    DataReader.Close();
                    MyLogger.LogRegister(U.UserPID, 0, "Already Same Phone Existed");
                    return (int)RegErrorCode.ERR_PHEXIST;
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                MyLogger.LogRegister(U.UserPID, 0, ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            //6. insert users
            queryStr = "INSERT INTO T_USER Values('" + EnUserID + "','"
                                                      + EnUserPWD + "','"
                                                      + EnUserPhone + "','"
                                                      + U.UserEmail + "','"
                                                      + EnUserRName + "','"
                                                      + U.UserGender + "','"
                                                      + U.UserAddr + "','"
                                                      + EnUserPID + "');";

            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                MyLogger.LogRegister(U.UserPID, 0, "SQL Command Error / Connection Failed");
                return ret;
            }

            //close the connection
            if (IsClose)
            {
                Close();
            }
            MyLogger.LogRegister(U.UserPID, 1, "");
            return -1;
        }
        public static int ResetPwd(string UserPID, string UserPhone, ref string NewPwd, bool IsClose)//无需修改
        {
            int ret = -1;
            //1 check security
            if ((ret = checkUser.checkResetPwd(UserPID, UserPhone)) != -1)
            {
                return ret;
            }

            //2 connect to the database
            if (!Connect())
            {
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //search whether User exists
            string EnUserPID = MyCrypto.Encrypt(UserPID);
            string EnUserPhone = MyCrypto.Encrypt(UserPhone);
            string queryStr = "SELECT count(*) from T_USER where USER_PERSON_ID = '" + EnUserPID + "' and USER_PHONE_NUMBER = '" + EnUserPhone + "';";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read() && DataReader[0].ToString() == "0")
                {
                    return (int)LoginErrorCode.ERR_UUNEXIST;
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3 Success");

            //init UserPWD
            //UserPID(后四位) + UserPhone(后四位) + 时间戳(后四位)
            char[] PID = UserPID.ToCharArray();
            char[] Phone = UserPhone.ToCharArray();
            char[] TS = GetTimeStamp().ToCharArray();
            string pwd = "";
            for (int i = PID.Count() - 1; i >= PID.Count() - 4; i--)
            {
                pwd += PID[i];
            }
            for (int i = Phone.Count() - 1; i >= Phone.Count() - 4; i--)
            {
                pwd += Phone[i];
            }
            for (int i = TS.Count() - 1; i >= TS.Count() - 4; i--)
            {
                pwd += TS[i];
            }
            char[] EnPwd = MyCrypto.Encrypt(pwd).ToCharArray();
            string FinalPwd = "";
            for (int i = 0; i < 10; i++)
            {
                FinalPwd += EnPwd[i];
            }
            Console.WriteLine(FinalPwd);

            //reset UserPWD
            queryStr = "UPDATE T_USER SET USER_PASSWORD = '" + MyCrypto.Encrypt(FinalPwd) + "' where USER_PERSON_ID = '" + EnUserPID + "';";

            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                return ret;
            }
            NewPwd = FinalPwd;

            if (IsClose)
            {
                Close();
            }

            return -1;
        }
        public static int Login(_User U, bool IsClose)//无需修改
        {
            int ret = -1;
            //1. check string security
            if ((ret = checkUser.checkLogin(U)) != -1)
            {
                MyLogger.LogLogin("UNKNOWN", 0, "Security Error");
                return ret;
            }

            //2. connect to the database
            if (!Connect())
            {
                MyLogger.LogLogin("UNKNONW", 0, "Connection Failed");
                return (int)SqlErrorCode.ERR_CONN;
            }

            string? EnUserPID;
            string? EnUserPhone;
            string queryStr = "";

            if (U.UserPID != null)
            {
                EnUserPID = MyCrypto.Encrypt(U.UserPID);
                queryStr = "Select USER_PASSWORD, USER_ID from T_USER where USER_PERSON_ID = '" + EnUserPID + "';";
            }
            else if (U.UserPhone != null)
            {
                EnUserPhone = MyCrypto.Encrypt(U.UserPhone);
                queryStr = "Select USER_PASSWORD, USER_ID from T_USER where USER_PHONE_NUMBER = '" + EnUserPhone + "';";
            }

            //3. do md5 trans
            string EnUserPWD = MyCrypto.Encrypt(U.UserPWD);

            //4 query whether the User is existed and check the password
            Console.WriteLine(queryStr);
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            string UserID = "";
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (!DataReader.Read()) // User dosen't exist
                {
                    DataReader.Close();
                    MyLogger.LogLogin("UNKNOWN", 0, "User didn't exist");
                    return (int)LoginErrorCode.ERR_UUNEXIST;
                }
                else // check password
                {
                    UserID = DataReader[1].ToString();
                    if (DataReader[0].ToString() != EnUserPWD)
                    {
                        DataReader.Close();
                        MyLogger.LogLogin(UserID, 0, "Password Not Correct");
                        return (int)LoginErrorCode.ERR_PWD;
                    }
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MyLogger.LogLogin("UNKNOWN", 0, ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            if (IsClose)
            {
                Close();
            }
            MyLogger.LogLogin(UserID, 1, "");

            return -1;
        }
        public static string Login_D(_User U, bool IsClose)//无需修改
        {
            int ret = -1;
            //1. check string security
            if ((ret = checkUser.checkLogin(U)) != -1)
            {
                return null;
            }

            //2. connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return null;
            }
            Console.WriteLine("2 Success");

            string? md5UserPhone;
            string queryStr = "";

            if (U.UserPID != null)
            {
                return MyCrypto.Encrypt(U.UserPID);
            }
            else if (U.UserPhone != null)
            {
                md5UserPhone = MyCrypto.Encrypt(U.UserPhone);
                queryStr = "Select USER_PID from T_USER where USER_PHONE_NUMBER = '" + md5UserPhone + "';";
            }

            //3 query whether the User is existed and check the password
            Console.WriteLine(queryStr);
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (!DataReader.Read()) // User dosen't exist
                {
                    DataReader.Close();
                    return null;
                }
                else // check password
                {
                    string result = DataReader[0].ToString();
                    DataReader.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static int GetAllUser(List<_User> UList, bool IsClose)//无需修改
        {
            //1. check security
            //TODO

            //2. connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //3
            string queryStr = "SELECT * from T_USER;";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                while (DataReader.Read())
                {
                    _User U = new _User();
                    U.UserID = DataReader[0].ToString();
                    U.UserPWD = MyCrypto.Decrypt(DataReader[1].ToString());
                    U.UserPhone = MyCrypto.Decrypt(DataReader[2].ToString());
                    U.UserEmail = DataReader[3].ToString();
                    U.UserRName = MyCrypto.Decrypt(DataReader[4].ToString());
                    U.UserGender = DataReader[5].ToString();
                    U.UserAddr = DataReader[6].ToString();
                    U.UserPID = MyCrypto.Decrypt(DataReader[7].ToString());
                    UList.Add(U);
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }

            return -1;

        }
        public static int GetAllStation(List<_Station> station, bool IsClose)
        {
            //1. check security
            //TODO

            //2. connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //3
            string queryStr = "SELECT * from T_STATION_INFO;";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                while (DataReader.Read())
                {
                    _Station S = new _Station();
                    S.StationNo = DataReader[0].ToString();
                    S.StationName = DataReader[1].ToString();
                    station.Add(S);
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }

            return -1;
        }
        public static int GetAllOrder(List<_Order> OrderList, bool IsClose)//未修改
        {
            //1 check security
            //TODO
            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //4 get OrderInfo

            string queryStr = "SELECT * from T_ORDER_LIST;";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    _Order TmpOrder = new _Order();
                    TmpOrder.OrderID = DataReader[0].ToString();
                    TmpOrder.TrainID = DataReader[1].ToString();
                    int TmpInt;
                    TmpOrder.StartStNo = DataReader[2].ToString();
                    TmpOrder.EndStNo = DataReader[3].ToString();
                    int.TryParse(DataReader[4].ToString(), out TmpInt);
                    TmpOrder.CarriageNo = TmpInt;
                    TmpOrder.SeatNo = DataReader[5].ToString();
                    int.TryParse(DataReader[5].ToString(), out TmpInt);
                    TmpOrder.OrderValue = TmpInt;
                    TmpOrder.OrderCreate = DataReader[6].ToString();
                    int.TryParse(DataReader[7].ToString(), out TmpInt);
                    TmpOrder.OrderState = TmpInt;
                    OrderList.Add(TmpOrder);
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            Console.WriteLine("4 Success");

            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }

            return -1;

        }
        public static int GetAllTrain(List<_TrainManager> TMList, bool IsClose)//未修改
        {
            //1 check security
            //TODO

            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //4 get OrderInfo

            string queryStr = "SELECT * from T_TRAIN_MANAGE_INFO;";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                while (DataReader.Read())
                {
                    _TrainManager T = new _TrainManager();
                    int TmpInt;
                    T.TrainID = DataReader[0].ToString();
                    T.StartStNo = DataReader[1].ToString();
                    T.EndStNo = DataReader[2].ToString();
                    TMList.Add(T);
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            Console.WriteLine("4 Success");

            for (int i = 0; i < TMList.Count(); i++)
            {
                _TrainManager TM = TMList[i];
                queryStr = "SELECT ARRIVE_TIME from T_TRAIN_PARKING_INFO where TRAIN_ID = '" + TM.TrainID + "' and STATION_NO = '" + TM.StartStNo + "';";
                sqlcmd.CommandText = queryStr;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read())
                    {
                        TM.StartTime = DataReader[0].ToString();
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }

                queryStr = "SELECT ARRIVE_TIME from T_TRAIN_PARKING_INFO where TRAIN_ID = '" + TM.TrainID + "' and STATION_NO = '" + TM.EndStNo + "';";
                sqlcmd.CommandText = queryStr;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read())
                    {
                        TM.EndTime = DataReader[0].ToString();
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }

                TMList[i] = TM;
            }

            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }

            return -1;
        }
        public static int GetOneTrain(string TrainID, ref _TrainManager TM, bool IsClose)//未修改
        {
            //1 check security
            //TODO

            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //
            string queryStr = "SELECT * from T_TRAIN_MANAGE_INFO where TRAIN_ID = '" + TrainID + "';";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    int TmpInt;
                    TM.TrainID = DataReader[0].ToString();
                    TM.StartStNo = DataReader[1].ToString();
                    TM.EndStNo = DataReader[2].ToString();
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            Console.WriteLine("4 Success");

            queryStr = "SELECT ARRIVE_TIME from T_TRAIN_PARKING_INFO where TRAIN_ID = '" + TM.TrainID + "' and STATION_NO = '" + TM.StartStNo + "';";
            sqlcmd.CommandText = queryStr;
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    TM.StartTime = DataReader[0].ToString();
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            queryStr = "SELECT ARRIVE_TIME from T_TRAIN_PARKING_INFO where TRAIN_ID = '" + TM.TrainID + "' and STATION_NO = '" + TM.EndStNo + "';";
            sqlcmd.CommandText = queryStr;
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    TM.EndTime = DataReader[0].ToString();
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }


            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }

            return -1;
        }
        public static int GetOneOrder(string OrderID, ref _Order O, bool IsClose)//未修改
        {
            //1 check security
            //TODO

            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //4 get OrderInfo

            string queryStr = "SELECT * from T_ORDER_LIST where ORDER_ID = '" + OrderID + "';";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    O.OrderID = DataReader[0].ToString();
                    O.TrainID = DataReader[1].ToString();
                    int TmpInt;
                    O.StartStNo = DataReader[2].ToString();
                    O.EndStNo = DataReader[3].ToString();
                    int.TryParse(DataReader[4].ToString(), out TmpInt);
                    O.CarriageNo = TmpInt;
                    O.SeatNo = DataReader[5].ToString();
                    int.TryParse(DataReader[6].ToString(), out TmpInt);
                    O.OrderValue = TmpInt;
                    O.OrderCreate = DataReader[7].ToString();
                    int.TryParse(DataReader[8].ToString(), out TmpInt);
                    O.OrderState = TmpInt;
                }
                else
                {
                    return (int)OErrorCode.ERR_OUNEXIST;
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("4 Success");

            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }

            return -1;

        }
        public static int GetUser(string UserID, ref _User U, bool IsClose)//无需修改
        {
            //1 check security
            //TODO


            //2. connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //
            string queryStr = "SELECT * from T_USER where USER_ID = '" + UserID + "';";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    U.UserID = DataReader[0].ToString();
                    U.UserPWD = MyCrypto.Decrypt(DataReader[1].ToString());
                    U.UserPhone = MyCrypto.Decrypt(DataReader[2].ToString());
                    U.UserEmail = DataReader[3].ToString();
                    U.UserRName = MyCrypto.Decrypt(DataReader[4].ToString());
                    U.UserGender = DataReader[5].ToString();
                    U.UserAddr = DataReader[6].ToString();
                    U.UserPID = MyCrypto.Decrypt(DataReader[7].ToString());
                }
                else
                {
                    DataReader.Close();
                    return (int)RegErrorCode.ERR_UEXIST;
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3 Success");

            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }

            return -1;
        }
        public static bool Connect()//无需修改
        {
            if (conn != null && conn.State.ToString() == "Open")
            {
                return true;
            }
            //string connStr = string.Format("DSN=xe;UID=test_Yellowbest;PWD=test_Yellowbest");
            string connStr = string.Format("DSN=orcl;UID=C##USER;PWD=wyl698638");
            try
            {
                conn = new OdbcConnection(connStr);
                conn.Open();
                Console.WriteLine("Connect Status: " + conn.State);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static int AddPassenger(_Passenger P,bool IsClose)
        {
            int ret = -1;
            //1 check security
            Console.WriteLine("1 Success");

            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");
            string queryStr;
            queryStr = "SELECT COUNT(*) FROM T_PASSENGER WHERE USER_ID='" + P.UserID + "' AND PASSENGER_ID='" + MyCrypto.Encrypt(P.PassengerPID) + "';";

            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read()&&DataReader[0].ToString()!="0") // User dosen't exist
                {
                    return (int)PErrorCode.ERR_PEXIST;
                    //S.StationNo = No + 1;
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            //3 insert passenger 
            queryStr = "INSERT INTO T_PASSENGER Values('" + MyCrypto.Encrypt(P.PassengerPID) + "','"
                                                             + MyCrypto.Encrypt(P.PassengerRName) + "','"
                                                             + P.UserID +"');";

            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                return ret;
            }
            Console.WriteLine("3 Success");

            //close the connection
            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }
            return -1;
        }
        public static int AddStation(_Station S, bool IsClose)
        {
            int ret = -1;
            //1 check security
            if ((ret = checkStation.checkAddSt(S)) != -1)
            {
                return ret;
            }
            Console.WriteLine("1 Success");

            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //3 get StationID
            //get total station's number
            string queryStr = "SELECT count(*) from T_STATION_INFO;";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            int No = -1;
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read()) // User dosen't exist
                {
                    int.TryParse(DataReader[0].ToString(), out No);
                    //S.StationNo = No + 1;
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3 Success");

            //4 insert stations 
            queryStr = "INSERT INTO T_STATION_INFO Values('" + S.StationNo.ToString() + "','"
                                                             + S.StationName + "');";

            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                return ret;
            }
            Console.WriteLine("4 Success");

            //close the connection
            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }
            return -1;
        }
        public static int AddTrainType(_TrainType TT, bool IsClose)
        {
            int ret = -1;
            //1 check security
            //TODO

            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //3 judge whether the traintype has already existed
            string queryStr = "SELECT count(*) from T_TRAIN_TYPE_INFO where TRAIN_TYPE = '" + TT.TrainType + "';";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read()) // User dosen't exist
                {
                    if (DataReader[0].ToString() != "0")
                    {
                        DataReader.Close();
                        return (int)TTErrorCode.ERR_TTEXIST;
                    }
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3 Success");

            //4 insert traintype
            queryStr = "INSERT INTO T_TRAIN_TYPE_INFO Values('" + TT.TrainType + "','"
                                                                + TT.CargCnt + "','"
                                                                + TT.VIPAmount + "','"
                                                                + TT.EXAmount + "','"
                                                                + TT.FirstAmount + "','"
                                                                + TT.SecondAmount + "');";
            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                return ret;
            }
            Console.WriteLine("4 Success");

            //5. insert carriage
            //5-1 VIP
            if (TT.VIPAmount != 0)
            {
                queryStr = "INSERT INTO T_CARRIAGE_INFO Values('" + TT.VIPInfo.SeatLevel + "','"
                                                                  + TT.VIPInfo.SeatRowCnt + "','"
                                                                  + TT.VIPInfo.SeatColCnt + "','"
                                                                  + TT.TrainType + "');";
                if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
                {
                    return ret;
                }
            }
            Console.WriteLine("5-1 Success");

            //5-2 ExClass
            if (TT.EXAmount != 0)
            {
                queryStr = "INSERT INTO T_CARRIAGE_INFO Values('" + TT.EXInfo.SeatLevel + "','"
                                                                  + TT.EXInfo.SeatRowCnt + "','"
                                                                  + TT.EXInfo.SeatColCnt + "','"
                                                                  + TT.TrainType + "');";
                if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
                {
                    return ret;
                }
            }
            Console.WriteLine("5-2 Success");

            //5-3 First
            if (TT.FirstAmount != 0)
            {
                queryStr = "INSERT INTO T_CARRIAGE_INFO Values('" + TT.FirstInfo.SeatLevel + "','"
                                                                  + TT.FirstInfo.SeatRowCnt + "','"
                                                                  + TT.FirstInfo.SeatColCnt + "','"
                                                                  + TT.TrainType + "');";
                if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
                {
                    return ret;
                }
            }
            Console.WriteLine("5-3 Success");

            //5-4 Second
            if (TT.SecondAmount != 0)
            {
                queryStr = "INSERT INTO T_CARRIAGE_INFO Values('" + TT.SecondInfo.SeatLevel + "','"
                                                                  + TT.SecondInfo.SeatRowCnt + "','"
                                                                  + TT.SecondInfo.SeatColCnt + "','"
                                                                  + TT.TrainType + "');";
                if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
                {
                    return ret;
                }
            }
            Console.WriteLine("5-4 Success");

            //close the connection
            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }
            return -1;
        }

        public static int AddTrain(_Train T, bool IsClose)
        {
            int ret = -1;
            //check security
            //TODO
            Console.WriteLine("1 Success");

            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //3 judge whether train has already existed
            string queryStr = "SELECT count(*) from T_TRAIN_INFO where TRAIN_NUMBER = '" + T.TrainNum + "';";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read()) // User dosen't exist
                {
                    if (DataReader[0].ToString() != "0")
                    {
                        DataReader.Close();
                        return (int)TErrorCode.ERR_TEXIST;
                    }
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3 Success");

            //4 judge whether traintype has already existed
            queryStr = "SELECT count(*) from T_TRAIN_TYPE_INFO where TRAIN_TYPE = '" + T.TrainType + "';";
            sqlcmd.CommandText = queryStr;
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    if (DataReader[0].ToString() == "0")
                    {
                        DataReader.Close();
                        return (int)TErrorCode.ERR_TTUNEXIST;
                    }
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("4 Success");

            //4 insert train 
            queryStr = "INSERT INTO T_TRAIN_INFO Values('" + T.TrainNum + "','"
                                                           + T.TrainType + "','"
                                                           + T.TrainState + "');";

            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                return ret;
            }
            Console.WriteLine("5 Success");

            //close the connection
            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }
            return -1;
        }

        public static int AddTrainManager(_TrainManager TM, bool IsClose)
        {
            int ret = -1;
            //1 check security
            //TODO
            Console.WriteLine("1 Success");

            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //3-1 judge whether trainID has already existed
            string queryStr = "SELECT count(*) from T_TRAIN_MANAGE where TRAIN_ID = '" + TM.TrainID + "';";
            Console.WriteLine(queryStr);
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read()) // User dosen't exist
                {
                    if (DataReader[0].ToString() != "0")
                    {
                        DataReader.Close();
                        return (int)TMErrorCode.ERR_TMEXIST;
                    }
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3-1 Success");

            //3-2 judge whether trainNo has already existed
            queryStr = "SELECT count(*) from T_TRAIN_MANAGE where TRAIN_NUMBER = '" + TM.TrainNo + "';";
            sqlcmd.CommandText = queryStr;
            Console.WriteLine(queryStr);
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    if (DataReader[0].ToString() != "0")
                    {
                        DataReader.Close();
                        return (int)TMErrorCode.ERR_TMEXIST;
                    }
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3-2 Success");

            //3-3 judge whether Start Station has already been existed
            queryStr = "SELECT count(*) from T_STATION_INFO where STATION_NO = '" + TM.StartStNo + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    if (DataReader[0].ToString() == "0")
                    {
                        DataReader.Close();
                        return (int)TMErrorCode.ERR_STUNEXIST;
                    }
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3-3 Success");

            //3-4 judge whether End Station has already been existed
            queryStr = "SELECT count(*) from T_STATION_INFO where STATION_NO = '" + TM.EndStNo + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    if (DataReader[0].ToString() == "0")
                    {
                        DataReader.Close();
                        return (int)TMErrorCode.ERR_STUNEXIST;
                    }
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3-4 Success");

            //4 check parking info
            for (int i = 0; i < TM.Parking.Count(); i++)
            {
                //4-1 judge whether Parking Station has already been existed
                queryStr = "SELECT count(*) from T_STATION_INFO where STATION_NO = '" + TM.Parking[i].StationNo + "';";
                Console.WriteLine(queryStr);
                sqlcmd.CommandText = queryStr;
                //Execute the DataReader to Access the data
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read())
                    {
                        if (DataReader[0].ToString() == "0")
                        {
                            DataReader.Close();
                            return (int)TMErrorCode.ERR_STUNEXIST;
                        }
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }
                Console.WriteLine("3-3 Success");

                //4-2 judge whether Next Station has already been existed
                if (TM.Parking[i].NextStNo != -1)
                {
                    queryStr = "SELECT count(*) from T_STATION_INFO where STATION_NO = '" + TM.Parking[i].NextStNo + "';";
                    Console.WriteLine(queryStr);
                    sqlcmd.CommandText = queryStr;
                    //Execute the DataReader to Access the data
                    try
                    {
                        OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                        if (DataReader.Read())
                        {
                            if (DataReader[0].ToString() == "0")
                            {
                                DataReader.Close();
                                return (int)TMErrorCode.ERR_STUNEXIST;
                            }
                        }
                        DataReader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return (int)SqlErrorCode.ERR_SQLCMD;
                    }
                }
            }
            Console.WriteLine("4 Success");

            //5-1 insert Train_Manage
            queryStr = "INSERT INTO T_TRAIN_MANAGE Values('" + TM.TrainID + "','"
                                                             + TM.TrainNo + "');";
            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                return ret;
            }
            Console.WriteLine("5-1 Success");

            //5-2 insert Train_Manage
            queryStr = "INSERT INTO T_TRAIN_MANAGE_INFO Values('" + TM.TrainID + "','"
                                                                  + TM.StartStNo + "','"
                                                                  + TM.EndStNo + "','"
                                                                  + TM.RunningTime + "');";
            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                return ret;
            }
            Console.WriteLine("5-2 Success");

            //5-3 insert Train_Parking_Info
            for (int i = 0; i < TM.Parking.Count(); i++)
            {
                queryStr = "INSERT INTO T_TRAIN_PARKING_INFO Values('" + TM.TrainID + "','"
                                                                       + TM.Parking[i].StationNo + "','"
                                                                       + TM.Parking[i].ArriveTime + "','"
                                                                       + TM.Parking[i].LeavingTime + "','"
                                                                       + TM.Parking[i].ParkingTime + "','"
                                                                       + TM.Parking[i].NextStNo + "');";
                if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
                {
                    return ret;
                }
            }
            Console.WriteLine("5-3 Success");

            //5-4 insert Train_Parking_Carriage_Info
            //5-4-1 Get Train_Type
            _TrainType TT = new _TrainType();
            queryStr = "SELECT TRAIN_TYPE from T_TRAIN_INFO where TRAIN_NUMBER = '" + TM.TrainNo + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    TT.TrainType = DataReader[0].ToString();
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("5-4-1 Success");

            //5-4-2 Get Train_Type_Info
            queryStr = "SELECT * from T_TRAIN_TYPE_INFO where TRAIN_TYPE = '" + TT.TrainType + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    int CargCnt, VIPAmount, EXAmount, FirstAmount, SecondAmount;
                    int.TryParse(DataReader[1].ToString(), out CargCnt);
                    int.TryParse(DataReader[2].ToString(), out VIPAmount);
                    int.TryParse(DataReader[3].ToString(), out EXAmount);
                    int.TryParse(DataReader[4].ToString(), out FirstAmount);
                    int.TryParse(DataReader[5].ToString(), out SecondAmount);
                    TT.CargCnt = CargCnt;
                    TT.VIPAmount = VIPAmount;
                    TT.EXAmount = EXAmount;
                    TT.FirstAmount = FirstAmount;
                    TT.SecondAmount = SecondAmount;
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("5-4-2 Success");

            //5-4-3 Get Train_Type_Carriage
            queryStr = "SELECT * from T_CARRIAGE_INFO where TRAIN_TYPE = '" + TT.TrainType + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                while (DataReader.Read())
                {
                    int SeatColCnt, SeatRowCnt, SeatLevel;
                    int.TryParse(DataReader[0].ToString(), out SeatLevel);
                    int.TryParse(DataReader[1].ToString(), out SeatRowCnt);
                    int.TryParse(DataReader[2].ToString(), out SeatColCnt);

                    _Carriage tmp = new _Carriage();
                    tmp.SeatColCnt = SeatColCnt;
                    tmp.SeatRowCnt = SeatRowCnt;
                    tmp.SeatLevel = SeatLevel;

                    //vip
                    if (tmp.SeatLevel == 1)
                    {
                        TT.VIPInfo = tmp;
                    }
                    // EX
                    else if (tmp.SeatLevel == 2)
                    {
                        TT.EXInfo = tmp;
                    }
                    //First
                    else if (tmp.SeatLevel == 3)
                    {
                        TT.FirstInfo = tmp;
                    }
                    //Second
                    else if (tmp.SeatLevel == 4)
                    {
                        TT.SecondInfo = tmp;
                    }
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("5-4-3 Success");

            for (int i = 0; i < TM.Parking.Count(); i++)
            {
                Console.WriteLine(TM.Parking[i].StationNo.ToString());
            }

            //6 insert train_parking_carriage_info
            for (int i = 1; i <= TT.CargCnt; i++)
            {
                for (int j = 0; j < TM.Parking.Count(); j++)
                {
                    if (i <= TT.VIPAmount)
                    {
                        string bitmap = "";
                        int SeatCnt = TT.VIPInfo.SeatRowCnt * TT.VIPInfo.SeatColCnt;
                        for (int k = 0; k < SeatCnt; k++)
                        {
                            bitmap += '0';
                        }

                        queryStr = "INSERT INTO T_TRAIN_PARKING_CARRIAGE_INFO Values('" + TM.TrainID + "','"
                                                                                        + TM.Parking[j].StationNo + "','"
                                                                                        + i + "','"
                                                                                        + TT.VIPInfo.SeatLevel + "','"
                                                                                        + TT.VIPInfo.SeatRowCnt + "','"
                                                                                        + TT.VIPInfo.SeatColCnt + "','"
                                                                                        + bitmap + "','"
                                                                                        + SeatCnt + "');";
                        if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
                        {
                            return ret;
                        }
                    }
                    else if (i <= TT.VIPAmount + TT.EXAmount)
                    {
                        string bitmap = "";
                        int SeatCnt = TT.EXInfo.SeatRowCnt * TT.EXInfo.SeatColCnt;
                        for (int k = 0; k < SeatCnt; k++)
                        {
                            bitmap += '0';
                        }

                        queryStr = "INSERT INTO T_TRAIN_PARKING_CARRIAGE_INFO Values('" + TM.TrainID + "','"
                                                                                        + TM.Parking[j].StationNo + "','"
                                                                                        + i + "','"
                                                                                        + TT.EXInfo.SeatLevel + "','"
                                                                                        + TT.EXInfo.SeatRowCnt + "','"
                                                                                        + TT.EXInfo.SeatColCnt + "','"
                                                                                        + bitmap + "','"
                                                                                        + SeatCnt + "');";
                        if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
                        {
                            return ret;
                        }
                    }
                    else if (i <= TT.VIPAmount + TT.EXAmount + TT.FirstAmount)
                    {
                        string bitmap = "";
                        int SeatCnt = TT.FirstInfo.SeatRowCnt * TT.FirstInfo.SeatColCnt;
                        for (int k = 0; k < SeatCnt; k++)
                        {
                            bitmap += '0';
                        }

                        queryStr = "INSERT INTO T_TRAIN_PARKING_CARRIAGE_INFO Values('" + TM.TrainID + "','"
                                                                                        + TM.Parking[j].StationNo + "','"
                                                                                        + i + "','"
                                                                                        + TT.FirstInfo.SeatLevel + "','"
                                                                                        + TT.FirstInfo.SeatRowCnt + "','"
                                                                                        + TT.FirstInfo.SeatColCnt + "','"
                                                                                        + bitmap + "','"
                                                                                        + SeatCnt + "');";
                        if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
                        {
                            return ret;
                        }
                    }
                    else if (i <= TT.VIPAmount + TT.EXAmount + TT.FirstAmount + TT.SecondAmount)
                    {
                        string bitmap = "";
                        int SeatCnt = TT.SecondInfo.SeatRowCnt * TT.SecondInfo.SeatColCnt;
                        for (int k = 0; k < SeatCnt; k++)
                        {
                            bitmap += '0';
                        }

                        queryStr = "INSERT INTO T_TRAIN_PARKING_CARRIAGE_INFO Values('" + TM.TrainID + "','"
                                                                                        + TM.Parking[j].StationNo + "','"
                                                                                        + i + "','"
                                                                                        + TT.SecondInfo.SeatLevel + "','"
                                                                                        + TT.SecondInfo.SeatRowCnt + "','"
                                                                                        + TT.SecondInfo.SeatColCnt + "','"
                                                                                        + bitmap + "','"
                                                                                        + SeatCnt + "');";
                        if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
                        {
                            return ret;
                        }
                    }
                }
            }
            Console.WriteLine("6 Success");

            //close the connection
            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }
            return -1;
        }

        public static int SearchTrainTicket(string StartStNo, string EndStNo, int year, int month, int day, List<_TrainTicket> TrainTicketList, bool IsClose)//已修改
        {
            int ret = -1;
            //check security
            //TODO
            Console.WriteLine("1 Success");

            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            _Date NowDate = new _Date(year, month, day, 0, 0, 0);

            //3 Search TrainID
            List<string> TrainIDList = new List<string>();
            if ((ret = SearchTrainID(StartStNo, EndStNo, TrainIDList, false)) != -1)
            {
                return ret;
            }

            //4 get train info by trainid
            string queryStr = "";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            for (int i = 0; i < TrainIDList.Count(); i++)
            {
                _TrainTicket TrnTct = new _TrainTicket();
                TrnTct.TrainID = TrainIDList[i];
                TrnTct.VIPAmount = 0;
                TrnTct.EXAmount = 0;
                TrnTct.FirstAmount = 0;
                TrnTct.SecondAmount = 0;

                //get train routine
                List<_ParkingStation> PSList = new List<_ParkingStation>();
                Console.WriteLine(GetTrainRoutine(TrainIDList[i], PSList, false));
                TrnTct.Parkstations = PSList;

                //get start station Name
                queryStr = "SELECT STATION_NAME from T_STATION_INFO where STATION_NO = '" + StartStNo + "';";
                Console.WriteLine(queryStr);
                sqlcmd.CommandText = queryStr;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read())
                    {
                        TrnTct.StartStName = DataReader[0].ToString();
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }

                //get end station Name
                queryStr = "SELECT STATION_NAME from T_STATION_INFO where STATION_NO = '" + EndStNo + "';";
                Console.WriteLine(queryStr);
                sqlcmd.CommandText = queryStr;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read())
                    {
                        TrnTct.EndStName = DataReader[0].ToString();
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }

                //get leaving time
                queryStr = "SELECT ARRIVE_TIME from T_TRAIN_PARKING_INFO where TRAIN_ID = '" + TrainIDList[i] + "' and STATION_NO = '" + StartStNo + "';";
                Console.WriteLine(queryStr);
                sqlcmd.CommandText = queryStr;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read())
                    {
                        TrnTct.LeavingTime = DataReader[0].ToString();
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }

                //get arriving time
                queryStr = "SELECT ARRIVE_TIME from T_TRAIN_PARKING_INFO where TRAIN_ID = '" + TrainIDList[i] + "' and STATION_NO = '" + EndStNo + "';";
                Console.WriteLine(queryStr);
                sqlcmd.CommandText = queryStr;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read())
                    {
                        TrnTct.ArriveTime = DataReader[0].ToString();
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }

                //get total time
                _Date AT = new _Date();
                _Date LT = new _Date();
                AT.SetDate("0-0-0");
                AT.SetTime(TrnTct.ArriveTime);
                LT.SetDate("0-0-0");
                LT.SetTime(TrnTct.LeavingTime);
                if (string.Compare(TrnTct.ArriveTime, TrnTct.LeavingTime) == 1)
                {
                    LT.Day += 1;
                }
                TrnTct.TotalTime = CalTimeGap(AT, LT);

                //get seat ticket info
                queryStr = "SELECT count(distinct CARRIAGE_NO) from T_TRAIN_PARKING_CARRIAGE_INFO where TRAIN_ID = '" + TrainIDList[i] + "';";
                Console.WriteLine(queryStr);
                sqlcmd.CommandText = queryStr;
                int CarriageCnt = 0;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read())
                    {
                        int.TryParse(DataReader[0].ToString(), out CarriageCnt);
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }
                Console.WriteLine(CarriageCnt);

                List<_Tmp_Result> Result = new List<_Tmp_Result>();
                _Tmp_Result TR = new _Tmp_Result();
                TR.CarriageNo = -1;
                for (int k = 0; k < CarriageCnt; k++)
                {
                    Result.Add(TR);
                }
                List<_Tmp_Result> TRList = new List<_Tmp_Result>();

                foreach (_ParkingStation PS in PSList)
                {
                    for (int k = 1; k <= CarriageCnt; k++)
                    {
                        queryStr = "SELECT SEAT_LEVEL, SEAT_INFO from T_TRAIN_PARKING_CARRIAGE_INFO where TRAIN_ID = '" + TrainIDList[i] + "' and STATION_NO = '" + PS.StationNo + "' and CARRIAGE_NO = '" + k + "' and TRAIN_DATE = '" + NowDate.GetDate() + "';";
                        Console.WriteLine(queryStr);
                        sqlcmd.CommandText = queryStr;
                        try
                        {
                            OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                            if (DataReader.Read())
                            {
                                int SL;
                                int.TryParse(DataReader[0].ToString(), out SL);
                                _Tmp_Result Tmp = new _Tmp_Result();
                                Tmp.CarriageNo = k;
                                Tmp.SeatLevel = SL;
                                Tmp.Bitmap = DataReader[1].ToString().ToCharArray();
                                if (Result[k - 1].CarriageNo == -1)
                                {
                                    Result[k - 1] = Tmp;
                                }
                                else
                                {
                                    for (int l = 0; l < Tmp.Bitmap.Count(); l++)
                                    {
                                        if (Tmp.Bitmap[l] == '1')
                                        {
                                            Result[k - 1].Bitmap[l] = '1';
                                        }
                                    }
                                }
                            }
                            DataReader.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            return (int)SqlErrorCode.ERR_SQLCMD;
                        }
                    }
                }

                foreach (_Tmp_Result R in Result)
                {
                    int FreeSeatCnt = 0;
                    for (int k = 0; k < R.Bitmap.Count(); k++)
                    {
                        if (R.Bitmap[k] != '1')
                        {
                            FreeSeatCnt++;
                        }
                    }
                    if (R.SeatLevel == 1)
                    {
                        TrnTct.VIPAmount += FreeSeatCnt;
                    }
                    if (R.SeatLevel == 2)
                    {
                        TrnTct.EXAmount += FreeSeatCnt;
                    }
                    if (R.SeatLevel == 3)
                    {
                        TrnTct.FirstAmount += FreeSeatCnt;
                    }
                    if (R.SeatLevel == 4)
                    {
                        TrnTct.SecondAmount += FreeSeatCnt;
                    }
                }

                TrnTct.TrainDate = NowDate.GetDate();
                TrainTicketList.Add(TrnTct);
            }

            //close the connection
            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }
            return -1;
        }
        public static int SearchTrainTicket(string TrainID, string StartStNo, string EndStNo, string TrainDate, ref _TrainTicket TrainTicket, bool IsClose)//已修改
        {
            int ret = -1;
            //check security
            //TODO
            Console.WriteLine("1 Success");

            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            _Date NowDate = new _Date();
            NowDate.SetDate(TrainDate);

            //3 get train info by trainid
            string queryStr = "";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            _TrainTicket TrnTct = new _TrainTicket();
            TrnTct.TrainID = TrainID;
            TrnTct.VIPAmount = 0;
            TrnTct.EXAmount = 0;
            TrnTct.FirstAmount = 0;
            TrnTct.SecondAmount = 0;

            //get train routine
            List<_ParkingStation> PSList = new List<_ParkingStation>();
            Console.WriteLine(GetTrainRoutine(TrainID, PSList, false));
            TrnTct.Parkstations = PSList;

            //get start station Name
            queryStr = "SELECT STATION_NAME from T_STATION_INFO where STATION_NO = '" + StartStNo + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    TrnTct.StartStName = DataReader[0].ToString();
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            //get end station Name
            queryStr = "SELECT STATION_NAME from T_STATION_INFO where STATION_NO = '" + EndStNo + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    TrnTct.EndStName = DataReader[0].ToString();
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            //get leaving time
            queryStr = "SELECT ARRIVE_TIME from T_TRAIN_PARKING_INFO where TRAIN_ID = '" + TrainID + "' and STATION_NO = '" + StartStNo + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    TrnTct.LeavingTime = DataReader[0].ToString();
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            //get arriving time
            queryStr = "SELECT ARRIVE_TIME from T_TRAIN_PARKING_INFO where TRAIN_ID = '" + TrainID + "' and STATION_NO = '" + EndStNo + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    TrnTct.ArriveTime = DataReader[0].ToString();
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            //get total time
            _Date AT = new _Date();
            _Date LT = new _Date();
            AT.SetDate("0-0-0");
            AT.SetTime(TrnTct.ArriveTime);
            LT.SetDate("0-0-0");
            LT.SetTime(TrnTct.LeavingTime);
            if (string.Compare(TrnTct.ArriveTime, TrnTct.LeavingTime) == 1)
            {
                LT.Day += 1;
            }
            TrnTct.TotalTime = CalTimeGap(AT, LT);

            //get seat ticket info
            queryStr = "SELECT count(distinct CARRIAGE_NO) from T_TRAIN_PARKING_CARRIAGE_INFO where TRAIN_ID = '" + TrainID + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            int CarriageCnt = 0;
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    int.TryParse(DataReader[0].ToString(), out CarriageCnt);
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine(CarriageCnt);

            List<_Tmp_Result> Result = new List<_Tmp_Result>();
            _Tmp_Result TR = new _Tmp_Result();
            TR.CarriageNo = -1;
            for (int k = 0; k < CarriageCnt; k++)
            {
                Result.Add(TR);
            }
            List<_Tmp_Result> TRList = new List<_Tmp_Result>();

            foreach (_ParkingStation PS in PSList)
            {
                for (int k = 1; k <= CarriageCnt; k++)
                {
                    queryStr = "SELECT SEAT_LEVEL, SEAT_INFO from T_TRAIN_PARKING_CARRIAGE_INFO where TRAIN_ID = '" + TrainID + "' and STATION_NO = '" + PS.StationNo + "' and CARRIAGE_NO = '" + k + "' and TRAIN_DATE = '" + NowDate.GetDate() + "';";
                    Console.WriteLine(queryStr);
                    sqlcmd.CommandText = queryStr;
                    try
                    {
                        OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                        if (DataReader.Read())
                        {
                            int SL;
                            int.TryParse(DataReader[0].ToString(), out SL);
                            _Tmp_Result Tmp = new _Tmp_Result();
                            Tmp.CarriageNo = k;
                            Tmp.SeatLevel = SL;
                            Tmp.Bitmap = DataReader[1].ToString().ToCharArray();
                            if (Result[k - 1].CarriageNo == -1)
                            {
                                Result[k - 1] = Tmp;
                            }
                            else
                            {
                                for (int l = 0; l < Tmp.Bitmap.Count(); l++)
                                {
                                    if (Tmp.Bitmap[l] == '1')
                                    {
                                        Result[k - 1].Bitmap[l] = '1';
                                    }
                                }
                            }
                        }
                        DataReader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return (int)SqlErrorCode.ERR_SQLCMD;
                    }
                }
            }

            foreach (_Tmp_Result R in Result)
            {
                int FreeSeatCnt = 0;
                for (int k = 0; k < R.Bitmap.Count(); k++)
                {
                    if (R.Bitmap[k] != '1')
                    {
                        FreeSeatCnt++;
                    }
                }
                if (R.SeatLevel == 1)
                {
                    TrnTct.VIPAmount += FreeSeatCnt;
                }
                if (R.SeatLevel == 2)
                {
                    TrnTct.EXAmount += FreeSeatCnt;
                }
                if (R.SeatLevel == 3)
                {
                    TrnTct.FirstAmount += FreeSeatCnt;
                }
                if (R.SeatLevel == 4)
                {
                    TrnTct.SecondAmount += FreeSeatCnt;
                }
            }

            TrnTct.TrainDate = NowDate.GetDate();
            TrainTicket = TrnTct;

            //close the connection
            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }
            return -1;
        }
        public static int GetPassenger(string UserID, List<_Passenger> PList, bool IsClose)
        {
            //1 check security
            //TODO

            //2. connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //
            string queryStr = "SELECT * from T_PASSENGER where USER_ID = '" + UserID + "';";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                while (DataReader.Read())
                {
                    _Passenger P = new _Passenger();
                    P.PassengerPID = MyCrypto.Decrypt(DataReader[0].ToString());
                    P.PassengerRName = MyCrypto.Decrypt( DataReader[1].ToString());
                    P.UserID = UserID;
                    PList.Add(P);
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3 Success");

            if(IsClose)
            {
                Close();
            }

            return -1;
        }
        public static int SearchTrainID(string StartStNo, string EndStNo, List<string> Result, bool IsClose) //已修改
        {
            //check security
            //TODO
            Console.WriteLine("1 Success");
            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //3-1 judge whether Start Station has already been existed
            string queryStr = "SELECT count(*) from T_STATION_INFO where STATION_NO = '" + StartStNo + "';";
            Console.WriteLine(queryStr);
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    if (DataReader[0].ToString() == "0")
                    {
                        DataReader.Close();
                        return (int)TMErrorCode.ERR_STUNEXIST;
                    }
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3-1 Success");

            //3-2 judge whether End Station has already been existed
            queryStr = "SELECT count(*) from T_STATION_INFO where STATION_NO = '" + EndStNo + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    if (DataReader[0].ToString() == "0")
                    {
                        DataReader.Close();
                        return (int)TMErrorCode.ERR_STUNEXIST;
                    }
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3-2 Success");

            //4 Search TrainID contains two station
            queryStr = "with St1 as (SELECT * from T_TRAIN_PARKING_INFO where STATION_NO = '" + StartStNo + "')," +
                            "St2 as (SELECT * from T_TRAIN_PARKING_INFO where STATION_NO = '" + EndStNo + "')" +
                       "SELECT St1.TRAIN_ID from St1, St2 where St1.TRAIN_ID = St2.TRAIN_ID AND St1.TRAIN_ID in (SELECT TRAIN_ID FROM T_TRAIN_MANAGE_INFO WHERE TRAIN_RUNNING_STATE='1');";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                while (DataReader.Read()) // User dosen't exist
                {
                    Result.Add(DataReader[0].ToString());
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("4 Success");

            //5 judge the direction
            for (int i = 0; i < Result.Count(); i++)
            {
                //Get the Train Routine
                List<_ParkingStation> PSList = new List<_ParkingStation>();
                GetTrainRoutine(Result[i], PSList, false);
                int flag = 0;
                for (int j = 0; j < PSList.Count(); j++)
                {
                    if (PSList[j].StationNo == EndStNo)
                    {
                        flag = 2;
                        break;
                    }
                    else if (PSList[j].StationNo == StartStNo)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag != 1)
                {
                    Result.RemoveAt(i);
                    i--;
                }
            }

            //close the connection
            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }
            return -1;
        }
        public static int SearchSeat(string TrainID, string StartStNo, string EndStNo, int Seatlevel, int Col, ref _Seat FreeSeat, int year, int month, int day, bool IsClose)//已修改
        {
            int ret = -1;
            //1 check security
            //TODO

            //2 get Train Routine(reverse)
            List<_ParkingStation> PSList = new List<_ParkingStation>();
            if ((ret = GetTrainRoutine(TrainID, PSList, false)) != -1)
            {
                return ret;
            }

            //3 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //4 get bitmap of the Carriage of 
            HashSet<int> CNoSet = new HashSet<int>();
            List<_Carriage_Seat> CSList = new List<_Carriage_Seat>();

            int SearchFlag = 0;
            _Date NowDate = new _Date(year, month, day, 0, 0, 0);
            FreeSeat.TrainDate = NowDate.GetDate();
            string LastStLeavingTime = "";
            foreach (_ParkingStation PS in PSList)
            {
                if (PS.StationNo == StartStNo)
                {
                    SearchFlag = 1;
                }
                else if (PS.StationNo == EndStNo)
                {
                    SearchFlag = 0;
                }
                if (SearchFlag != 0)
                {
                    if(LastStLeavingTime.Count() == 0)
                    {
                        LastStLeavingTime = PS.LeavingTime;
                    }
                    else
                    {
                        if(string.Compare(LastStLeavingTime, PS.ArriveTime) == 1)
                        {
                            NowDate.Day++;
                        }
                    }
                    LastStLeavingTime = PS.LeavingTime;
                    string queryStr = "SELECT CARRIAGE_NO, SEAT_INFO, SEAT_ROW_CNT, SEAT_COL_CNT from T_TRAIN_PARKING_CARRIAGE_INFO where SEAT_LEVEL = '" + Seatlevel + "' and TRAIN_ID = '" + TrainID + "' and STATION_NO = '" + PS.StationNo + "' and TRAIN_DATE = '" + NowDate.GetDate() + "';";
                    Console.WriteLine(queryStr);
                    OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
                    //Execute the DataReader to Access the data
                    try
                    {
                        OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                        while (DataReader.Read())
                        {
                            _Carriage_Seat CS = new _Carriage_Seat();
                            int tmp = 0;
                            int.TryParse(DataReader[0].ToString(), out tmp);
                            CS.CarriageNo = tmp;
                            CNoSet.Add(tmp);
                            CS.SeatInfo = DataReader[1].ToString();
                            int.TryParse(DataReader[2].ToString(), out tmp);
                            CS.SeatRowCnt = tmp;
                            int.TryParse(DataReader[3].ToString(), out tmp);
                            CS.SeatColCnt = tmp;
                            CSList.Add(CS);
                        }
                        DataReader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return (int)SqlErrorCode.ERR_SQLCMD;
                    }
                }
            }

            //4 judge which seat is free

            foreach (int CNo in CNoSet)
            {
                int row = CSList[0].SeatRowCnt;
                int col = CSList[0].SeatColCnt;
                int ChosedCol = Col;
                string AvaSeatInfo = "";
                for (int i = 0; i < row * col; i++)
                {
                    AvaSeatInfo += '0';
                }
                char[] AvaSeatBitmap = AvaSeatInfo.ToCharArray();

                for (int i = 0; i < CSList.Count(); i++)
                {
                    char[] CSBitmap = CSList[i].SeatInfo.ToCharArray();
                    if (CSList[i].CarriageNo == CNo)
                    {
                        for (int j = 1; j <= row; j++)
                        {
                            for (int k = 1; k <= col; k++)
                            {
                                if (ChosedCol == 0 || k == ChosedCol)
                                {
                                    //check whether seat is free
                                    if (CSBitmap[(j - 1) * col + k - 1] == '1')
                                    {
                                        AvaSeatBitmap[(j - 1) * col + k - 1] = '1';
                                    }
                                }
                            }
                        }
                    }
                }

                for (int i = 1; i <= row; i++)
                {
                    for (int j = 1; j <= col; j++)
                    {
                        if (ChosedCol == 0 || j == ChosedCol)
                        {
                            if (AvaSeatBitmap[(i - 1) * col + j - 1] == '0')
                            {
                                FreeSeat.StartStNo = StartStNo;
                                FreeSeat.EndStNo = EndStNo;
                                FreeSeat.SeatLevel = Seatlevel;
                                FreeSeat.CarriageNo = CNo;
                                FreeSeat.SeatCol = j;
                                FreeSeat.SeatRow = i;
                                FreeSeat.TrainID = TrainID;
                                return -1;
                            }
                        }
                    }
                }
            }

            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }

            return -1;
        }
        public static int GetTrainRoutine(string TrainID, List<_ParkingStation> PSList, bool IsClose) //已修改
        {
            //1 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("1 Success");

            //2 Search from the end Station(Next StationNo = -1)
            string NextStNo="-1";
            while (NextStNo != "")
            {
                string queryStr = "SELECT STATION_NO, ARRIVE_TIME, LEAVING_TIME, PARKING_TIME from T_TRAIN_PARKING_INFO where TRAIN_ID = '" + TrainID + "' and NEXT_STATION_NO = '" + NextStNo.ToString() + "';";
                Console.WriteLine(queryStr);
                NextStNo = "";
                OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
                //Execute the DataReader to Access the data
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read())
                    {
                        _ParkingStation Tmp = new _ParkingStation();
                        Tmp.StationNo = DataReader[0].ToString();
                        Tmp.ArriveTime = DataReader[1].ToString();
                        Tmp.LeavingTime = DataReader[2].ToString();
                        Tmp.ParkingTime = DataReader[3].ToString();
                        PSList.Add(Tmp);
                        NextStNo = Tmp.StationNo;
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }
            }

            //reverse the List
            int left = 0;
            int right = PSList.Count() - 1;
            while (left < right)
            {
                _ParkingStation tmp = PSList[left];
                PSList[left] = PSList[right];
                PSList[right] = tmp;
                left++;
                right--;
            }

            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }


            return -1;
        }
        //just for test
        public static int AddOrder(_Order O, bool IsClose)//已修改
        {
            int ret = -1;
            //1. check security
            //TODO
            Console.WriteLine("1 Sucess");

            //2. connect to the database
            if (!Connect())
            {
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            string queryStr = "";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);


            //3. must ensure there is only one order to handle(roughly get lock)
            while (true)
            {
                queryStr = "SELECT count(*) from T_ORDER_LIST where ORDER_STATE = '1' and TRAIN_ID = '" + O.TrainID + "' and TRAIN_DATE = '" + O.TrainDate + "';";
                sqlcmd.CommandText = queryStr;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read() && DataReader[0].ToString() == "0")
                    {
                        DataReader.Close();
                        O.OrderState = 1;
                        break;
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }

            }
            Console.WriteLine("3 Success");

            //4. Insert Orders
            queryStr = "INSERT INTO T_ORDER_LIST Values('" + O.OrderID + "','"
                                                           + O.TrainID + "','"
                                                           + O.StartStNo + "','"
                                                           + O.EndStNo + "','"
                                                           + O.CarriageNo.ToString() + "','"
                                                           + O.SeatNo + "','"
                                                           + O.OrderValue.ToString() + "','"
                                                           + O.OrderCreate.ToString() + "','"
                                                           + O.OrderState.ToString() + "','"
                                                           + O.SeatLevel.ToString() + "','"
                                                           + O.TrainDate.ToString() + "');";

            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                //delete Order Info
                queryStr = "DELETE from T_ORDERS where ORDER_ID = '" + O.OrderID + "';";
                NoRetDataSqlExecute(queryStr);
                return ret;
            }
            Console.WriteLine("4 Success");

            //5 Get TrainID routine
            List<_ParkingStation> PSList = new List<_ParkingStation>();
            Console.WriteLine(GetTrainRoutine(O.TrainID, PSList, false));
            Console.WriteLine("5 Success");

            //6 check all the seat first if OK change their state
            List<string> NoList = new List<string>();
            List<string> DateList = new List<string>();
            List<int> FreeSeatCntList = new List<int>();
            List<char[]> BitmapList = new List<char[]>();
            bool StartSearch = false;
            _Date NowDate = new _Date();
            string LastStLeavingTime = "";
            for (int i = 0; i < PSList.Count(); i++)
            {
                if (PSList[i].StationNo == O.StartStNo)
                {
                    StartSearch = true;
                }
                else if (PSList[i].StationNo == O.EndStNo)
                {
                    StartSearch = false;
                }
                if (StartSearch)
                {
                    NowDate.SetDate(O.TrainDate);
                    if (LastStLeavingTime.Count() == 0)
                    {
                        LastStLeavingTime = PSList[i].LeavingTime;
                    }
                    else
                    {
                        if (string.Compare(LastStLeavingTime, PSList[i].ArriveTime) == 1)
                        {
                            NowDate.Day++;
                        }
                    }
                    LastStLeavingTime = PSList[i].LeavingTime;
                    NoList.Add(PSList[i].StationNo);
                    DateList.Add(NowDate.GetDate());
                    queryStr = "SELECT SEAT_INFO, SEAT_COL_CNT, FREE_SEAT_CNT from T_TRAIN_PARKING_CARRIAGE_INFO where TRAIN_ID = '" + O.TrainID + "' and CARRIAGE_NO = '" + O.CarriageNo.ToString() + "' and STATION_NO = '" + PSList[i].StationNo + "' and TRAIN_DATE = '" + NowDate.GetDate() + "';";
                    Console.WriteLine(queryStr);
                    sqlcmd.CommandText = queryStr;
                    try
                    {
                        OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                        if (DataReader.Read())
                        {
                            Console.WriteLine(DataReader[0].ToString());
                            char[] bitmap = DataReader[0].ToString().ToCharArray();
                            int tmp;
                            int.TryParse(DataReader[1].ToString(), out tmp);
                            int index = HashNo2Index(O.SeatNo, tmp);
                            Console.WriteLine(index);
                            if (bitmap[index] == '1') // Error
                            {
                                DataReader.Close();
                                queryStr = "DELETE from T_ORDER_LIST where ORDER_ID = '" + O.OrderID + "';";
                                NoRetDataSqlExecute(queryStr);
                                return (int)OErrorCode.ERR_ORDER;
                            }
                            bitmap[index] = '1';
                            BitmapList.Add(bitmap);
                            int.TryParse(DataReader[2].ToString(), out tmp);
                            FreeSeatCntList.Add(tmp - 1);
                        }
                        DataReader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        queryStr = "DELETE from T_ORDER_LIST where ORDER_ID = '" + O.OrderID + "';";
                        NoRetDataSqlExecute(queryStr);
                        return (int)SqlErrorCode.ERR_SQLCMD;
                    }
                }
            }
            Console.WriteLine("6-1 Success");

            //if OK do change the seat state
            for (int i = 0; i < NoList.Count(); i++)
            {
                string str = new string(BitmapList[i]);
                queryStr = "UPDATE T_TRAIN_PARKING_CARRIAGE_INFO SET SEAT_INFO = '" + str + "', FREE_SEAT_CNT = '" + FreeSeatCntList[i] + "' where TRAIN_ID = '" + O.TrainID + "' and CARRIAGE_NO = '" + O.CarriageNo.ToString() + "' and STATION_NO = '" + NoList[i] + "' and TRAIN_DATE = '" + DateList[i] + "';";
                if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
                {
                    return ret;
                }
            }
            Console.WriteLine("6-2 Success");

            //7 change the order State as Finished(2)
            queryStr = "UPDATE T_ORDER_LIST SET ORDER_STATE = '2' where ORDER_ID = '" + O.OrderID + "';";
            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                return ret;
            }

            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }

            return -1;
        }
        public static int CreateOrder(string UserID, string PassengerID, _Seat S, ref _Order O, bool IsClose)//已修改
        {
            int ret = -1;
            //1 check security
            //TODO
            Console.WriteLine("1 Success");

            //2 connect to the database
            if (!Connect())
            {
                MyLogger.LogOrder(UserID, "UNKNOWN", S.TrainID, 0, 0, "Connection Failed");
                return (int)SqlErrorCode.ERR_CONN;
            }

            O.OrderCreate = GetTimeStamp();
            O.OrderID = O.OrderCreate;
            O.TrainID = S.TrainID;
            O.CarriageNo = S.CarriageNo;
            O.StartStNo = S.StartStNo;
            O.EndStNo = S.EndStNo;
            O.OrderValue = (10 - S.SeatLevel) * 200;
            O.OrderState = 0;
            O.SeatNo = HashSeatRC2No(S.SeatRow, S.SeatCol);
            O.TrainDate = S.TrainDate;

            //check conflict 
            string queryStr = "SELECT count(*) from T_ORDER_LIST where TRAIN_ID = '" + O.TrainID + "' and ORDER_ID in (SELECT ORDER_ID from T_ORDERS where PASSENGER_ID = '" + PassengerID + "' and TRAIN_DATE = '" + O.TrainDate + "');";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read() && DataReader[0].ToString() != "0")
                {
                    MyLogger.LogOrder(UserID, "UNKNOWN", O.TrainID, 0, 0, "Travel Time Conflict");
                    return (int)OErrorCode.ERR_OTCONFLICT;
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                MyLogger.LogOrder(UserID, "UNKNOWN", O.TrainID, 0, 0, ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }



            //3 AddOrder
            if ((ret = AddOrder(O, false)) != -1)
            {
                MyLogger.LogOrder(UserID, "UNKNOWN", O.TrainID, 0, 0, "Order Error");
                return ret;
            }

            //4 insert T_ORDERS
            queryStr = "INSERT INTO T_ORDERS Values('" + O.OrderID + "','"
                                                       + UserID + "','"
                                                       + PassengerID + "');";
            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                return ret;
            }
            queryStr = "SELECT ARRIVE_TIME FROM T_TRAIN_PARKING_INFO WHERE TRAIN_ID='" + O.TrainID + "' AND STATION_NO='" + O.StartStNo + "';";
            sqlcmd.CommandText = queryStr;
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    O.LeavingTime = DataReader[0].ToString();
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            queryStr = "SELECT ARRIVE_TIME FROM T_TRAIN_PARKING_INFO WHERE TRAIN_ID='" + O.TrainID + "' AND STATION_NO='" + O.EndStNo + "';";
            sqlcmd.CommandText = queryStr;
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    O.ArriveTime = DataReader[0].ToString();
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            if (IsClose)
            {
                Close();
            }
            MyLogger.LogOrder(UserID, O.OrderID, O.TrainID, 0, 1, "");

            return -1;
        }
        public static int CancelOrder(string OrderID, string UserID, bool IsClose) //已修改
        {
            int ret = -1;
            //1 check security
            //TODO

            //2. connect to the database
            if (!Connect())
            {
                MyLogger.LogOrder(UserID, OrderID, "UNKNOWN", 1, 0, "Connection Error");
                return (int)SqlErrorCode.ERR_CONN;
            }

            string queryStr = "";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);

            //3. get Order
            queryStr = "SELECT * from T_ORDER_LIST where ORDER_ID = '" + OrderID + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            _Order TmpOrder = new _Order();
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read())
                {
                    int TmpInt;
                    TmpOrder.OrderID = DataReader[0].ToString();
                    TmpOrder.TrainID = DataReader[1].ToString();
                    TmpOrder.StartStNo = DataReader[2].ToString();
                    TmpOrder.EndStNo = DataReader[3].ToString();
                    int.TryParse(DataReader[4].ToString(), out TmpInt);
                    TmpOrder.CarriageNo = TmpInt;
                    TmpOrder.SeatNo = DataReader[5].ToString();
                    int.TryParse(DataReader[6].ToString(), out TmpInt);
                    TmpOrder.OrderValue = TmpInt;
                    TmpOrder.OrderCreate = DataReader[7].ToString();
                    int.TryParse(DataReader[8].ToString(), out TmpInt);
                    TmpOrder.OrderState = TmpInt;
                    int.TryParse(DataReader[9].ToString(), out TmpInt);
                    TmpOrder.SeatLevel = TmpInt;
                    TmpOrder.TrainDate = DataReader[10].ToString();
                }
                else
                {
                    MyLogger.LogOrder(UserID, OrderID, "UNKNOWN", 1, 0, "Order didn't exist");
                    return (int)OErrorCode.ERR_OUNEXIST;
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                MyLogger.LogOrder(UserID, OrderID, "UNKNOWN", 1, 0, ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }


            //3. must ensure there is only one order to handle(roughly get lock)
            while (true)
            {
                queryStr = "SELECT count(*) from T_ORDER_LIST where ORDER_STATE = '1' and TRAIN_ID = '" + TmpOrder.TrainID + "' and TRAIN_DATE = '" + TmpOrder.TrainDate + "';";
                Console.WriteLine(queryStr);
                sqlcmd.CommandText = queryStr;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read() && DataReader[0].ToString() == "0")
                    {
                        DataReader.Close();
                        //Console.WriteLine(DataReader[0].ToString());
                        TmpOrder.OrderState = 1;
                        break;
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }

            }

            //4. update Order State to Handling(1)
            queryStr = "UPDATE T_ORDER_LIST SET ORDER_STATE = '1' where ORDER_ID = '" + TmpOrder.OrderID + "';";
            Console.WriteLine(queryStr);
            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                MyLogger.LogOrder(UserID, OrderID, TmpOrder.TrainID, 1, 0, "SQL Command Error / Connection Failed");
                return ret;
            }

            //5. cancel Order
            //5-1 get train routine
            List<_ParkingStation> PSList = new List<_ParkingStation>();
            if ((ret = GetTrainRoutine(TmpOrder.TrainID, PSList, false)) != -1)
            {
                MyLogger.LogOrder(UserID, OrderID, TmpOrder.TrainID, 1, 0, "SQL Command Error / Connection Failed");
                return ret;
            }

            //5-2 update train carriage info
            _Date NowDate = new _Date();
            string LastStLeavingTime = "";
            bool flag = false;
            for (int i = 0; i < PSList.Count(); i++)
            {
                if (PSList[i].StationNo == TmpOrder.StartStNo)
                {
                    flag = true;
                }
                else if (PSList[i].StationNo == TmpOrder.EndStNo)
                {
                    flag = false;
                }
                if (flag)
                {
                    NowDate.SetDate(TmpOrder.TrainDate);
                    if (LastStLeavingTime.Count() == 0)
                    {
                        LastStLeavingTime = PSList[i].LeavingTime;
                    }
                    else
                    {
                        if (string.Compare(LastStLeavingTime, PSList[i].ArriveTime) == 1)
                        {
                            NowDate.AddDate(1);
                        }
                    }
                    LastStLeavingTime = PSList[i].ArriveTime;
                    queryStr = "SELECT FREE_SEAT_CNT, SEAT_INFO, SEAT_COL_CNT from T_TRAIN_PARKING_CARRIAGE_INFO where TRAIN_ID = '" + TmpOrder.TrainID + "' and STATION_NO = '" + PSList[i].StationNo + "' and CARRIAGE_NO = '" + TmpOrder.CarriageNo + "' and TRAIN_DATE = '" + NowDate.GetDate() + "';";
                    sqlcmd.CommandText = queryStr;
                    try
                    {
                        OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                        if (DataReader.Read())
                        {
                            int FreeSeatCnt, col;
                            int.TryParse(DataReader[0].ToString(), out FreeSeatCnt);
                            char[] bitmap = DataReader[1].ToString().ToCharArray();
                            int.TryParse(DataReader[2].ToString(), out col);
                            int index = HashNo2Index(TmpOrder.SeatNo, col);
                            bitmap[index] = '0';
                            FreeSeatCnt++;
                            string SeatInfo = new string(bitmap);
                            queryStr = "UPDATE T_TRAIN_PARKING_CARRIAGE_INFO SET FREE_SEAT_CNT = '" + FreeSeatCnt + "', SEAT_INFO = '" + SeatInfo + "' where TRAIN_ID = '" + TmpOrder.TrainID + "' and CARRIAGE_NO = '" + TmpOrder.CarriageNo + "' and STATION_NO = '" + PSList[i].StationNo + "' and TRAIN_DATE = '" + NowDate.GetDate() + "';";
                            Console.WriteLine(queryStr);
                            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
                            {
                                MyLogger.LogOrder(UserID, OrderID, TmpOrder.TrainID, 1, 0, "SQL Command Error / Connection Failed");
                                return ret;
                            }
                        }
                        DataReader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        queryStr = "UPDATE T_ORDER_LIST SET ORDER_STATE = '2' where ORDER_ID = '" + TmpOrder.OrderID + "'";
                        if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
                        {
                            return ret;
                        }
                        MyLogger.LogOrder(UserID, OrderID, TmpOrder.TrainID, 1, 0, ex.Message);
                        return (int)SqlErrorCode.ERR_SQLCMD;
                    }
                }
            }

            //5-3 delete order
            queryStr = "DELETE from T_ORDER_LIST where ORDER_ID = '" + TmpOrder.OrderID + "';";
            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                MyLogger.LogOrder(UserID, OrderID, TmpOrder.TrainID, 1, 0, "SQL Command Error / Connection Failed");
                return ret;
            }
            queryStr = "DELETE from T_ORDERS where ORDER_ID = '" + TmpOrder.OrderID + "';";
            if ((ret = NoRetDataSqlExecute(queryStr)) != -1)
            {
                MyLogger.LogOrder(UserID, OrderID, TmpOrder.TrainID, 1, 0, "SQL Command Error / Connection Failed");
                return ret;
            }

            if (IsClose)
            {
                Close();
            }

            MyLogger.LogOrder(UserID, OrderID, TmpOrder.TrainID, 1, 1, "Success");
            return -1;
        }
        public static int GetOrder(string UserID, List<_Order> OrderList, bool IsClose) //已修改
        {
            //1 check security
            //TODO

            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //3 get OrderID
            List<string> OrderIDList = new List<string>();
            string queryStr = "SELECT ORDER_ID from T_ORDERS where USER_ID = '" + UserID + "';";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                while (DataReader.Read())
                {
                    OrderIDList.Add(DataReader[0].ToString());
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("3 Success");

            //4 get OrderInfo
            foreach (string ID in OrderIDList)
            {
                queryStr = "SELECT * from T_ORDER_LIST where ORDER_ID = '" + ID + "';";
                sqlcmd.CommandText = queryStr;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read())
                    {
                        _Order TmpOrder = new _Order();
                        int TmpInt;
                        TmpOrder.OrderID = DataReader[0].ToString();
                        TmpOrder.TrainID = DataReader[1].ToString();
                        TmpOrder.StartStNo = DataReader[2].ToString();
                        TmpOrder.EndStNo = DataReader[3].ToString();
                        int.TryParse(DataReader[4].ToString(), out TmpInt);
                        TmpOrder.CarriageNo = TmpInt;
                        TmpOrder.SeatNo = DataReader[5].ToString();
                        int.TryParse(DataReader[6].ToString(), out TmpInt);
                        TmpOrder.OrderValue = TmpInt;
                        TmpOrder.OrderCreate = DataReader[7].ToString();
                        int.TryParse(DataReader[8].ToString(), out TmpInt);
                        TmpOrder.OrderState = TmpInt;
                        int.TryParse(DataReader[9].ToString(), out TmpInt);
                        TmpOrder.SeatLevel = TmpInt;
                        TmpOrder.TrainDate = DataReader[10].ToString();
                        OrderList.Add(TmpOrder);
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }
            }
            Console.WriteLine("4 Success");

            _Date NowTime = new _Date(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            for (int i = 0; i < OrderList.Count(); i++)
            {
                _Date TrainOrderTime = new _Date();
                string StartStNo = "";
                TrainOrderTime.SetDate(OrderList[i].TrainDate);
                queryStr = "SELECT ARRIVE_TIME from T_TRAIN_PARKING_INFO where TRAIN_ID = '" + OrderList[i].TrainID + "' and STATION_NO = '" + OrderList[i].StartStNo + "';";
                sqlcmd.CommandText = queryStr;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read())
                    {
                        TrainOrderTime.SetTime(DataReader[0].ToString());
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }

                //compare time
                if (_Date.Compare(NowTime, TrainOrderTime))
                {
                    queryStr = "UPDATE T_ORDER_LIST SET ORDER_STATE = '3' where ORDER_ID = '" + OrderList[i].OrderID;
                    _Order Tmp = OrderList[i];
                    Tmp.OrderState = 3;
                    OrderList[i] = Tmp;
                }
            }

            if (IsClose)
            {
                Close();
                Console.WriteLine("Connection Closed");
            }

            return -1;
        }

        public static int Reset(string queryStr)
        {
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);

            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            //close the connection
            Close();
            Console.WriteLine("Connection Closed");
            return -1;
        }

        public static int NoRetDataSqlExecute(string queryStr)
        {
            if (conn == null || conn.State.ToString() == "Close")
            {
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine(queryStr);
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            return -1;
        }

        public static void Close()
        {
            if (conn == null)
            {
                return;
            }
            conn.Close();
        }

        public static string CalTimeGap(_Date Start, _Date End)
        {
            int DeltaMin = (Start.Day - End.Day) * 24 * 60 + (Start.Hour - End.Hour) * 60 + (Start.Minute - End.Minute);
            int DeltaH = DeltaMin / 60;
            int DeltaMi = DeltaMin % 60;
            string result = "";
            if (DeltaH < 10)
            {
                result += "0";
            }
            result += DeltaH.ToString();
            result += ":";
            if (DeltaMi < 10)
            {
                result += "0";
            }
            result += DeltaMi.ToString();
            return result;
        }
        public static int HashNo2Index(string no, int col)
        {
            string Row = "";
            string Col = "";
            for (int i = 0; i < no.Length; i++)
            {
                if (no[i] >= '0' && no[i] <= '9')
                {
                    Row += no[i];
                }
                else
                {
                    Col += no[i] - 'A';
                }
            }
            int r, c;
            int.TryParse(Row, out r);
            int.TryParse(Col, out c);
            return (r - 1) * col + c;
        }
        public static int DeletePassenger(string UserID, string PassengerID)
        {
            //1 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("1 Success");

            bool PassengerWithOrder = false;
            string queryStr = "SELECT count(*) from T_ORDERS where USER_ID = '" + UserID + "' and PASSENGER_ID = '" + PassengerID + "';";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read() && DataReader[0].ToString() != "0")
                {
                    PassengerWithOrder = true;
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }
            Console.WriteLine("2 Success");

            if (PassengerWithOrder)
            {
                queryStr = "SELECT count(*) from T_ORDER_LIST where ORDER_STATE != '3' and ORDER_ID in (SELECT ORDER_ID from T_ORDERS where USER_ID = '" + UserID + "' and PASSENGER_ID = '" + PassengerID + "');";
                sqlcmd.CommandText = queryStr;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    if (DataReader.Read() && DataReader[0].ToString() != "0")
                    {
                        return 0;
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }
                Console.WriteLine("2 Success");
            }

            //
            queryStr = "DELETE T_PASSENGER where USER_ID = '" + UserID + "' and PASSENGER_ID = '" + MyCrypto.Encrypt( PassengerID) + "';";
            NoRetDataSqlExecute(queryStr);

            return -1;

        }

        public static string HashSeatRC2No(int row, int col)
        {
            string result = "";
            result += row.ToString();
            result += (char)(col + 'A' - 1);
            return result;
        }

        public static string GetTimeStamp()
        {
            return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
        }
    }

}

