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
    public class PreventiveActivityManager : IPreventiveActivityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PreventiveActivityManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public PreventiveActivity GetById(int id)
        {
            return _unitOfWork.PreventiveActivitiesDAL.GetById(id);
        }

        public List<PreventiveActivity> GetList()
        {
            return _unitOfWork.PreventiveActivitiesDAL.GetListAll();
        }

        public void PreventiveActivityAdd(PreventiveActivity preventiveActivity)
        {
            _unitOfWork.PreventiveActivitiesDAL.Insert(preventiveActivity);
        }

        public void PreventiveActivityDelete(PreventiveActivity preventiveActivity)
        {
            _unitOfWork.PreventiveActivitiesDAL.Delete(preventiveActivity);
        }

        public void PreventiveActivityUpdate(PreventiveActivity preventiveActivity)
        {
            _unitOfWork.PreventiveActivitiesDAL.Update(preventiveActivity);
        }
    }
}
