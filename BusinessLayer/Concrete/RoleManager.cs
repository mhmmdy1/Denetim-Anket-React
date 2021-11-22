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
    public class RoleManager : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public Role GetById(int id)
        {
            return _unitOfWork.RolesDAL.GetById(id);
        }

        public List<Role> GetList()
        {
            return _unitOfWork.RolesDAL.GetListAll();
        }

        public void RoleAdd(Role role)
        {
            _unitOfWork.RolesDAL.Insert(role);
        }

        public void RoleDelete(Role role)
        {
            _unitOfWork.RolesDAL.Delete(role);
        }

        public void RoleUpdate(Role role)
        {
            _unitOfWork.RolesDAL.Update(role);
        }
    }
}
