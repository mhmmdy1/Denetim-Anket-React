using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SurveyDesign : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string JsonText { get; set; }
        public virtual Company Company { get; set; }

    }
}
