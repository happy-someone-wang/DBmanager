using System.Linq;

namespace myDate
{
    public struct _Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public _Date(int Year, int Month, int Day, int Hour, int Minute, int Second)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
            this.Hour = Hour;
            this.Minute = Minute;
            this.Second = Second;
        }

        public override string ToString()
        {
            string str = "";
            str += Year.ToString();
            str += '/';
            str += Month.ToString();
            str += '/';
            str += Day.ToString();
            str += ' ';
            if (Hour < 10)
            {
                str += '0';
            }
            str += Hour.ToString();
            str += ':';
            if (Minute < 10)
            {
                str += '0';
            }
            str += Minute.ToString();
            str += ':';
            if (Second < 10)
            {
                str += '0';
            }
            str += Second.ToString();
            return str;
        }

        public _Date(string str)
        {
            int Year = 0;
            int Month = 0;
            int Day = 0;
            int Hour = 0;
            int Minute = 0;
            int Second = 0;
            string tmpStr = "";
            int eleCnt = 1;
            for(int i = 0; i < str.Count(); i++)
            {
                if(str[i] == '/' || str[i] == ' ' || str[i] == ':')
                {
                    if(eleCnt == 1)
                    {
                        int.TryParse(tmpStr, out Year);
                    }
                    else if(eleCnt == 2)
                    {
                        int.TryParse(tmpStr, out Month);
                    }
                    if(eleCnt == 3)
                    {
                        int.TryParse(tmpStr, out Day);
                    }
                    if(eleCnt == 4)
                    {
                        int.TryParse(tmpStr, out Hour);
                    }
                    if(eleCnt == 5)
                    {
                        int.TryParse(tmpStr, out Minute);
                    }
                    if(eleCnt == 6)
                    {
                        int.TryParse(tmpStr, out Second);
                    }
                    tmpStr = "";
                    eleCnt++;
                }
                else
                {
                    tmpStr += str[i];
                }
            }
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
            this.Hour = Hour;
            this.Minute = Minute;
            this.Second = Second;
        }

        public void SetDate(string Date) //Date格式为yyyy-mm-dd
        {
            int Year = 0;
            int Month = 0; 
            int Day = 0;
            int eleCnt = 0;
            string TmpStr = "";
            for(int i = 0; i < Date.Count(); i++)
            {
                if(Date[i] != '-')
                {
                    TmpStr += Date[i];
                }
                else if(eleCnt == 0)
                {
                    int.TryParse(TmpStr, out Year);
                    TmpStr = "";
                    eleCnt++;
                }
                else if(eleCnt == 1)
                {
                    int.TryParse(TmpStr, out Month);
                    TmpStr = "";
                    eleCnt++;
                }
                
            }
            int.TryParse(TmpStr, out Day);
            TmpStr = "";
            eleCnt++;
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
        }

        public void SetTime(string Time) //Time格式为hh:mm:ss
        {
            int Hour = 0;
            int Minute = 0; 
            int Second = 0;
            int eleCnt = 0;
            string TmpStr = "";
            for(int i = 0; i < Time.Count(); i++)
            {
                if(Time[i] != ':')
                {
                    TmpStr += Time[i];
                }
                else if(eleCnt == 0)
                {
                    int.TryParse(TmpStr, out Hour);
                    TmpStr = "";
                    eleCnt++;
                }
                else if(eleCnt == 1)
                {
                    int.TryParse(TmpStr, out Minute);
                    TmpStr = "";
                    eleCnt++;
                }
            }
            int.TryParse(TmpStr, out Second);
            TmpStr = "";
            eleCnt++;
            this.Hour = Hour;
            this.Minute = Minute;
            this.Second = Second;
        } 

        public static bool Compare(_Date Left, _Date Right)
        {
            if(Left.Year == Right.Year)
            {
                if(Left.Month == Right.Month)
                {
                    if(Left.Day == Right.Day)
                    {
                        if(Left.Hour == Right.Hour)
                        {
                            if(Left.Minute == Right.Minute)
                            {
                                if(Left.Second == Right.Second)
                                {
                                    return true;
                                }
                                return Left.Second > Right.Second;
                            }
                            return Left.Minute > Right.Minute;
                        }
                        return Left.Hour > Right.Hour;
                    }
                    return Left.Day > Right.Day;
                }
                return Left.Month > Right.Month;
            }
            return Left.Year > Right.Year;
        }

        public string GetDate() //yyyy-mm-dd
        {
            string Result = "";
            Result += Year.ToString();
            Result += '-';
            if(Month < 10)
            {
                Result += '0';
            }
            Result += Month.ToString();
            Result += '-';
            if(Day < 10)
            {
                Result += '0';            
            }
            Result += Day.ToString();
            return Result;
        }

        public string GetTime()
        {
            string Result = "";
            if (Hour < 10)
            {
                Result += '0';
            }
            Result += Hour.ToString();
            Result += ':';
            if (Minute < 10)
            {
                Result += '0';
            }
            Result += Minute.ToString();
            Result += ':';
            if (Second < 10)
            {
                Result += '0';
            }
            Result += Second.ToString();
            return Result;
        }

        public void AddDate(int DayCnt)
        {
            this.Day += DayCnt;
        }
    }
}