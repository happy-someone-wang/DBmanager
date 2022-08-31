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
    }
}