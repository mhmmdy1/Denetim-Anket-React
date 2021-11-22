using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IActionLogService
    {
        void ActionLogAdd(ActionLog actionLog);

        void ActionLogDelete(ActionLog actionLog);

        void ActionLogUpdate(ActionLog actionLog);
        List<ActionLog> GetList();
        ActionLog GetById(int id);
    }
}
