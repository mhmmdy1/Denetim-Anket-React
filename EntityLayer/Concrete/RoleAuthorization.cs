using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RoleAuthorization : BaseEntity
    {
        public virtual Role Role { get; set; }
        public virtual SISAction Action { get; set; }
        public virtual bool IsAuthorized { get; set; }
        public virtual Company Company { get; set; }

    }
}
