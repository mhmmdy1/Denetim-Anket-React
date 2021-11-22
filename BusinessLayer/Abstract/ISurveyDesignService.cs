using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISurveyDesignService
    {
        void SurveyDesignAdd(SurveyDesign surveyDesign);

        void SurveyDesignDelete(SurveyDesign surveyDesign);

        void SurveyDesignUpdate(SurveyDesign surveyDesign);
        List<SurveyDesign> GetList();
        SurveyDesign GetById(int id);
    }
}
