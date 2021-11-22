using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Role : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual IList<RoleAuthorization> RoleAuthorizations { get; set; }
        public virtual Company Company { get; set; }
    }
}
