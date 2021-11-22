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
    public class InspectionSetManager : IInspectionSetService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InspectionSetManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public InspectionSet GetById(int id)
        {
            return _unitOfWork.InspectionSetsDAL.GetById(id);
        }

        public List<InspectionSet> GetList()
        {
            return _unitOfWork.InspectionSetsDAL.GetListAll();
        }

        public void InspectionSetAdd(InspectionSet ınspectionSet)
        {
            _unitOfWork.InspectionSetsDAL.Insert(ınspectionSet);
        }

        public void InspectionSetDelete(InspectionSet ınspectionSet)
        {
            _unitOfWork.InspectionSetsDAL.Delete(ınspectionSet);
        }

        public void InspectionSetUpdate(InspectionSet ınspectionSet)
        {
            _unitOfWork.InspectionSetsDAL.Update(ınspectionSet);
        }
    }
}
