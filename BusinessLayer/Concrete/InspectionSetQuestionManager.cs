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
    public class InspectionSetQuestionManager : IInspectionSetQuestionsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InspectionSetQuestionManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public InspectionSetQuestion GetById(int id)
        {
            return _unitOfWork.InspectionSetQuestionsDAL.GetById(id);
        }

        public List<InspectionSetQuestion> GetList()
        {
            return _unitOfWork.InspectionSetQuestionsDAL.GetListAll();
        }

        public void InspectionSetQuestionAdd(InspectionSetQuestion ınspectionSetQuestion)
        {
            _unitOfWork.InspectionSetQuestionsDAL.Insert(ınspectionSetQuestion);
        }

        public void InspectionSetQuestionDelete(InspectionSetQuestion ınspectionSetQuestion)
        {
            _unitOfWork.InspectionSetQuestionsDAL.Delete(ınspectionSetQuestion);
        }

        public void InspectionSetQuestionUpdate(InspectionSetQuestion ınspectionSetQuestion)
        {
            _unitOfWork.InspectionSetQuestionsDAL.Update(ınspectionSetQuestion);
        }
    }
}
