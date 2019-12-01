using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WojciechWojtowiczLab2Zadanie
{
    class Bream : Fish
    {

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="levelLake"></param>
        public Bream(int levelLake)
        {
            weight = parametersOfFish.Next(1, 3) * levelLake;
            lenght = parametersOfFish.Next(1, 20) * levelLake;
            name = "Leszcz";
        }

        /// <summary>
        /// metoda zwraca 0
        /// </summary>
        /// <returns></returns>
        public override int GetProtectiveLenght()
        {
            return 0;
        }

        /// <summary>
        /// metoda zwraca komentarz w postaci string
        /// </summary>
        /// <returns></returns>
        public override string GetProtectiveLenghtOfFish()
        {
            return "Brak wymiaru ochronnego.";
        }
    }
}
