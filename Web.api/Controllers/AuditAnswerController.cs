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
    public class AuditAnswerController : ControllerBase
    {
        private readonly IAuditAnswersService _auditAnswersService;

        public AuditAnswerController(IAuditAnswersService auditAnswersService)
        {
            this._auditAnswersService = auditAnswersService;
        }
        [HttpGet("getall")]
        public List<AuditAnswers> GetList()
        {
            return _auditAnswersService.GetList();
        }

        [HttpGet("{id:int}")]
        public AuditAnswers GetById(int id)
        {
            return _auditAnswersService.GetById(id);
        }
        [HttpDelete]
        public void AnswerSetDelete(AuditAnswers auditAnswers)
        {
            _auditAnswersService.AuditAnswersDelete(auditAnswers);
        }
        [HttpPost]
        public void AnswerSetAdd(AuditAnswers auditAnswers)
        {
            _auditAnswersService.AuditAnswersAdd(auditAnswers);
        }
        [HttpPut]
        public void AnswerSetUpdate(AuditAnswers auditAnswers)
        {
            _auditAnswersService.AuditAnswersUpdate(auditAnswers);
        }
    }
}
