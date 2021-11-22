using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RecoveryCodeManager : IRecoveryCodeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RecoveryCodeManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public RecoveryCode GetById(int id)
        {
            return _unitOfWork.RecoveryCodesDAL.GetById(id);
        }

        public List<RecoveryCode> GetList()
        {
            return _unitOfWork.RecoveryCodesDAL.GetListAll();
        }

        public void RecoveryCodeAdd(RecoveryCode recoveryCode)
        {
            _unitOfWork.RecoveryCodesDAL.Insert(recoveryCode);
        }

        public void RecoveryCodeDelete(RecoveryCode recoveryCode)
        {
            _unitOfWork.RecoveryCodesDAL.Delete(recoveryCode);
        }

        public void RecoveryCodeUpdate(RecoveryCode recoveryCode)
        {
            _unitOfWork.RecoveryCodesDAL.Update(recoveryCode);
        }
    }
}
