using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab3Zadanie
{
    //klasa time odpowiada za liczenie czasu w grze
    public class Time
    {
        // 3 zmienne godzina, dzien, tydzien
        int hour;
        int day;
        int week;

        /// <summary>
        /// konstruktor ustawia zmienne na 0
        /// </summary>
        public Time()
        {
            hour = 0;
            day = 0;
            week = 0;
        }

        /// <summary>
        /// akcesor do pobierania lub ustawania godziny
        /// </summary>
        public int Hour { get => hour; set => hour = value; }

        /// <summary>
        /// akcesor do pobierania lub ustawania dnia
        /// </summary>
        public int Day { get => day; set => day = value; }

        /// <summary>
        /// akcesor do pobierania lub ustawania tygodnia
        /// </summary>
        public int Week { get => week; set => week = value; }

        /// <summary>
        /// metoda inkrementuje godzine, w zaleznosci od stanu modyfikuje resztę pol
        /// </summary>
        public void Increment()
        {
            hour++;
            if (hour == 24)
            {
                hour = 0;
                day++;
                if (day == 7)
                {
                    day = 0;
                    week++;
                }
            }
        }    
    }
}
