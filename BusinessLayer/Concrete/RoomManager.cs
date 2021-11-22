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
     public  class RoomManager : IRoomService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public Room GetById(int id)
        {
            return _unitOfWork.RoomsDAL.GetById(id);
        }

        public List<Room> GetList()
        {
            return _unitOfWork.RoomsDAL.GetListAll();
        }

        public void RoomAdd(Room room)
        {
            _unitOfWork.RoomsDAL.Insert(room);
        }

        public void RoomDelete(Room room)
        {
            _unitOfWork.RoomsDAL.Delete(room);
        }

        public void RoomUpdate(Room room)
        {
            _unitOfWork.RoomsDAL.Update(room);
        }
    }
}
