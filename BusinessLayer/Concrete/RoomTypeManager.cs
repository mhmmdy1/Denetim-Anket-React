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
    public class RoomTypeManager : IRoomTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomTypeManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public RoomType GetById(int id)
        {
            return _unitOfWork.RoomTypesDAL.GetById(id);
        }

        public List<RoomType> GetList()
        {
            return _unitOfWork.RoomTypesDAL.GetListAll();
        }

        public void RoomTypeAdd(RoomType roomType)
        {
            _unitOfWork.RoomTypesDAL.Insert(roomType);
        }

        public void RoomTypeDelete(RoomType roomType)
        {
            _unitOfWork.RoomTypesDAL.Delete(roomType);
        }

        public void RoomTypeUpdate(RoomType roomType)
        {
            _unitOfWork.RoomTypesDAL.Update(roomType);
        }
    }
}
