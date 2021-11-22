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
    public class AnswerSetManager : IAnswerSetService
    {
        private readonly IUnitOfWork _unitOfWork;


        public AnswerSetManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void AnswerSetAdd(AnswerSet answerSet)
        {
            _unitOfWork.AnswerSetDAL.Insert(answerSet);
        }

        public void AnswerSetDelete(AnswerSet answerSet)
        {
            _unitOfWork.AnswerSetDAL.Delete(answerSet);
        }

        public void AnswerSetUpdate(AnswerSet answerSet)
        {
            _unitOfWork.AnswerSetDAL.Update(answerSet);
        }

        public AnswerSet GetById(int id)
        {
            return _unitOfWork.AnswerSetDAL.GetById(id);
        }

        public List<AnswerSet> GetList()
        {
            return _unitOfWork.AnswerSetDAL.GetListAll();
        }
    }
}
