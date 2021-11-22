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
    public class FacilityTypeController : ControllerBase
    {
        private readonly IFacilityTypeService _facilityTypeService;

        public FacilityTypeController(IFacilityTypeService facilityService)
        {
            this._facilityTypeService = facilityService;
        }
        [HttpGet]
        public List<FacilityType> GetList()
        {
            return _facilityTypeService.GetList();
        }

        [HttpGet("{id:int}")]
        public FacilityType GetById(int id)
        {
            return _facilityTypeService.GetById(id);
        }
        [HttpDelete]
        public void FacilityTypeDelete(FacilityType facilityType)
        {
            _facilityTypeService.FacilityTypeDelete(facilityType);
        }
        [HttpPost]
        public void FacilityTypeAdd(FacilityType facilityType)
        {
            _facilityTypeService.FacilityTypeAdd(facilityType);
        }
        [HttpPut]
        public void FacilityTypeUpdate(FacilityType facilityType)
        {
            _facilityTypeService.FacilityTypeUpdate(facilityType);
        }
    }
}
