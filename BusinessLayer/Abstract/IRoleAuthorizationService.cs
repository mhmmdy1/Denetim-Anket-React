using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRoleAuthorizationService
    {
        void RoleAuthorizationAdd(RoleAuthorization roleAuthorization);

        void RoleAuthorizationDelete(RoleAuthorization roleAuthorization);

        void RoleAuthorizationUpdate(RoleAuthorization roleAuthorization);
        List<RoleAuthorization> GetList();
        RoleAuthorization GetById(int id);
    }
}
