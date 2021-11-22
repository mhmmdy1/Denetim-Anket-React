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
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            this._roleService = roleService;
        }
        [HttpGet]
        public List<Role> GetList()
        {
            return _roleService.GetList();
        }

        [HttpGet("{id:int}")]
        public Role GetById(int id)
        {
            return _roleService.GetById(id);
        }
        [HttpDelete]
        public void RoleDelete(Role role)
        {
            _roleService.RoleDelete(role);
        }
        [HttpPost]
        public void RoleAdd(Role role)
        {
            _roleService.RoleAdd(role);
        }
        [HttpPut]
        public void RoleUpdate(Role role)
        {
            _roleService.RoleUpdate(role);
        }
    }
}
