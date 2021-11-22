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
    public class AccountRoleManager : IAccountRoleService
    {
        private readonly IUnitOfWork _unitOfWork;


        public AccountRoleManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void AccountRoleAdd(AccountRole accountRole)
        {
            _unitOfWork.AccountRoleDAL.Insert(accountRole);
        }

        public void AccountRoleDelete(AccountRole accountRole)
        {
            _unitOfWork.AccountRoleDAL.Delete(accountRole);
        }

        public void AccountRoleUpdate(AccountRole accountRoel)
        {
            _unitOfWork.AccountRoleDAL.Update(accountRoel);
        }

        public AccountRole GetById(int id)
        {
            return _unitOfWork.AccountRoleDAL.GetById(id);
        }

        public List<AccountRole> GetList()
        {
            return _unitOfWork.AccountRoleDAL.GetListAll();
        }
    }
}
