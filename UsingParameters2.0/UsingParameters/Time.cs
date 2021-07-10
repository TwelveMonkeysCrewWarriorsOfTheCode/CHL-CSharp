﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UsingParameters
{
    public enum TimeType
    {
        NegativeTime = -1,
        PositiveTime = 1
    }
    class Time
    {
        const int NB_MIN_IN_HOUR = 60;

        #region Properties
        public int Hours => Math.Abs(m_TimeInMinutes) / NB_MIN_IN_HOUR;
        public int Minutes => Math.Abs(m_TimeInMinutes) % NB_MIN_IN_HOUR;
        public TimeType Type => m_TimeInMinutes < 0 ? TimeType.NegativeTime : TimeType.PositiveTime;
        #endregion

        private int m_TimeInMinutes;
        private bool m_Result;

        #region Constructors
        public Time(int pTimeInMinutes) => m_TimeInMinutes = pTimeInMinutes;
        public Time(float pTimeInFloat) => m_TimeInMinutes = (int)Math.Round(pTimeInFloat * NB_MIN_IN_HOUR);
        public Time(int pHours, int pMinutes, TimeType pType = TimeType.PositiveTime)
        {
            if (pHours < 0 || pMinutes < 0 || pMinutes >= NB_MIN_IN_HOUR)
            {
                throw new ArgumentOutOfRangeException();
            }
            m_TimeInMinutes = pHours * NB_MIN_IN_HOUR + pMinutes;
            if (pType == TimeType.NegativeTime)
            {
                m_TimeInMinutes = -m_TimeInMinutes;
            }
        }
        
        #endregion

        #region Operators
        public static Time operator +(Time pLeftTime, Time pRightTime) => new Time((int)pLeftTime + (int)pRightTime);
        public static Time operator -(Time pLeftTime, Time pRightTime) => new Time((int)pLeftTime - (int)pRightTime);
        public static Time operator *(Time pTime, int pMultiplier) => new Time((int)pTime * pMultiplier);
        public static Time operator /(Time pTime, int pDivisor) => new Time((int)pTime / pDivisor);

        public static explicit operator int(Time pTime) => pTime.m_TimeInMinutes;
        public static explicit operator float(Time pTime) => (float)pTime.m_TimeInMinutes / NB_MIN_IN_HOUR;
        public static explicit operator Time(int pTimeInMinutes) => new Time(pTimeInMinutes);
        public static explicit operator Time(float pTimeInFloat) => new Time(pTimeInFloat);

        public static bool operator <(Time pLeftTime, Time pRightTime) => (bool)(pLeftTime.m_TimeInMinutes < pRightTime.m_TimeInMinutes ? true : false);
        public static bool operator >(Time pLeftTime, Time pRightTime) => (bool)(pLeftTime.m_TimeInMinutes > pRightTime.m_TimeInMinutes ? true : false);
        public static bool operator <=(Time pLeftTime, Time pRightTime) => (bool)(pLeftTime.m_TimeInMinutes <= pRightTime.m_TimeInMinutes ? true : false);
        public static bool operator >=(Time pLeftTime, Time pRightTime) => (bool)(pLeftTime.m_TimeInMinutes >= pRightTime.m_TimeInMinutes ? true : false);

        #endregion

        public override string ToString() => $"{(Type == TimeType.NegativeTime ? '-' : '\0')}{Hours:d2}:{Minutes:d2}"; // D2 means a decimal with two digits
        // (if (Type == -1)
        // {
        //    return "-Hours:HH:Minutes:MM";
        // }
        // else
        // {
              // It's a string containing the character '\0'. C# doesn't treat this in any particularly special way - it's just unicode character U+0000.
              // In C, it is null character, end of string
        //    return "\0Hours:HH:Minutes:MM";
        // }
    }
}
