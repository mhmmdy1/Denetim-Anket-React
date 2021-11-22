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
    public class FacilityServiceManager : IFacilityServiceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FacilityServiceManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void FacilityServiceDelete(FacilityService facilityService)
        {
            _unitOfWork.FacilityServiceDAL.Delete(facilityService);
        }

        public void FacilityServiceUpdate(FacilityService facilityService)
        {
            _unitOfWork.FacilityServiceDAL.Update(facilityService);
        }

        public void FFacilityServiceAdd(FacilityService facilityService)
        {
            _unitOfWork.FacilityServiceDAL.Insert(facilityService);
        }

        public FacilityService GetById(int id)
        {
            return _unitOfWork.FacilityServiceDAL.GetById(id);
        }

        public List<FacilityService> GetList()
        {
            return _unitOfWork.FacilityServiceDAL.GetListAll();
        }
    }
}
