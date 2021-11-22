using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IRoomService
    {
        void RoomAdd(Room room);

        void RoomDelete(Room room);

        void RoomUpdate(Room room);
        List<Room> GetList();
        Room GetById(int id);
    }
}
