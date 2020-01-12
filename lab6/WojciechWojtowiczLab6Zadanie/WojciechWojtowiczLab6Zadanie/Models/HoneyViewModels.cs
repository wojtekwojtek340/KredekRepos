using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab6Zadanie.Models
{
    public class HoneyViewModels
    {
        /// <summary>
        /// imię
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// nazwisko
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// zdjecie
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="photo"></param>
        public HoneyViewModels(string name, int price, string photo)
        {
            Name = name;
            Price = price;
            Photo = photo;
        }
    }
}
