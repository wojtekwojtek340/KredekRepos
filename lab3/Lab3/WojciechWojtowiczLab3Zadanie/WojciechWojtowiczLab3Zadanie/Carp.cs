using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab3Zadanie
{
    class Carp : Fish
    {
        //rozmiar ochronny
        int protectiveLenght = 0;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="levelLake"></param>
        public Carp(int levelLake)
        {
            name = "Karp";
            weight = parametersOfFish.Next(1, 3) * levelLake;
            lenght = parametersOfFish.Next(1, 18) * levelLake;
            protectiveLenght = 25;
        }

        /// <summary>
        /// metoda zwracajca rozmiar ochronny w postaci int
        /// </summary>
        /// <returns></returns>
        public override int GetProtectiveLenght()
        {
            return protectiveLenght;
        }

        /// <summary>
        /// metoda zwracajca rozmiar ochronny z dopiskiem w postaci string
        /// </summary>
        /// <returns></returns>
        public override string GetProtectiveLenghtOfFish()
        {
            return "Wymiar ochronny: " + protectiveLenght.ToString();
        }
    }
}
