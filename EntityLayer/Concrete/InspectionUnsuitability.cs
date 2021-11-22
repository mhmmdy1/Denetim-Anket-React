using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class InspectionUnsuitability : BaseEntity
    {
        public virtual Account Account { get; set; }
        public virtual InspectionSetQuestion InspectionSetQuestion { get; set; }
        public virtual Audit Audit { get; set; }
        public virtual List<PreventiveActivity> PreventiveActivity { get; set; }
        public virtual AnswerSetDetail AnswerSetDetail { get; set; }
        public virtual string Explanation { get; set; }
        public virtual DateTime Deadline { get; set; }
        public virtual string ImagePath { get; set; }
        public virtual string FileName { get; set; }
        public virtual Company Company { get; set; }

        public virtual AuditAnswers AuditAnswers { get; set; }
        public int AuditAnswerFK { get; set; }

    }
}
