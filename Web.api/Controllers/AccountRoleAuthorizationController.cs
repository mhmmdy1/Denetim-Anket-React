using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
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
    public class AccountRoleAuthorizationController : ControllerBase
    {
        
        private readonly IAccountRoleAuthorizationService _accountRoleAuthorizationService;

        public AccountRoleAuthorizationController(IAccountRoleAuthorizationService accountRoleAuthorizationService)
        {
             this._accountRoleAuthorizationService = accountRoleAuthorizationService;
        }
        [HttpGet("{id:int}")]
        public AccountRoleAuthorization GetById(int id)
        {
              return _accountRoleAuthorizationService.GetById(id);
        }
        [HttpGet]
        public List<AccountRoleAuthorization> GetList()
        {
         return _accountRoleAuthorizationService.GetList();
        }
        [HttpDelete]
        public void AccountRoleAuthorizationDelete(AccountRoleAuthorization accountRoleAuthorization)
        {
            _accountRoleAuthorizationService.AccountRoleAuthorizationDelete(accountRoleAuthorization);
        }
        [HttpPost]
        public void AccountRoleAuthorizationAdd(AccountRoleAuthorization accountRoleAuthorization)
        {
            _accountRoleAuthorizationService.AccountRoleAuthorizationAdd(accountRoleAuthorization);
        }
        [HttpPut]
        public void AccountRoleAuthorizationUpdate(AccountRoleAuthorization accountRoleAuthorization)
        {
            _accountRoleAuthorizationService.AccountRoleAuthorizationUpdate(accountRoleAuthorization);
        }
    }
}
