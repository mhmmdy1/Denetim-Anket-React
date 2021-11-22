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
    public class PeriodController : ControllerBase
    {
        private readonly IPeriodService _periodService;

        public PeriodController(IPeriodService periodService)
        {
            this._periodService = periodService;
        }
        [HttpGet]
        public List<Period> GetList()
        {
            return _periodService.GetList();
        }

        [HttpGet("{id:int}")]
        public Period GetById(int id)
        {
            return _periodService.GetById(id);
        }
        [HttpDelete]
        public void PeriodDelete(Period period)
        {
            _periodService.PeriodDelete(period);
        }
        [HttpPost]
        public void PeriodAdd(Period period)
        {
            _periodService.PeriodAdd(period);
        }
        [HttpPut]
        public void PeriodUpdate(Period period)
        {
            _periodService.PeriodUpdate(period);
        }
    }
}
