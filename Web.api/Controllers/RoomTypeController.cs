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
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;

        public RoomTypeController(IRoomTypeService roomTypeService)
        {
            this._roomTypeService = roomTypeService;
        }
        [HttpGet]
        public List<RoomType> GetList()
        {
            return _roomTypeService.GetList();
        }

        [HttpGet("{id:int}")]
        public RoomType GetById(int id)
        {
            return _roomTypeService.GetById(id);
        }
        [HttpDelete]
        public void RoomTypeDelete(RoomType roomType)
        {
            _roomTypeService.RoomTypeDelete(roomType);
        }
        [HttpPost]
        public void RoomTypeAdd(RoomType roomType)
        {
            _roomTypeService.RoomTypeAdd(roomType);
        }
        [HttpPut]
        public void RoomTypeUpdate(RoomType roomType)
        {
            _roomTypeService.RoomTypeUpdate(roomType);
        }
    }
}
