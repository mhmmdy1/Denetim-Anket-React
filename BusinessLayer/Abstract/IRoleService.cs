using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRoleService
    {
        void RoleAdd(Role role);

        void RoleDelete(Role role);

        void RoleUpdate(Role role);
        List<Role> GetList();
        Role GetById(int id);
    }
}
