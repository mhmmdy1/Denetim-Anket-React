using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFacilityServiceService
    {
        void FFacilityServiceAdd(FacilityService facilityService);

        void FacilityServiceDelete(FacilityService facilityService);

        void FacilityServiceUpdate(FacilityService facilityService);
        List<FacilityService> GetList();
        FacilityService GetById(int id);
    }
}
