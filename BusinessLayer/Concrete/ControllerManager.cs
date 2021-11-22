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
    public class ControllerManager : IControllerService
    {
        private readonly IUnitOfWork _unitOfWork;


        public ControllerManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void ControllerAdd(SISController sıscontroller)
        {
            _unitOfWork.SISControllersDAL.Insert(sıscontroller);
        }

        public void ControllerDelete(SISController sıscontroller)
        {
            _unitOfWork.SISControllersDAL.Delete(sıscontroller);
        }

        public void ControllerUpdate(SISController sıscontroller)
        {
            _unitOfWork.SISControllersDAL.Update(sıscontroller);
        }

        public SISController GetById(int id)
        {
            return _unitOfWork.SISControllersDAL.GetById(id);
        }

        public SISController GetByName(string name)
        {
            return _unitOfWork.SISControllersDAL.GetByName(name);
        }

        public List<SISController> GetList()
        {
            return _unitOfWork.SISControllersDAL.GetListAll();
        }
    }
}
