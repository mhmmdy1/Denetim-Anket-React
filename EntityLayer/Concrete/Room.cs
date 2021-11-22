using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Room : BaseEntity
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual int FacilityId { get; set; }
        public virtual int BlockId { get; set; }
        public virtual int FloorId { get; set; }
        //public virtual int RoomTypeId { get; set; }
        public virtual Floor Floor { get; set; }
        //public Room()
        //{
        //    Floor = new Floor();
        //    RoomType = new RoomType();
        //}
        public virtual Company Company { get; set; }
    }
}
