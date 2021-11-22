using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FacilityService : BaseEntity
    {
        public virtual Facility Facility { get; set; }
        public virtual SISService SISService { get; set; }
        public virtual bool IsMatched { get; set; }
        public virtual Company Company { get; set; }


    }
}
