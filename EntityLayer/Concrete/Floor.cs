using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Floor : BaseEntity
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual int FacilityId { get; set; }
        public virtual Block Block { get; set; }
        public virtual IList<Room> Rooms { get; set; }
        public virtual Company Company { get; set; }

    }
}
