using System.Data.Odbc;
using Containers;
using Error;
using Check;
using Crypto;
using System;
using System.Collections.Generic;
using System.Linq;

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

            List<_TrainTicket> TTL = new List<_TrainTicket>();
            Console.WriteLine(SearchTrain(1, 2, 2022, 8, 24, TTL));
            foreach(_TrainTicket TicketInfo in TTL)
            {
                Console.WriteLine("train id     :" + TicketInfo.TrainID);
                Console.WriteLine("start station:" + TicketInfo.StartStName);
                Console.WriteLine("end station  :" + TicketInfo.EndStName);
                Console.WriteLine("leaving time :" + TicketInfo.LeavingTime);
                Console.WriteLine("arriving time:" + TicketInfo.ArriveTime);
                Console.WriteLine("total time   :" + TicketInfo.TotalTime);
                Console.WriteLine("VIP Ticket   :" + TicketInfo.VIPAmount.ToString());
                Console.WriteLine("EX Ticket    :" + TicketInfo.EXAmount.ToString());
                Console.WriteLine("First Ticket :" + TicketInfo.FirstAmount.ToString());
                Console.WriteLine("Second Ticket:" + TicketInfo.SecondAmount.ToString());
            }

        }*/

        public static int Register(_User U)
        {
            int ret = -1;
            //1. check string security
            if ((ret = checkUser.checkRegister(U)) != -1)
            {
                return ret;
            }
            Console.WriteLine("1 Success");

            //2. connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //3. do md5 trans
            string md5UserPID = md5Crypto.MD5Encrypt32(U.UserPID);
            string md5UserPWD = md5Crypto.MD5Encrypt32(U.UserPWD);
            string md5UserPhone = md5Crypto.MD5Encrypt32(U.UserPhone);
            string md5UserRName = md5Crypto.MD5Encrypt32(U.UserRName);
            string md5UserAddr = md5Crypto.MD5Encrypt32(U.UserAddr);
            string md5UserEmail = md5Crypto.MD5Encrypt32(U.UserEmail);
            string md5UserID = md5UserPID;
            Console.WriteLine("3 Success");

            //4. query whether user has been registered(using PID)
            string queryStr = "SELECT count(*) from T_USER where USER_PERSON_ID ='" + md5UserPID + "';";
            Console.WriteLine(queryStr);
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read() && DataReader[0].ToString() != "0")
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

            Console.WriteLine("4 Success");

            //5. query whether phone number has been used
            queryStr = "SELECT count(*) from T_USER where USER_PHONE_NUMBER = '" + md5UserPhone + "';";
            Console.WriteLine(queryStr);
            sqlcmd.CommandText = queryStr;
            //Execute the DataReader to Access the data
            try
            {
                OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                if (DataReader.Read() && DataReader[0].ToString() != "0")
                {
                    DataReader.Close();
                    return (int)RegErrorCode.ERR_PHEXIST;
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (int)SqlErrorCode.ERR_SQLCMD;
            }

            Console.WriteLine("5 Success");
            //6. insert users
            queryStr = "INSERT INTO T_USER Values('" + md5UserID + "','"
                                                      + md5UserPWD + "','"
                                                      + md5UserPhone + "','"
                                                      + md5UserEmail + "','"
                                                      + md5UserRName + "','"
                                                      + U.UserGender + "','"
                                                      + md5UserAddr + "','"
                                                      + md5UserPID + "');";

            if ((ret = Insert(queryStr)) != -1)
            {
                return ret;
            }
            Console.WriteLine("6 Success");

            //close the connection
            Close();
            Console.WriteLine("Connection Closed");
            return -1;
        }

        public static int Login(_User U)
        {
            int ret = -1;
            //1. check string security
            if ((ret = checkUser.checkLogin(U)) != -1)
            {
                return ret;
            }

            //2. connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            string? md5UserPID;
            string? md5UserPhone;
            string queryStr = "";
            if (U.UserPID != null)
            {
                md5UserPID = md5Crypto.MD5Encrypt32(U.UserPID);
                queryStr = "Select USER_PASSWORD from T_USER where USER_PERSON_ID = '" + md5UserPID + "';";
            }
            else if (U.UserPhone != null)
            {
                md5UserPhone = md5Crypto.MD5Encrypt32(U.UserPhone);
                queryStr = "Select USER_PASSWORD from T_USER where USER_PHONE_NUMBER = '" + md5UserPhone + "';";
            }

            //3. do md5 trans
            string md5UserPWD = md5Crypto.MD5Encrypt32(U.UserPWD);
            Console.WriteLine("3 Success");

            //4 query whether the User is existed and check the password
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
                    if (DataReader[0].ToString() != md5UserPWD)
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

            Console.WriteLine("4 Success");

            return -1;
        }

        public static bool Connect()
        {
            string connStr = string.Format("DSN=xe;UID=test_Yellowbest;PWD=test_Yellowbest");
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

        public static int AddStation(_Station S)
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
                    S.StationNo = No + 1;
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

            if ((ret = Insert(queryStr)) != -1)
            {
                return ret;
            }
            Console.WriteLine("4 Success");

            //close the connection
            Close();
            Console.WriteLine("Connection Closed");
            return -1;
        }

        public static int AddTrainType(_TrainType TT)
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
            if ((ret = Insert(queryStr)) != -1)
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
                if ((ret = Insert(queryStr)) != -1)
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
                if ((ret = Insert(queryStr)) != -1)
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
                if ((ret = Insert(queryStr)) != -1)
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
                if ((ret = Insert(queryStr)) != -1)
                {
                    return ret;
                }
            }
            Console.WriteLine("5-4 Success");

            //close the connection
            Close();
            Console.WriteLine("Connection Closed");
            return -1;
        }

        public static int AddTrain(_Train T)
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

            if ((ret = Insert(queryStr)) != -1)
            {
                return ret;
            }
            Console.WriteLine("5 Success");

            //close the connection
            Close();
            Console.WriteLine("Connection Closed");
            return -1;
        }

        public static int AddTrainManager(_TrainManager TM)
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
            if ((ret = Insert(queryStr)) != -1)
            {
                return ret;
            }
            Console.WriteLine("5-1 Success");

            //5-2 insert Train_Manage
            queryStr = "INSERT INTO T_TRAIN_MANAGE_INFO Values('" + TM.TrainID + "','"
                                                                  + TM.StartStNo + "','"
                                                                  + TM.EndStNo + "','"
                                                                  + TM.RunningTime + "');";
            if ((ret = Insert(queryStr)) != -1)
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
                if ((ret = Insert(queryStr)) != -1)
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
                        if ((ret = Insert(queryStr)) != -1)
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
                        if ((ret = Insert(queryStr)) != -1)
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
                        if ((ret = Insert(queryStr)) != -1)
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
                        if ((ret = Insert(queryStr)) != -1)
                        {
                            return ret;
                        }
                    }
                }
            }
            Console.WriteLine("6 Success");

            //close the connection
            Close();
            Console.WriteLine("Connection Closed");
            return -1;
        }

        public static int SearchTrain(int StartStNo, int EndStNo, int year, int month, int day, List<_TrainTicket> TrainTicketList)
        {
            int ret = -1;
            //check security
            //TODO
            Console.WriteLine("1 Success");

            //3 Search TrainID
            List<string> TrainIDList = new List<string>();
            DateTime AT = new DateTime(year, month, day);
            if ((ret = SearchTrainID(StartStNo, EndStNo, AT, TrainIDList)) != -1)
            {
                return ret;
            }

            //2 connect to the database
            if (!Connect())
            {
                Console.WriteLine("Failed to Connect to Oracle");
                return (int)SqlErrorCode.ERR_CONN;
            }
            Console.WriteLine("2 Success");

            //4 get train info by trainid
            string queryStr = "";
            OdbcCommand sqlcmd = new OdbcCommand(queryStr, conn);
            for (int i = 0; i < TrainIDList.Count(); i++)
            {
                _TrainTicket TrnTct = new _TrainTicket();
                TrnTct.TrainID      = TrainIDList[i];
                TrnTct.VIPAmount    = 0;
                TrnTct.EXAmount     = 0;
                TrnTct.FirstAmount  = 0;
                TrnTct.SecondAmount = 0;

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
                DateTime _AT = DateTime.Parse(TrnTct.ArriveTime);
                DateTime _LT = DateTime.Parse(TrnTct.LeavingTime);
                TrnTct.TotalTime = CalTimeGap(_AT, _LT);

                //get seat ticket info
                queryStr = "SELECT SEAT_LEVEL, FREE_SEAT_CNT from T_TRAIN_PARKING_CARRIAGE_INFO where TRAIN_ID = '" + TrainIDList[i] + "';";
                Console.WriteLine(queryStr);
                sqlcmd.CommandText = queryStr;
                try
                {
                    OdbcDataReader DataReader = sqlcmd.ExecuteReader();
                    while(DataReader.Read())
                    {
                       int SeatLevel, FreeSeatCnt;
                       int.TryParse(DataReader[0].ToString(), out SeatLevel);
                       int.TryParse(DataReader[1].ToString(), out FreeSeatCnt);
                       if(SeatLevel == 1)
                       {
                            TrnTct.VIPAmount += FreeSeatCnt;
                       }
                       else if(SeatLevel == 2)
                       {
                            TrnTct.EXAmount  += FreeSeatCnt;
                       }
                       else if(SeatLevel == 3)
                       {
                            TrnTct.FirstAmount += FreeSeatCnt;
                       }
                       else if(SeatLevel == 4)
                       {
                            TrnTct.SecondAmount += FreeSeatCnt;
                       }
                    }
                    DataReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return (int)SqlErrorCode.ERR_SQLCMD;
                }
                TrainTicketList.Add(TrnTct);
            }

            //close the connection
            Close();
            Console.WriteLine("Connection Closed");
            return -1;
        }
        public static int SearchTrainID(int StartStNo, int EndStNo, DateTime Time, List<string> Result)
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

            //4 Search
            queryStr = "with St1 as (SELECT * from T_TRAIN_PARKING_INFO where STATION_NO = '" + StartStNo + "')," +
                            "St2 as (SELECT * from T_TRAIN_PARKING_INFO where STATION_NO = '" + EndStNo + "')" +
                       "SELECT St1.TRAIN_ID from St1, St2 where St1.TRAIN_ID = St2.TRAIN_ID and St1.ARRIVE_TIME < St2.ARRIVE_TIME and St1.ARRIVE_TIME > '" + Time.ToString() + "';";
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
            Console.WriteLine("3 Success");

            //close the connection
            Close();
            Console.WriteLine("Connection Closed");
            return -1;
        }

        //public static int SearchSeat(string TrainID, int StationNo)
        //{

        //}
        //just for test
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

        public static int Insert(string queryStr)
        {
            if (conn == null)
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

        public static string CalTimeGap(DateTime Start, DateTime End)
        {
            int DeltaH, DeltaMi;
            DeltaH  = Start.Hour - End.Hour;
            DeltaMi = Start.Minute - End.Minute;
            string result = "";
            if(DeltaH < 10)
            {
                result += "0";
            }
            result += DeltaH.ToString();
            result += ":";
            if(DeltaMi < 10)
            {
                result += "0";
            }
            result += DeltaMi.ToString();
            return result;
        }
    }
}

