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
    public class InspectionSetQuestionsController : ControllerBase
    {
        private readonly IInspectionSetQuestionsService _ınspectionSetQuestionsService;

        public InspectionSetQuestionsController(IInspectionSetQuestionsService ınspectionSetQuestionsService)
        {
            this._ınspectionSetQuestionsService = ınspectionSetQuestionsService;
        }
        [HttpGet]
        public List<InspectionSetQuestion> GetList()
        {
            return _ınspectionSetQuestionsService.GetList();
        }

        [HttpGet("{id:int}")]
        public InspectionSetQuestion GetById(int id)
        {
            return _ınspectionSetQuestionsService.GetById(id);
        }
        [HttpDelete]
        public void InspectionSetQuestionDelete(InspectionSetQuestion ınspectionSetQuestion)
        {
            _ınspectionSetQuestionsService.InspectionSetQuestionDelete(ınspectionSetQuestion);
        }
        [HttpPost]
        public void InspectionSetQuestionAdd(InspectionSetQuestion ınspectionSetQuestion)
        {
            _ınspectionSetQuestionsService.InspectionSetQuestionAdd(ınspectionSetQuestion);
        }
        [HttpPut]
        public void InspectionSetQuestionUpdate(InspectionSetQuestion ınspectionSetQuestion)
        {
            _ınspectionSetQuestionsService.InspectionSetQuestionUpdate(ınspectionSetQuestion);
        }
    }
}
