using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication17.Models
{
    //klasa opisujaca pizze
    public class Pizza
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
        public float Cost { get; set; }
    }
}
