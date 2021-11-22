using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AccountRole : BaseEntity
    {
        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
        public virtual Company Company { get; set; }
   

    }
}