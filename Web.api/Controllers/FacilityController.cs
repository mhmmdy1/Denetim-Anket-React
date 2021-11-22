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
    public class FacilityController : ControllerBase
    {
        private readonly IFacilityService _facilityService;

        public FacilityController(IFacilityService facilityService)
        {
            this._facilityService = facilityService;
        }
        [HttpGet]
        public List<Facility> GetList()
        {
            return _facilityService.GetList();
        }

        [HttpGet("{id:int}")]
        public Facility GetById(int id)
        {
            return _facilityService.GetById(id);
        }
        [HttpDelete]
        public void FacilityDelete(Facility facility)
        {
            _facilityService.FacilityDelete(facility);
        }
        [HttpPost]
        public void FacilityAdd(Facility facility)
        {
            _facilityService.FacilityAdd(facility);
        }
        [HttpPut]
        public void FacilityUpdate(Facility facility)
        {
            _facilityService.FacilityUpdate(facility);
        }
    }
}
