using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAnswerSetDetailService
    {
        void AnswerSetDetailAdd(AnswerSetDetail answerSetDetail);

        void AnswerSetDetailDelete(AnswerSetDetail answerSetDetail);

        void AnswerSetDetailUpdate(AnswerSetDetail answerSetDetail);
        List<AnswerSetDetail> GetList();
        AnswerSetDetail GetById(int id);
    }
}
