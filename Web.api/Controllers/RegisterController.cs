using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.api.Extensions;
using Web.api.Models.Register;

namespace Web.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class RegisterController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ICompanyService _companyService;
        public RegisterController(IAccountService accountService, ICompanyService companyService)
        {
            this._accountService = accountService;
            this._companyService = companyService;
        }

        [HttpPost]
        public void Register(RegisterFormModel posted)
        {
         
           var company = new Company
            {
                Name = posted.CompanyName,
                PhoneNumber = posted.CompanyPhoneNumber,
                Address = posted.CompanyAddress,
                City = posted.CompanyCity,
                CreateDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddDays(30),
                IsActive = true,
         
           };

            _companyService.CompanyAdd(company);

            var account = new Account
            {
                NameSurname = posted.UserFullName,
                Email = posted.UserMail,
                Password = posted.UserPassword.ToMD5(),
                IsAdmin = true,
                Company = new Company() { CompanyId = company.CompanyId },
                CreateDate = DateTime.Now,
                IsActive = true,
            };

            _accountService.AccountAdd(account);

        }
    }
}

