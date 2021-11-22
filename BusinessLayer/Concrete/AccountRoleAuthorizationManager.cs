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
    public class AccountRoleAuthorizationManager : IAccountRoleAuthorizationService
    {
        private readonly IUnitOfWork _unitOfWork;


        public AccountRoleAuthorizationManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void AccountRoleAuthorizationAdd(AccountRoleAuthorization accountRoleAuthorization)
        {
            _unitOfWork.AccountRoleAuthorizationDAL.Insert(accountRoleAuthorization);
        }

        public void AccountRoleAuthorizationDelete(AccountRoleAuthorization accountRoleAuthorization)
        {
            _unitOfWork.AccountRoleAuthorizationDAL.Delete(accountRoleAuthorization);
        }

        public void AccountRoleAuthorizationUpdate(AccountRoleAuthorization accountRoleAuthorization)
        {
            _unitOfWork.AccountRoleAuthorizationDAL.Update(accountRoleAuthorization);
        }

        public AccountRoleAuthorization GetById(int id)
        {
            return _unitOfWork.AccountRoleAuthorizationDAL.GetById(id);
        }

        public List<AccountRoleAuthorization> GetList()
        {
            return _unitOfWork.AccountRoleAuthorizationDAL.GetListAll();
        }
    }
}
