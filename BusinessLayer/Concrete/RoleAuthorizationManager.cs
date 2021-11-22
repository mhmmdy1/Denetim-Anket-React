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
    public class RoleAuthorizationManager : IRoleAuthorizationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleAuthorizationManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public RoleAuthorization GetById(int id)
        {
            return _unitOfWork.RoleAuthorizationsDAL.GetById(id);
        }

        public List<RoleAuthorization> GetList()
        {
            return _unitOfWork.RoleAuthorizationsDAL.GetListAll();
        }

        public void RoleAuthorizationAdd(RoleAuthorization roleAuthorization)
        {
            _unitOfWork.RoleAuthorizationsDAL.Insert(roleAuthorization);
        }

        public void RoleAuthorizationDelete(RoleAuthorization roleAuthorization)
        {
            _unitOfWork.RoleAuthorizationsDAL.Delete(roleAuthorization);
        }

        public void RoleAuthorizationUpdate(RoleAuthorization roleAuthorization)
        {
            _unitOfWork.RoleAuthorizationsDAL.Update(roleAuthorization);
        }
    }
}
