using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RecoveryCode
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual Account Account { get; set; }
        public virtual Guid Code { get; set; }
        public virtual bool IsUsed { get; set; }
        public virtual DateTime CreateDate { get; set; }
    }
}
