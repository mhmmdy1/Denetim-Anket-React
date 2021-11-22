using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IInspectionSetQuestionsService
    {
        void InspectionSetQuestionAdd(InspectionSetQuestion ınspectionSetQuestion);

        void InspectionSetQuestionDelete(InspectionSetQuestion ınspectionSetQuestion);

        void InspectionSetQuestionUpdate(InspectionSetQuestion ınspectionSetQuestion);
        List<InspectionSetQuestion> GetList();
        InspectionSetQuestion GetById(int id);
    }
}
