using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;


        public CompanyManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void CompanyAdd(Company company)
        {
            _unitOfWork.CompaniesDAL.Insert(company);
        }

        public void CompanyDelete(Company company)
        {
            _unitOfWork.CompaniesDAL.Delete(company);
        }

        public void CompanyUpdate(Company company)
        {
            _unitOfWork.CompaniesDAL.Update(company);
        }

        public Company GetById(int id)
        {
            return _unitOfWork.CompaniesDAL.GetById(id);
        }

        public List<Company> GetList()
        {
            return _unitOfWork.CompaniesDAL.GetListAll();
        }

        public bool IsCompanyExist(string name)
        {
            return _unitOfWork.CompaniesDAL.IsCompanyExist(name);
        }
    }
}
