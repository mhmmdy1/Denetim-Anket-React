using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILocationAuthorizationService
    {
        void LocationAuthorizationAdd(LocationAuthorization locationAuthorization);

        void LocationAuthorizationDelete(LocationAuthorization locationAuthorization);

        void LocationAuthorizationUpdate(LocationAuthorization locationAuthorization);
        List<LocationAuthorization> GetList();
        LocationAuthorization GetById(int id);
    }
}
