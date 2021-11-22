using EntityLayer.Concrete; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFacilityService
    {
        void FacilityAdd(Facility facility);

        void FacilityDelete(Facility facility);

        void FacilityUpdate(Facility facility );
        List<Facility> GetList();
        Facility GetById(int id);
        Facility GeyByCode(string code);
    }
}
