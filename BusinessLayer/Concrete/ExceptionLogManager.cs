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
    public class ExceptionLogManager : IExceptionLogService
    {
        private readonly IUnitOfWork _unitOfWork;


        public ExceptionLogManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void ExceptionLogAdd(ExceptionLog exceptionLog)
        {
            _unitOfWork.ExceptionLogsDAL.Insert(exceptionLog);
        }

        public void ExceptionLogDelete(ExceptionLog exceptionLog)
        {
            _unitOfWork.ExceptionLogsDAL.Delete(exceptionLog);
        }

        public void ExceptionLogUpdate(ExceptionLog exceptionLog)
        {
            _unitOfWork.ExceptionLogsDAL.Update(exceptionLog);
        }

        public ExceptionLog GetById(int id)
        {
          return _unitOfWork.ExceptionLogsDAL.GetById(id);
        }

        public List<ExceptionLog> GetList()
        {
            return _unitOfWork.ExceptionLogsDAL.GetListAll();
        }
    }
}
