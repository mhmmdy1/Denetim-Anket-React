using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MembershipPackages : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual int MaxAccount { get; set; }
        public virtual int MaxUsage { get; set; }
        public virtual double Price { get; set; } // For Month
        public virtual int Rank { get; set; } // For Month
        public virtual string Description { get; set; } // For Month
        public virtual Company Company { get; set; }


    }
}