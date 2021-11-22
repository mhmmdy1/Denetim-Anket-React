using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BaseEntity
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual int CreateUser { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual int UpdateUser { get; set; }
        public virtual DateTime? UpdateDate { get; set; }
    }


}
   

    