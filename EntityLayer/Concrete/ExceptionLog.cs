using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ExceptionLog
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual int AccountId { get; set; }
        public virtual string ActionName { get; set; }
        public virtual string ControllerName { get; set; }
        public virtual string Message { get; set; }
        public virtual string HttpCode { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string Location { get; set; }
        public virtual string Source { get; set; }
        public virtual string StackTrace { get; set; }
    }
}
