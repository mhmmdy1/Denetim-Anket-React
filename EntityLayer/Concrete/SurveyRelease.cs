using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SurveyRelease : BaseEntity
    {
        public virtual SurveyDesign SurveyDesign { get; set; }
        //public virtual Location Location { get; set; }
        public virtual string Name { get; set; }
        public virtual string Code { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual bool Repeated { get; set; }
        public virtual int ValidityPeriod { get; set; }
        public virtual string JsonText { get; set; }
        public virtual Company Company { get; set; }
    }
}
