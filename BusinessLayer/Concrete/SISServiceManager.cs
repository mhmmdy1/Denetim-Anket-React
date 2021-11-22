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
    public class SISServiceManager : ISISServiceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SISServiceManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public SISService GetById(int id)
        {
            return _unitOfWork.SISServicesDAL.GetById(id);
        }

        public List<SISService> GetList()
        {
            return _unitOfWork.SISServicesDAL.GetListAll();
        }

        public void SISServiceAdd(SISService sISService)
        {
            _unitOfWork.SISServicesDAL.Insert(sISService);
        }

        public void SISServiceDelete(SISService sISService)
        {
            _unitOfWork.SISServicesDAL.Delete(sISService);
        }

        public void SISServiceUpdate(SISService sISService)
        {
            _unitOfWork.SISServicesDAL.Update(sISService);
        }
    }
}

