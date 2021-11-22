using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
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
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            this._accountService = accountService;

        }
        [HttpGet("getall")]
        public List<Account> GetList()
        {
            return _accountService.GetList();
        }
        [HttpGet("{email}")]
        public Account GetAccountByEmail(string email)
        {
            return _accountService.GetAccountByEmail(email);
        }

        [HttpGet("{id:int}")]
        public Account GetById(int id)
        {
            return _accountService.GetById(id);
        }

        [HttpGet("{companyid}")]
        public Account GetPersonelInformationByCompanyId(int companyid)
        {
            return _accountService.GetPersonelInformationByCompanyId(companyid);
        }


    }
}
