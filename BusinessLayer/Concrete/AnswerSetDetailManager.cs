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
    public class AnswerSetDetailManager : IAnswerSetDetailService
    {
        private readonly IUnitOfWork _unitOfWork;


        public AnswerSetDetailManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void AnswerSetDetailAdd(AnswerSetDetail answerSetDetail)
        {
            _unitOfWork.AnswerSetDetailDAL.Insert(answerSetDetail);
        }

        public void AnswerSetDetailDelete(AnswerSetDetail answerSetDetail)
        {
            _unitOfWork.AnswerSetDetailDAL.Delete(answerSetDetail);
        }

        public void AnswerSetDetailUpdate(AnswerSetDetail answerSetDetail)
        {
            _unitOfWork.AnswerSetDetailDAL.Update(answerSetDetail);
        }

        public AnswerSetDetail GetById(int id)
        {
            return _unitOfWork.AnswerSetDetailDAL.GetById(id);
        }

        public List<AnswerSetDetail> GetList()
        {
            return _unitOfWork.AnswerSetDetailDAL.GetListAll();
        }
    }
}
