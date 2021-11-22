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
    public class FloorManager : IFloorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FloorManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void FloorAdd(Floor facility)
        {
            _unitOfWork.FloorsDAL.Insert(facility);
        }

        public void FloorDelete(Floor facility)
        {
            _unitOfWork.FloorsDAL.Delete(facility);
        }

        public void FloorUpdate(Floor facility)
        {
            _unitOfWork.FloorsDAL.Update(facility);
        }

        public Floor GetById(int id)
        {
            return _unitOfWork.FloorsDAL.GetById(id);
        }

        public List<Floor> GetList()
        {
            return _unitOfWork.FloorsDAL.GetListAll();
        }
    }
}
