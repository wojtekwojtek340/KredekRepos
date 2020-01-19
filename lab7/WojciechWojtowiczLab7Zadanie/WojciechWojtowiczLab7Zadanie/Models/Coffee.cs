using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab7Zadanie.Models
{
    /// <summary>
    /// klasa kawa
    /// </summary>
    public class Coffee
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// nazwa
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// opis
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// cena
        /// </summary>
        public decimal Cost { get; set; }

    }
}
