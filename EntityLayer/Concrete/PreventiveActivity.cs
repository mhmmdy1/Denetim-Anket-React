using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PreventiveActivity : BaseEntity
    {
        public virtual InspectionUnsuitability Unsuitability { get; set; }
       // public virtual Account CreateAccount { get; set; }
        public virtual string Problem { get; set; }
        public virtual string Explanation { get; set; }
        public virtual int Status { get; set; }
        public virtual DateTime Deadline { get; set; }
        public virtual string CompletionExplanation { get; set; }
        public virtual Company Company { get; set; }
        public virtual Account Account { get; set; }
        public int AccountFK { get; set; }

    }
}
