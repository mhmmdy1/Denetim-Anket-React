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
    public class FacilityManager : IFacilityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FacilityManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void FacilityAdd(Facility facility)
        {
            _unitOfWork.FacilityDAL.Insert(facility);
        }

        public void FacilityDelete(Facility facility)
        {
            _unitOfWork.FacilityDAL.Delete(facility);
        }

        public void FacilityUpdate(Facility facility)
        {
            _unitOfWork.FacilityDAL.Update(facility);
        }

        public Facility GetById(int id)
        {
            return _unitOfWork.FacilityDAL.GetById(id);
        }

        public List<Facility> GetList()
        {
            return _unitOfWork.FacilityDAL.GetListAll();
        }

        public Facility GeyByCode(string code)
        {
            return _unitOfWork.FacilityDAL.GetByCode(code);
        }
    }
}
