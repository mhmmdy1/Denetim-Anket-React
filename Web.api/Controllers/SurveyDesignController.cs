using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class SurveyesignController : ControllerBase
    {
        private readonly ISurveyDesignService _surveyDesignService;

        public SurveyesignController(ISurveyDesignService surveyDesignService)
        {
            this._surveyDesignService = surveyDesignService;
        }
        [HttpGet]
        public List<SurveyDesign> GetList()
        {
            return _surveyDesignService.GetList();
        }

        [HttpGet("{id:int}")]
        public SurveyDesign GetById(int id)
        {
            return _surveyDesignService.GetById(id);
        }
        [HttpDelete]
        public void SurveyDesignDelete(SurveyDesign surveyDesign)
        {
            _surveyDesignService.SurveyDesignDelete(surveyDesign);
        }
        [HttpPost]
        public void SurveyDesignAdd(SurveyDesign surveyDesign)
        {
            _surveyDesignService.SurveyDesignAdd(surveyDesign);
        }
        [HttpPut]
        public void SurveyDesignUpdate(SurveyDesign surveyDesign)
        {
            _surveyDesignService.SurveyDesignUpdate(surveyDesign);
        }
    }
}
