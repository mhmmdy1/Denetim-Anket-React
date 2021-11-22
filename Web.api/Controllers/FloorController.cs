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
    public class FloorController : ControllerBase
    {
        private readonly IFloorService _floorService;

        public FloorController(IFloorService floorService)
        {
            this._floorService = floorService;
        }
        [HttpGet]
        public List<Floor> GetList()
        {
            return _floorService.GetList();
        }

        [HttpGet("{id:int}")]
        public Floor GetById(int id)
        {
            return _floorService.GetById(id);
        }
        [HttpDelete]
        public void FloorDelete(Floor floor)
        {
            _floorService.FloorDelete(floor);
        }
        [HttpPost]
        public void FloorAdd(Floor floor)
        {
            _floorService.FloorAdd(floor);
        }
        [HttpPut]
        public void FloorUpdate(Floor floor)
        {
            _floorService.FloorUpdate(floor);
        }
    }
}
