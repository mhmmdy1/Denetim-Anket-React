using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRoomTypeService
    {
        void RoomTypeAdd(RoomType roomType);

        void RoomTypeDelete(RoomType roomType);

        void RoomTypeUpdate(RoomType roomType);
        List<RoomType> GetList();
        RoomType GetById(int id);
    }
}
