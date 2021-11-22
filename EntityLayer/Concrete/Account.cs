using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Account
    {
        [Key]
        public virtual int AccountId { get; set; } 
        public virtual string NameSurname { get; set; }
        public virtual string AccountPhoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual bool IsAdmin { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual int CreateUser { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual int UpdateUser { get; set; }
        public virtual DateTime? UpdateDate { get; set; }
        public  Company Company { get; set; }
        public ICollection<PreventiveActivity> preventiveActivities { get; set; }

    }
}
