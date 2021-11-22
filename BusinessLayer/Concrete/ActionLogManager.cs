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
    public class ActionLogManager : IActionLogService
    {
        private readonly IUnitOfWork _unitOfWork;


        public ActionLogManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void ActionLogAdd(ActionLog actionLog)
        {
            _unitOfWork.ActionLogDAL.Insert(actionLog);
        }

        public void ActionLogDelete(ActionLog actionLog)
        {
            _unitOfWork.ActionLogDAL.Delete(actionLog);
        }

        public void ActionLogUpdate(ActionLog actionLog)
        {
            _unitOfWork.ActionLogDAL.Update(actionLog);
        }

        public ActionLog GetById(int id)
        {
            return _unitOfWork.ActionLogDAL.GetById(id);
        }

        public List<ActionLog> GetList()
        {
            return _unitOfWork.ActionLogDAL.GetListAll();
        }
    }
}
