using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IInspectionSetService
    {
        void InspectionSetAdd(InspectionSet ınspectionSet);

        void InspectionSetDelete(InspectionSet ınspectionSet);

        void InspectionSetUpdate(InspectionSet ınspectionSet);
        List<InspectionSet> GetList();
        InspectionSet GetById(int id);
    }
}
