using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab2Zadanie
{
    public abstract class Fish
    {
        //pole typu Random uzywane do tworzenia ryby, okreslenia jej wymiarów (losowo)
        protected System.Random parametersOfFish = new Random(System.DateTime.Now.Millisecond);
        //dlugosc
        protected int lenght;
        //waga
        protected int weight;
        //nazwa
        protected string name;

        /// <summary>
        /// Metoda zwraca nazwe
        /// </summary>
        /// <returns></returns>
        virtual public string GetNameOfFish()
        {
            return name;
        }

        /// <summary>
        /// metoda zwracajaca rozmiar
        /// </summary>
        /// <returns></returns>
        virtual public int GetLenghtOfFich()
        {
            return lenght;
        }

        /// <summary>
        /// metoda zwracajaca wage
        /// </summary>
        /// <returns></returns>
        virtual public int GetWeightOfFish()
        {
            return weight;
        }

        /// <summary>
        /// metoda abstrakcyjna
        /// </summary>
        /// <returns></returns>
        abstract public string GetProtectiveLenghtOfFish();

        /// <summary>
        /// metoda abstrakcyjna
        /// </summary>
        /// <returns></returns>
        abstract public int GetProtectiveLenght();
    }
}
