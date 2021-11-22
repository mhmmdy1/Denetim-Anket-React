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
    public class LocationAuthorizationManager : ILocationAuthorizationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LocationAuthorizationManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public LocationAuthorization GetById(int id)
        {
            return _unitOfWork.LocationAuthorizationsDAL.GetById(id);
        }

        public List<LocationAuthorization> GetList()
        {
            return _unitOfWork.LocationAuthorizationsDAL.GetListAll();
        }

        public void LocationAuthorizationAdd(LocationAuthorization locationAuthorization)
        {
            _unitOfWork.LocationAuthorizationsDAL.Insert(locationAuthorization);
        }

        public void LocationAuthorizationDelete(LocationAuthorization locationAuthorization)
        {
            _unitOfWork.LocationAuthorizationsDAL.Delete(locationAuthorization);
        }

        public void LocationAuthorizationUpdate(LocationAuthorization locationAuthorization)
        {
            _unitOfWork.LocationAuthorizationsDAL.Update(locationAuthorization);
        }
    }
}
