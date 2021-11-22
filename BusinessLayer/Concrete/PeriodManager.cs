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
    public class PeriodManager : IPeriodService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PeriodManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public Period GetById(int id)
        {
            return _unitOfWork.PeriodsDAL.GetById(id);
        }

        public List<Period> GetList()
        {
            return _unitOfWork.PeriodsDAL.GetListAll();
        }

        public void PeriodAdd(Period period)
        {
            _unitOfWork.PeriodsDAL.Insert(period);
        }

        public void PeriodDelete(Period period)
        {
            _unitOfWork.PeriodsDAL.Delete(period);
        }

        public void PeriodUpdate(Period period)
        {
            _unitOfWork.PeriodsDAL.Update(period);
        }
    }
}
