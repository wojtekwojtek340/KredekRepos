using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab3Zadanie
{
    public abstract class Enemies
    {
        //pole typu Random uzywane do zdarzen losowych
        protected System.Random moose = new Random(System.DateTime.Now.Millisecond);
        //nazwa
        protected string name;

        /// <summary>
        /// metoda zwracajaca nazwe
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// metoda abstrakcyja do ataku
        /// </summary>
        abstract public void Attack();
    }
}
