using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.api.Models.Register
{
    public class RegisterFormModel
    {
        public string CompanyName { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyCity { get; set; }
        public string UserFullName { get; set; }
        public string UserMail { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserPassword { get; set; }
    }
}
