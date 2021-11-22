using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AnswerSetDetail : BaseEntity
    {
        public virtual AnswerSet AnswerSet { get; set; }
        public virtual int ImportanceLevels { get; set; }
        public virtual bool Negative { get; set; }
        public virtual bool NonEvaluation { get; set; }
        public virtual string Answer { get; set; }
        public virtual Company Company { get; set; }
      

    }
}
