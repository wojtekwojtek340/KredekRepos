using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab4.Models
{
    class SkiJumpingContext :DbContext
    {
        public SkiJumpingContext() : base("AppContext")
        {

        }

        public virtual DbSet<Jumper> Jumpers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
    }
}
