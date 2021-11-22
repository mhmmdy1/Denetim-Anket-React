using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IExceptionLogService
    {
        void ExceptionLogAdd(ExceptionLog exceptionLog);

        void ExceptionLogDelete(ExceptionLog exceptionLog);

        void ExceptionLogUpdate(ExceptionLog exceptionLog);
        List<ExceptionLog> GetList();
        ExceptionLog GetById(int id);
    }
}
