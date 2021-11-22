
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
    public class AuditAnswersManager : IAuditAnswersService
    {
        private readonly IUnitOfWork _unitOfWork;


        public AuditAnswersManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void AuditAnswersAdd(AuditAnswers auditAnswers)
        {
            _unitOfWork.AuditAnswersDAL.Insert(auditAnswers);
        }

        public void AuditAnswersDelete(AuditAnswers auditAnswers)
        {
            _unitOfWork.AuditAnswersDAL.Delete(auditAnswers);
        }

        public void AuditAnswersUpdate(AuditAnswers auditAnswers)
        {
            _unitOfWork.AuditAnswersDAL.Update(auditAnswers);
        }

        public AuditAnswers GetById(int id)
        {
            return _unitOfWork.AuditAnswersDAL.GetById(id);
        }

        public List<AuditAnswers> GetList()
        {
            return _unitOfWork.AuditAnswersDAL.GetListAll();
        }
    }
}
