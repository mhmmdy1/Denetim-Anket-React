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
    public class LocationAuthorizationController : ControllerBase
    {
        private readonly ILocationAuthorizationService _locationAuthorizationService;

        public LocationAuthorizationController(ILocationAuthorizationService locationAuthorizationService)
        {
            this._locationAuthorizationService = locationAuthorizationService;
        }
        [HttpGet]
        public List<LocationAuthorization> GetList()
        {
            return _locationAuthorizationService.GetList();
        }

        [HttpGet("{id:int}")]
        public LocationAuthorization GetById(int id)
        {
            return _locationAuthorizationService.GetById(id);
        }
        [HttpDelete]
        public void InspectionUnsuitabilityDelete(LocationAuthorization locationAuthorization)
        {
            _locationAuthorizationService.LocationAuthorizationDelete(locationAuthorization);
        }
        [HttpPost]
        public void InspectionUnsuitabilityAdd(LocationAuthorization locationAuthorization)
        {
            _locationAuthorizationService.LocationAuthorizationAdd(locationAuthorization);
        }
        [HttpPut]
        public void InspectionUnsuitabilityUpdate(LocationAuthorization locationAuthorization)
        {
            _locationAuthorizationService.LocationAuthorizationUpdate(locationAuthorization);
        }
    }
}
