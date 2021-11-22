using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AnswerSet : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string Code { get; set; }
        public virtual string Explanation { get; set; }

        public virtual Company Company { get; set; }


    }
}
