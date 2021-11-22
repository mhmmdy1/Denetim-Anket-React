using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMembershipPackagesService
    {
        void MembershipPackagesAdd(MembershipPackages membershipPackages);

        void MembershipPackagesDelete(MembershipPackages membershipPackages);

        void MembershipPackagesUpdate(MembershipPackages membershipPackages);
        List<MembershipPackages> GetList();
        MembershipPackages GetById(int id);
    }
}
