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
    public class InspectionUnsuitablityController : ControllerBase
    {
        private readonly IInspectionUnsuitabilityService _ınspectionUnsuitabilityService;

        public InspectionUnsuitablityController(IInspectionUnsuitabilityService ınspectionUnsuitabilittyService)
        {
            this._ınspectionUnsuitabilityService = ınspectionUnsuitabilittyService;
        }
        [HttpGet]
        public List<InspectionUnsuitability> GetList()
        {
            return _ınspectionUnsuitabilityService.GetList();
        }

        [HttpGet("{id:int}")]
        public InspectionUnsuitability GetById(int id)
        {
            return _ınspectionUnsuitabilityService.GetById(id);
        }
        [HttpDelete]
        public void InspectionUnsuitabilityDelete(InspectionUnsuitability ınspectionUnsuitability)
        {
            _ınspectionUnsuitabilityService.InspectionUnsuitabilityDelete(ınspectionUnsuitability);
        }
        [HttpPost]
        public void InspectionUnsuitabilityAdd(InspectionUnsuitability ınspectionUnsuitability)
        {
            _ınspectionUnsuitabilityService.InspectionUnsuitabilityAdd(ınspectionUnsuitability);
        }
        [HttpPut]
        public void InspectionUnsuitabilityUpdate(InspectionUnsuitability ınspectionUnsuitability)
        {
            _ınspectionUnsuitabilityService.InspectionUnsuitabilityUpdate(ınspectionUnsuitability);
        }
    }
}
