using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WojciechWojtowiczLab4.Models
{
    class Sponsor
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nazwa sponsora")]
        public string Name { get; set; }

        [DisplayName("Miesieczna wyplata")]
        public float Cash { get; set; }

        public int JumperId { get; set; }
        [ForeignKey("JumperId")]
        public virtual Jumper Jumper { get; set; }

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
