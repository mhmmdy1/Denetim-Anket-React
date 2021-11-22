using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IControllerService
    {
        void ControllerAdd(SISController sıscontroller);

        void ControllerDelete(SISController sıscontroller);

        void ControllerUpdate(SISController sıscontroller);
        List<SISController> GetList();
        SISController GetById(int id);
        SISController GetByName(string name);
    }
}
