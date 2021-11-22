using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class LocationAuthorization : BaseEntity
    {
        public virtual int AccountId { get; set; }
        public virtual int RoleId { get; set; }
        public virtual int FacilityId { get; set; }
        public virtual int BlockId { get; set; }
        public virtual int FloorId { get; set; }
        public virtual int RoomId { get; set; }
        public virtual bool IsAuthorized { get; set; }
        public virtual Company Company { get; set; }


    }
}
