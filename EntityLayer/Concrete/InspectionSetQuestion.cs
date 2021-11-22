using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class InspectionSetQuestion : BaseEntity
    {

        public virtual InspectionSet InspectionSet { get; set; }
        public virtual string Question { get; set; }
        public virtual AnswerSet AnswerSet { get; set; }
        public virtual int SequenceNo { get; set; }
        public virtual InspectionSetQuestion LinkedQuestion { get; set; }
        public virtual int PercentageOfPoint { get; set; }
        //public virtual AnswerSetDetail AnswerSetDetail { get; set; }
        public virtual Company Company { get; set; }

    }
}
