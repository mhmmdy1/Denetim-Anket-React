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
    public class InspectionUnsuitabilityManager : IInspectionUnsuitabilityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InspectionUnsuitabilityManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public InspectionUnsuitability GetById(int id)
        {
            return _unitOfWork.InspectionUnsuitabilitiesDAL.GetById(id);
        }

        public List<InspectionUnsuitability> GetList()
        {
            return _unitOfWork.InspectionUnsuitabilitiesDAL.GetListAll();
        }

        public void InspectionUnsuitabilityAdd(InspectionUnsuitability ınspectionUnsuitability)
        {
            _unitOfWork.InspectionUnsuitabilitiesDAL.Insert(ınspectionUnsuitability);
        }

        public void InspectionUnsuitabilityDelete(InspectionUnsuitability ınspectionUnsuitability)
        {
            _unitOfWork.InspectionUnsuitabilitiesDAL.Delete(ınspectionUnsuitability);
        }

        public void InspectionUnsuitabilityUpdate(InspectionUnsuitability ınspectionUnsuitability)
        {
            _unitOfWork.InspectionUnsuitabilitiesDAL.Update(ınspectionUnsuitability);
        }
    }
}
