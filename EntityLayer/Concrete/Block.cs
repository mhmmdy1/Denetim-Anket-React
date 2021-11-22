using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Block : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string Code { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual IList<Floor> Floors { get; set; }
        public virtual Company Company { get; set; }
    
    }
}
