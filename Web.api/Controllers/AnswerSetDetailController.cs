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
    public class AnswerSetDetailController : ControllerBase
    {
        private readonly IAnswerSetDetailService _answerSetDetailService;

        public AnswerSetDetailController(IAnswerSetDetailService answerSetDetailService)
        {
            this._answerSetDetailService = answerSetDetailService;
        }
        [HttpGet("getall")]
        public List<AnswerSetDetail> GetList()
        {
            return _answerSetDetailService.GetList();
        }

        [HttpGet("{id:int}")]
        public AnswerSetDetail GetById(int id)
        {
            return _answerSetDetailService.GetById(id);
        }
        [HttpDelete]
        public void AnswerSetDetailDelete(AnswerSetDetail answerSetDetail)
        {
            _answerSetDetailService.AnswerSetDetailDelete(answerSetDetail);
        }
        [HttpPost]
        public void AnswerSetDetailAdd(AnswerSetDetail answerSetDetail)
        {
            _answerSetDetailService.AnswerSetDetailAdd(answerSetDetail);
        }
        [HttpPut]
        public void AnswerSetDetailUpdate(AnswerSetDetail answerSetDetail)
        {
            _answerSetDetailService.AnswerSetDetailUpdate(answerSetDetail);
        }
    }
    }
