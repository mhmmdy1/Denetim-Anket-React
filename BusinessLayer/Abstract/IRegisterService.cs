using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.api.Models.Register;

namespace BusinessLayer.Abstract
{
    public interface IRegisterService
    {
        void RegisterAdd(RegisterFormModel registerFormModel);

     
    }
}
