﻿using System;
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
            string s = $"Heure={Hour}:{Minute}";
            return s;
        }

        private void AdjustTime()
        {
            if (this.Minute > 59)
            {
                this.Hour = this.Hour + (this.Minute / 60);
                this.Minute = this.Minute % 60;
            }
            else if (this.Minute < 0)
            {
                this.Hour = this.Hour + (this.Minute / 60) - 1;
                this.Minute = 60 + (this.Minute % 60);
            }
            if (this.Hour < 0)
            {
                this.Hour = 0;
                this.Minute = 0;
            }
        }

        public static Time AddTime(Time pLeftTime, Time pRightTime)
        {
            Time result = new Time();
            result.Hour = pLeftTime.Hour + pRightTime.Hour;
            result.Minute = pLeftTime.Minute + pRightTime.Minute;
            result.AdjustTime();
            return result;
        }

        public static Time SubTime(Time pLeftTime, Time pRightTime)
        {
            Time result = new Time();
            result.Hour = pLeftTime.Hour - pRightTime.Hour;
            result.Minute = pLeftTime.Minute - pRightTime.Minute;
            result.AdjustTime();
            return result;
        }

        public static Time MulTime(Time pTime, int pMultiplicator)
        {
            Time result = new Time();
            result.Hour = pTime.Hour * pMultiplicator;
            result.Minute = pTime.Minute * pMultiplicator;
            result.AdjustTime();
            return result;
        }
        public static Time DivTime(Time pTime, int pDivisor)
        {
            Time result = new Time();
            result.Hour = 0;
            result.Minute = (pTime.Hour * 60 + pTime.Minute) / pDivisor;
            result.AdjustTime();
            return result;
        }
    }
}
