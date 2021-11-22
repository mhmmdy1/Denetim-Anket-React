using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
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
    public class AnswerSetController : ControllerBase
    {
        private readonly IAnswerSetService _answerSetService;

        public AnswerSetController(IAnswerSetService answerSetService)
        {
            this._answerSetService = answerSetService;
        }
        [HttpGet("getall")]
        public List<AnswerSet> GetList()
        {
            return _answerSetService.GetList();
        }
       
        [HttpGet("{id:int}")]
        public AnswerSet GetById(int id)
        {
            return _answerSetService.GetById(id);
        }
        [HttpDelete]
        public void AnswerSetDelete(AnswerSet answerSet)
        {
            _answerSetService.AnswerSetDelete(answerSet);
        }
        [HttpPost]
        public void AnswerSetAdd(AnswerSet answerSet)
        {
            _answerSetService.AnswerSetAdd(answerSet);
        }
        [HttpPut]
        public void AnswerSetUpdate(AnswerSet answerSet)
        {
            _answerSetService.AnswerSetUpdate(answerSet);
        }
      //[HttpPost]
      //  public void UpdateStatus(AnswerSet answerSet)
      //  {
      //      if(answerSet.Id <= 0)
      //      {
                  
      //      }
      //  }
    }
}
