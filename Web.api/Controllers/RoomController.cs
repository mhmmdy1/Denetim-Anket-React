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
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            this._roomService = roomService;
        }
        [HttpGet]
        public List<Room> GetList()
        {
            return _roomService.GetList();
        }

        [HttpGet("{id:int}")]
        public Room GetById(int id)
        {
            return _roomService.GetById(id);
        }
        [HttpDelete]
        public void RoleDelete(Room room)
        {
            _roomService.RoomDelete(room);
        }
        [HttpPost]
        public void RoleAdd(Room room)
        {
            _roomService.RoomAdd(room);
        }
        [HttpPut]
        public void RoleUpdate(Room room)
        {
            _roomService.RoomUpdate(room);
        }
    }
}
