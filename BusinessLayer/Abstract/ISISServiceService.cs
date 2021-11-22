using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISISServiceService
    {
        void SISServiceAdd(SISService sISService);

        void SISServiceDelete(SISService sISService);

        void SISServiceUpdate(SISService sISService);
        List<SISService> GetList();
        SISService GetById(int id);
    }
}
