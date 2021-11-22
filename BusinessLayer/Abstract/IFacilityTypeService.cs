using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IFacilityTypeService
    {
        void FacilityTypeAdd(FacilityType facilityType);

        void FacilityTypeDelete(FacilityType facilityType);

        void FacilityTypeUpdate(FacilityType facilityType);
        List<FacilityType> GetList();
        FacilityType GetById(int id);
    }
}
