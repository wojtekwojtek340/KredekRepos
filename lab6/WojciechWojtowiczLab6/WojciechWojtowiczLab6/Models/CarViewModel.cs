using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab6.Models
{
    public class CarViewModel
    {
        /// <summary>
        /// Model
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Marka
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// Cena
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// Zdjęcie
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// konstruktor z parametrami
        /// </summary>
        /// <param name="model"></param>
        /// <param name="manufacturer"></param>
        /// <param name="price"></param>
        /// <param name="photo"></param>
        public CarViewModel(string model, string manufacturer, int price, string photo)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Photo = photo;
        }         
    }
}
