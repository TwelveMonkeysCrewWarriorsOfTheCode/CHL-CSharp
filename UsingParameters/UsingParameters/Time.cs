using System;
using System.Collections.Generic;
using System.Text;

namespace UsingParameters
{
    class Time
    {
        public int Hour;
        public int Minute;

        public override string ToString()
        {
            string s = $"{Hour}:{Minute} min.";
            return s;
        }

        public static Time AddTime(Time pLeftTime, Time pRightTime)
        {
            Time result = new Time();
            result.Hour = pLeftTime.Hour + pRightTime.Hour;
            result.Minute = pLeftTime.Minute + pRightTime.Minute;
            while (result.Minute > 60)
            {
                result.Hour++;
                result.Minute = result.Minute -60;
            }
            return result;
        }

        public static Time SubTime(Time pLeftTime, Time pRightTime)
        {
            Time result = new Time();
            result.Hour = pLeftTime.Hour - pRightTime.Hour;
            if (pLeftTime.Minute >= pRightTime.Minute)
            {
                result.Minute = pLeftTime.Minute - pRightTime.Minute;
            }
            else
            {
                result.Minute = pRightTime.Minute - pLeftTime.Minute;
            }
            return result;
        }

        public static Time MulTime(Time pLeftTime, Time pRightTime)
        {
            Time result = new Time();
            result.Hour = pLeftTime.Hour * pRightTime.Hour;
            result.Minute = pLeftTime.Minute * pRightTime.Minute;
            while (result.Minute > 60)
            {
                result.Hour++;
                result.Minute = result.Minute - 60;
            }
            return result;
        }
        public static Time DivTime(Time pLeftTime, Time pRightTime)
        {
            Time result = new Time();
            int secres=0;
            int sec1 = (pLeftTime.Hour * 3600) + (pLeftTime.Minute * 60);
            int sec2 = (pRightTime.Hour * 3600) + (pRightTime.Minute * 60);
            if (sec1 >= sec2)
            {
                secres = sec1 / sec2;
            }
            else
            {
                secres = sec2 / sec1;
            }
            Console.WriteLine("secres:{0}",secres);
            result.Hour = secres / 3600;
            Console.WriteLine("h:{0}", result.Hour);
            secres = secres % 3600;
            result.Minute = secres / 60;
            return result;
        }
    }
}
