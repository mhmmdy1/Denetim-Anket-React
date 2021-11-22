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
    public class AuditManager : IAuditService
    {
        private readonly IUnitOfWork _unitOfWork;


        public AuditManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void AuditDelete(Audit audit)
        {
            _unitOfWork.AuditDAL.Delete(audit);
        }

        public void AuditAdd(Audit audit)
        {
            _unitOfWork.AuditDAL.Insert(audit);
        }

        public void AuditUpdate(Audit audit)
        {
            _unitOfWork.AuditDAL.Update(audit);
        }

        public Audit GetById(int id)
        {
            return _unitOfWork.AuditDAL.GetById(id);
        }

        public List<Audit> GetList()
        {
            return _unitOfWork.AuditDAL.GetListAll();
        }
    }
}
