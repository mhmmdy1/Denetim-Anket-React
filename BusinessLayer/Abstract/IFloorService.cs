using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IFloorService
    {
        void FloorAdd(Floor facility);

        void FloorDelete(Floor facility);

        void FloorUpdate(Floor facility);
        List<Floor> GetList();
        Floor GetById(int id);
    }
}
