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
    public class SurveyDesignManager : ISurveyDesignService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SurveyDesignManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public SurveyDesign GetById(int id)
        {
            return _unitOfWork.SurveyDesignsDAL.GetById(id);
        }

        public List<SurveyDesign> GetList()
        {
            return _unitOfWork.SurveyDesignsDAL.GetListAll();
        }

        public void SurveyDesignAdd(SurveyDesign surveyDesign)
        {
            _unitOfWork.SurveyDesignsDAL.Insert(surveyDesign);
        }

        public void SurveyDesignDelete(SurveyDesign surveyDesign)
        {
            _unitOfWork.SurveyDesignsDAL.Delete(surveyDesign);
        }

        public void SurveyDesignUpdate(SurveyDesign surveyDesign)
        {
            _unitOfWork.SurveyDesignsDAL.Update(surveyDesign);
        }
    }
}
