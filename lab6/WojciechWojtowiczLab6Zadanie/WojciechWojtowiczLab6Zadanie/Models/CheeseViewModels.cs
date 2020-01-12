using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab6Zadanie.Models
{
    public class CheeseViewModels
    {
        /// <summary>
        /// imię
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// cena
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// zdjęcie
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// konstruktor z parametrami
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="photo"></param>
        public CheeseViewModels(string name, int price, string photo)
        {
            Name = name;
            Price = price;
            Photo = photo;
        }
    }
}
