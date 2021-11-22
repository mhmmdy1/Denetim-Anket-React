using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AccountManager : IAccountService
    {

        private readonly IUnitOfWork _unitOfWork;
        public AccountManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void AccountAdd(Account account)
        {
            _unitOfWork.AccountDal.Insert(account);
        }

        public void AccountDelete(Account account)
        {
            _unitOfWork.AccountDal.Delete(account);
        }

        public void AccountUpdate(Account account)
        {
            _unitOfWork.AccountDal.Update(account);
        }

        public Account GetAccountByEmail(string email)
        {
            return _unitOfWork.AccountDal.GetAccountByEmail(email);
        }

        public Account GetById(int id)
        {
            return _unitOfWork.AccountDal.GetById(id);
        }

        public List<Account> GetList()
        {
            return _unitOfWork.AccountDal.GetListAll();
        }

        public Account GetPersonelInformationByCompanyId(int companyid)
        {
            return _unitOfWork.AccountDal.GetPersonelInformationByCompanyId(companyid);
        }

        public bool IsEmailExist(string email)
        {
            return _unitOfWork.AccountDal.IsEmailExist(email);
        }
    }
}
