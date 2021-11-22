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
    public class FacilityTypeManager : IFacilityTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FacilityTypeManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void FacilityTypeAdd(FacilityType facilityType)
        {
            _unitOfWork.FacilityTypesDAL.Insert(facilityType);
        }

        public void FacilityTypeDelete(FacilityType facilityType)
        {
            _unitOfWork.FacilityTypesDAL.Delete(facilityType);
        }

        public void FacilityTypeUpdate(FacilityType facilityType)
        {
            _unitOfWork.FacilityTypesDAL.Update(facilityType);
        }

        public FacilityType GetById(int id)
        {
            return _unitOfWork.FacilityTypesDAL.GetById(id);
        }

        public List<FacilityType> GetList()
        {
            return _unitOfWork.FacilityTypesDAL.GetListAll();
        }
    }
}
