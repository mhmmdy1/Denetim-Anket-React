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
    public class ServiceController : ControllerBase
    {
        private readonly ISISServiceService _sısServiceService;

        public ServiceController(ISISServiceService sısServiceService)
        {
            this._sısServiceService = sısServiceService;
        }
        [HttpGet]
        public List<SISService> GetList()
        {
            return _sısServiceService.GetList();
        }

        [HttpGet("{id:int}")]
        public SISService GetById(int id)
        {
            return _sısServiceService.GetById(id);
        }
        [HttpDelete]
        public void SurveyDesignDelete(SISService surveyDesign)
        {
            _sısServiceService.SISServiceDelete(surveyDesign);
        }
        [HttpPost]
        public void SurveyDesignAdd(SISService surveyDesign)
        {
            _sısServiceService.SISServiceDelete(surveyDesign);
        }
        [HttpPut]
        public void SurveyDesignUpdate(SISService surveyDesign)
        {
            _sısServiceService.SISServiceUpdate(surveyDesign);
        }
    }
}
