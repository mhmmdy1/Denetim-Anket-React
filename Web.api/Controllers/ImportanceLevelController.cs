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
    public class ImportanceLevelController : ControllerBase
    {
        private readonly IImportanceLevelService _ımportanteLevelService;

        public ImportanceLevelController(IImportanceLevelService ımportanceLevelService)
        {
            this._ımportanteLevelService = ımportanceLevelService;
        }
        [HttpGet]
        public List<ImportanceLevel> GetList()
        {
            return _ımportanteLevelService.GetList();
        }

        [HttpGet("{id:int}")]
        public ImportanceLevel GetById(int id)
        {
            return _ımportanteLevelService.GetById(id);
        }
        [HttpDelete]
        public void ImportanceLevelDelete(ImportanceLevel ımportanceLevel)
        {
            _ımportanteLevelService.ImportanceLevelDelete(ımportanceLevel);
        }
        [HttpPost]
        public void ImportanceLevelAdd(ImportanceLevel ımportanceLevel)
        {
            _ımportanteLevelService.ImportanceLevelAdd(ımportanceLevel);
        }
        [HttpPut]
        public void ImportanceLevelUpdate(ImportanceLevel ımportanceLevel)
        {
            _ımportanteLevelService.ImportanceLevelUpdate(ımportanceLevel);
        }
    }
}
