using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AuditAnswers : BaseEntity
    {
        public int AuditAnswerId { get; set; }
        public virtual int AnswerId { get; set; }
        public virtual string Answer { get; set; }
        public virtual int QuestionId { get; set; }
        public virtual Audit Audit { get; set; }

        public virtual Company Company { get; set; }
     
        public ICollection<InspectionUnsuitability> ınspectionUnsuitabilities { get; set; }

    }
}
