using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingParameters
{
    public class Time
    {
        const char SEPARATEUR_HEURE_MINUTE = (char)58; // :
        const int NOMBRE_MAXIMUM_DE_MINUTES = 59;
        public int Hour;
        public int Minute;

        public Time() // Constructeur : pas de paramétres et nom de la classe (constructeur par défault)
        {
            Hour = 0;
            Minute = 0;
        }

        public Time(string pTemps)
        {
            int heurTravail, minuTravail;
            // Tests format
            // Test de garde (précondition)
            if (pTemps.Length != 5) throw new ArgumentException();
            char separateur = pTemps[2];
            if (separateur != SEPARATEUR_HEURE_MINUTE) throw new ArgumentOutOfRangeException();
            string[] detailTemps = pTemps.Split(SEPARATEUR_HEURE_MINUTE);
            if (detailTemps.Length != 2) throw new ArgumentOutOfRangeException();
            if (!int.TryParse(detailTemps[0], out heurTravail)) throw new ArgumentOutOfRangeException("heure", detailTemps[0], "Les heures ne sont pas dans un bon format");
            if (!int.TryParse(detailTemps[1], out minuTravail)) throw new ArgumentOutOfRangeException("minute", detailTemps[1], "Les minutes ne sont pas dans un bon format");
            // Fin des tests de garde (précondition)

            AssignHourMinute(heurTravail, minuTravail);
        }

        public Time(int pHour, int pMinute)
        {
            AssignHourMinute(pHour, pMinute);
        }

        private void AssignHourMinute(int pHour, int pMinute)
        {
            if (pHour < 0 || pHour > 24 || pMinute < 0 || pMinute > NOMBRE_MAXIMUM_DE_MINUTES) throw new ArgumentOutOfRangeException();
            this.Hour = pHour;
            this.Minute = pMinute;
        }

        public override string ToString()
        {
            string s = $"{Hour}:{Minute} min.";
            return s;
        }

        public static Time ChangerFormatEnTime(string pTempsTravail)
        {
            int heurTravail, minuTravail;
            // Tests format
            if (pTempsTravail.Length == 5)
            {
                heurTravail = int.Parse($"{pTempsTravail[0]}{pTempsTravail[1]}");
                if ((heurTravail >= 0) && (heurTravail <= 24))
                {
                    minuTravail = int.Parse($"{pTempsTravail[3]}{pTempsTravail[4]}");
                    if ((minuTravail >= 1) && (minuTravail <= 59))
                    {
                        char separateur = pTempsTravail[2];
                        if (separateur == (char)58)
                        {
                            Time tempsFormat;
                            tempsFormat = new Time();
                            tempsFormat.Hour = heurTravail;
                            tempsFormat.Minute = minuTravail;
                            return tempsFormat;
                        }
                    }
                }
            }
            Time erreurEntree;
            erreurEntree = new Time();
            erreurEntree.Hour = -1;
            erreurEntree.Minute = -1;
            return erreurEntree;
        }


        public static Time AddTime(Time pLeftTime, Time pRightTime)
        {
            Time mResultCorrige = new Time();
            Time mResult = new Time();
            mResult.Hour = pLeftTime.Hour + pRightTime.Hour;
            mResult.Minute = pLeftTime.Minute + pRightTime.Minute;
            mResultCorrige = AdjustTime(mResult);
            //mResultCorrige = ChangerMinutesEnHeures(mResult);
            return mResultCorrige;
        }

        /*public static Time ChangerMinutesEnHeures(Time pTemps)
        {
            Time mResult = new Time();
            int minutes = pTemps.Minute;
            int heures = pTemps.Hour;
            while (minutes >= 60)
            {
                minutes -= 60;
                heures += 1;
            }
            mResult.Hour = heures;
            mResult.Minute = minutes;
            return mResult;
        }*/

        public static Time AdjustTime(Time pTemps)
        {
            Time mResult = new Time();
            int minutes = pTemps.Minute;
            int heures = pTemps.Hour;

            if (minutes > 59)
            {
                heures = heures + (minutes / 60);
                minutes = minutes % 60;
            }
            else if (minutes < 0)
            {
                heures = heures + (minutes / 60) - 1;
                minutes = 60 + (minutes % 60);
            }
            if (heures < 0)
            {
                heures = 0;
                minutes = 0;
            }
            mResult.Hour = heures;
            mResult.Minute = minutes;
            return mResult;
        }

        public static Time SubTime(Time pLeftTime, Time pRightTime)
        {
            Time mResultCorrige = new Time();
            Time mResult = new Time();
            mResult.Hour = pLeftTime.Hour - pRightTime.Hour;
            mResult.Minute = pLeftTime.Minute - pRightTime.Minute;
            mResultCorrige = AdjustTime(mResult);
            return mResultCorrige;
        }

        public static Time MulTime(Time pTime, int pMultiplicator)
        {
            Time mResultCorrige = new Time();
            Time mResult = new Time();
            mResult.Hour = pTime.Hour * pMultiplicator;
            mResult.Minute = pTime.Minute * pMultiplicator;
            mResultCorrige = AdjustTime(mResult);
            return mResultCorrige;
        }

        public static Time DivTime(Time pTime, int pDivisor)
        {
            Time mResultCorrige = new Time();
            Time mResult = new Time();
            mResult.Hour = 0;
            mResult.Minute = (pTime.Hour * 60 + pTime.Minute) / pDivisor;
            mResultCorrige = AdjustTime(mResult);
            return mResultCorrige;
        }
    }
}
