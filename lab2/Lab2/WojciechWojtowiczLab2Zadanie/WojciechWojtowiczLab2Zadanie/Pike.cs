using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab2Zadanie
{
    class Pike : Fish //dziedziczy po Fish
    {
        //rozmiar ochronny
        int protectiveLenght;

        /// <summary>
        /// konstrutor tworzacy obiekt w zaleznosci od poziomu jeziora
        /// </summary>
        /// <param name="levelLake"></param>
        public Pike(int levelLake)
        {
            name = "Szczupak";
            weight = parametersOfFish.Next(1, 3) * levelLake;
            lenght = parametersOfFish.Next(1, 30) * levelLake;
            protectiveLenght = 50;
        }

        /// <summary>
        /// metoda zwraca rozmiar ochronny w postaci Int
        /// </summary>
        /// <returns></returns>
        public override int GetProtectiveLenght()
        {
            return protectiveLenght;
        }

        /// <summary>
        /// metoda zwraca rozmiar ochronny z dopiskiem w postaci String
        /// </summary>
        /// <returns></returns>
        public override string GetProtectiveLenghtOfFish()
        {
            return "Wymiar ochronny: " + protectiveLenght.ToString();
        }
    }
}
