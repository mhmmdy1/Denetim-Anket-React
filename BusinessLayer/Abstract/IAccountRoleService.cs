using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IAccountRoleService
    {
        void AccountRoleAdd(AccountRole accountRole);

        void AccountRoleDelete(AccountRole accountRole);

        void AccountRoleUpdate(AccountRole accountRoel);
        List<AccountRole> GetList();
        AccountRole GetById(int id);
    }
}
