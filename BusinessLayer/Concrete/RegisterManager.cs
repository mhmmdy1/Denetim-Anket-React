using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.api.Models.Register;

namespace BusinessLayer.Concrete
{
   public class RegisterManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public RegisterManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void registerAdd(RegisterFormModel registerFormModel)
        {
            _unitOfWork.RegisterDAL.Insert(registerFormModel);
        }

    }
}
