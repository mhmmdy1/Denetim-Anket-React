using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAnswerSetService
    {
        void AnswerSetAdd(AnswerSet answerSet);

        void AnswerSetDelete(AnswerSet answerSet);

        void AnswerSetUpdate(AnswerSet answerSet);
        List<AnswerSet> GetList();
        AnswerSet GetById(int id);
    }
}
