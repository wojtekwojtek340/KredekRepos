﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WojciechWojtowiczLab4.Models
{
    class Country
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nazwa kraju")]
        public string Name { get; set; }

        [DisplayName("Rekord kraju")]
        public float CountryRecord { get; set; }

        public virtual List<Jumper> Jumpers { get; set; }

        /// <summary>
        /// metoda zwracajaca nazwe obiektu
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
