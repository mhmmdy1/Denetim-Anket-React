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
    public class InspectionSetController : ControllerBase
    {
        private readonly IInspectionSetService _ınspectionSetService;

        public InspectionSetController(IInspectionSetService ınspectionSetService)
        {
            this._ınspectionSetService = ınspectionSetService;
        }
        [HttpGet]
        public List<InspectionSet> GetList()
        {
            return _ınspectionSetService.GetList();
        }

        [HttpGet("{id:int}")]
        public InspectionSet GetById(int id)
        {
            return _ınspectionSetService.GetById(id);
        }
        [HttpDelete]
        public void InspectionSetDelete(InspectionSet ınspectionSet)
        {
            _ınspectionSetService.InspectionSetDelete(ınspectionSet);
        }
        [HttpPost]
        public void InspectionSetAdd(InspectionSet ınspectionSet)
        {
            _ınspectionSetService.InspectionSetAdd(ınspectionSet);
        }
        [HttpPut]
        public void InspectionSetUpdate(InspectionSet ınspectionSet)
        {
            _ınspectionSetService.InspectionSetUpdate(ınspectionSet);
        }
    }
}
