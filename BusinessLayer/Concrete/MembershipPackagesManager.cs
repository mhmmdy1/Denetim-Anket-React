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
    public class MembershipPackagesManager : IMembershipPackagesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MembershipPackagesManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public MembershipPackages GetById(int id)
        {
            return _unitOfWork.MembershipPackagesDAL.GetById(id);
        }

        public List<MembershipPackages> GetList()
        {
            return _unitOfWork.MembershipPackagesDAL.GetListAll();
        }

        public void MembershipPackagesAdd(MembershipPackages membershipPackages)
        {
            _unitOfWork.MembershipPackagesDAL.Insert(membershipPackages);
        }

        public void MembershipPackagesDelete(MembershipPackages membershipPackages)
        {
            _unitOfWork.MembershipPackagesDAL.Delete(membershipPackages);
        }

        public void MembershipPackagesUpdate(MembershipPackages membershipPackages)
        {
            _unitOfWork.MembershipPackagesDAL.Update(membershipPackages);
        }
    }
}
