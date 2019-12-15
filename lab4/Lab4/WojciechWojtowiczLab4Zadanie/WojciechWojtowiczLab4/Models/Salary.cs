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
    class Salary
    {
        [Key]
        public int Id { get; set; }

        public int SponsorId { get; set; }
        [ForeignKey("SponsorId")]
        public virtual Sponsor Sponsor { get; set; }

        [DisplayName("Zarobki")]
        public float AllCash { get; set; }
    }
}
