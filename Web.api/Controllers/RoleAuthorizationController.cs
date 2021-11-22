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
    public class RoleAuthorizationController : ControllerBase
    {
        private readonly IRoleAuthorizationService _roleAuthorizationService;

        public RoleAuthorizationController(IRoleAuthorizationService roleAuthorizationService)
        {
            this._roleAuthorizationService = roleAuthorizationService;
        }
        [HttpGet]
        public List<RoleAuthorization> GetList()
        {
            return _roleAuthorizationService.GetList();
        }

        [HttpGet("{id:int}")]
        public RoleAuthorization GetById(int id)
        {
            return _roleAuthorizationService.GetById(id);
        }
        [HttpDelete]
        public void RoleAuthorizationDelete(RoleAuthorization roleAuthorization)
        {
            _roleAuthorizationService.RoleAuthorizationDelete(roleAuthorization);
        }
        [HttpPost]
        public void RoleAuthorizationAdd(RoleAuthorization roleAuthorization)
        {
            _roleAuthorizationService.RoleAuthorizationAdd(roleAuthorization);
        }
        [HttpPut]
        public void RoleAuthorizationUpdate(RoleAuthorization roleAuthorization)
        {
            _roleAuthorizationService.RoleAuthorizationUpdate(roleAuthorization);
        }
    }
}
