using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAccountRoleAuthorizationService  
    {
        void AccountRoleAuthorizationAdd(AccountRoleAuthorization accountRoleAuthorization);

        void AccountRoleAuthorizationDelete(AccountRoleAuthorization accountRoleAuthorization);

        void AccountRoleAuthorizationUpdate(AccountRoleAuthorization accountRoleAuthorization);
        List<AccountRoleAuthorization> GetList();
        AccountRoleAuthorization GetById(int id);
    }
}
