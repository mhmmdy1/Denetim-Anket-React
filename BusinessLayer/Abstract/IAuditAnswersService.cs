using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAuditAnswersService
    {
        void AuditAnswersAdd(AuditAnswers auditAnswers);

        void AuditAnswersDelete(AuditAnswers auditAnswers);

        void AuditAnswersUpdate(AuditAnswers auditAnswers);
        List<AuditAnswers> GetList();
        AuditAnswers GetById(int id);
    }
}
