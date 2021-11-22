using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPeriodService
    {
        void PeriodAdd(Period period);

        void PeriodDelete(Period period);

        void PeriodUpdate(Period period);
        List<Period> GetList();
        Period GetById(int id);
    }
}
