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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            this._companyService = companyService;
        }
        [HttpGet]
        public List<Company> GetList()
        {
            return _companyService.GetList();
        }
        [HttpGet("{id:int}")]
        public Company GetById(int id)
        {
            return _companyService.GetById(id);
        }
        [HttpDelete]
        public void CompanyDelete(Company company)
        {
            _companyService.CompanyDelete(company);
        }
        [HttpPost]
        public void CompanyAdd(Company company)
        {
            _companyService.CompanyAdd(company);
        }
        [HttpPut]
        public void CompanyUpdate(Company company)
        {
            _companyService.CompanyUpdate(company);
        }


    }
}
