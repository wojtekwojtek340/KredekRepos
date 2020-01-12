using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab6.Models
{
    public class ContactFormViewModel
    {
        /// <summary>
        /// imię
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// nazwisko
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// opis
        /// </summary>
        public string Description { get; set; }
    }
}
