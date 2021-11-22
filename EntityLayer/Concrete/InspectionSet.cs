using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class InspectionSet : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string Code { get; set; }
        public virtual int PercentageOfPoint { get; set; }
        //public virtual int ControlSetType { get; set; }
        //public virtual AccountType AccountType { get; set; }
        public virtual SISService SISService { get; set; }
        public virtual bool IsEmpty { get; set; }
        public virtual Company Company { get; set; }

    }
}
