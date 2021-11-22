using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Audit : BaseEntity
    {
        public virtual InspectionSet InspectionSet { get; set; }
        public virtual string AuditName { get; set; }
        public virtual Account Supervisor { get; set; }
        public virtual bool IsCompleted { get; set; }
        public virtual bool OnGoing { get; set; }
        public virtual string ImagePath { get; set; }
        public virtual string Question { get; set; }
        public virtual string Answer { get; set; }
        public virtual decimal CompletionPoint { get; set; }
        public virtual Room Room { get; set; }
        public virtual SISService SISService { get; set; }
        public virtual Period Period { get; set; }
        public virtual Company Company { get; set; }
     
    }
}
