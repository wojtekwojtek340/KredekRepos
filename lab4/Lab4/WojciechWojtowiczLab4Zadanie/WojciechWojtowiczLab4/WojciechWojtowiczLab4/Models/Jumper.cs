using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab4.Models
{
    class Jumper
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(250)]
        [DisplayName("Imię")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Pole nazwisko jest wymagane")]
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }

        [DisplayName("Data urodzin")]
        public DateTime Birtdate { get; set; }

        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }


        /// <summary>
        /// metoda zwracajaca nazwe obiektu
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
