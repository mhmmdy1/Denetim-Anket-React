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
    public class AuditController : ControllerBase
    {
        private readonly IAuditService _auditService;

        public AuditController(IAuditService auditService)
        {
            this._auditService = auditService;
        }
        [HttpGet]
        public List<Audit> GetList()
        {
            return _auditService.GetList();
        }

        [HttpGet("{id:int}")]
        public Audit GetById(int id)
        {
            return _auditService.GetById(id);
        }
        [HttpDelete]
        public void AuditDelete(Audit audit)
        {
            _auditService.AuditDelete(audit);
        }
        [HttpPost]
        public void AuditAdd(Audit audit)
        {
            _auditService.AuditAdd(audit);
        }
        [HttpPut]
        public void AuditUpdate(Audit audit)
        {
            _auditService.AuditUpdate(audit);
        }
    }
}
