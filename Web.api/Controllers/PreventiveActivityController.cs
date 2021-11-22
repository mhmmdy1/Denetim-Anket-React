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
    public class PreventiveActivityController : ControllerBase
    {
        private readonly IPreventiveActivityService _preventiveActivityService;

        public PreventiveActivityController(IPreventiveActivityService preventiveActivityService)
        {
            this._preventiveActivityService = preventiveActivityService;
        }
        [HttpGet]
        public List<PreventiveActivity> GetList()
        {
            return _preventiveActivityService.GetList();
        }

        [HttpGet("{id:int}")]
        public PreventiveActivity GetById(int id)
        {
            return _preventiveActivityService.GetById(id);
        }
        [HttpDelete]
        public void PreventiveActivityDelete(PreventiveActivity preventiveActivity)
        {
            _preventiveActivityService.PreventiveActivityDelete(preventiveActivity);
        }
        [HttpPost]
        public void PreventiveActivityAdd(PreventiveActivity preventiveActivity)
        {
            _preventiveActivityService.PreventiveActivityAdd(preventiveActivity);
        }
        [HttpPut]
        public void PreventiveActivityUpdate(PreventiveActivity preventiveActivity)
        {
            _preventiveActivityService.PreventiveActivityUpdate(preventiveActivity);
        }
    }
}
