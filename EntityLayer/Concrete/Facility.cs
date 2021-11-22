using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Facility : BaseEntity
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        //public virtual int FacilityTypeId { get; set; }
        public virtual FacilityType FacilityType { get; set; }
        public virtual IList<FacilityService> FacilityServices { get; set; }
        public virtual IList<Block> Blocks { get; set; }
        public virtual Company Company { get; set; }

        public Facility()
        {
            FacilityType = new FacilityType();
            FacilityServices = new List<FacilityService>();
            Blocks = new List<Block>();
        }
    }
}
