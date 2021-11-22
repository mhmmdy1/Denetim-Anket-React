using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IInspectionUnsuitabilityService
    {
        void InspectionUnsuitabilityAdd(InspectionUnsuitability ınspectionUnsuitability);

        void InspectionUnsuitabilityDelete(InspectionUnsuitability ınspectionUnsuitability);

        void InspectionUnsuitabilityUpdate(InspectionUnsuitability ınspectionUnsuitability);
        List<InspectionUnsuitability> GetList();
        InspectionUnsuitability GetById(int id);
    }
}
