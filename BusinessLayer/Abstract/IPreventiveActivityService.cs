using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPreventiveActivityService
    {
        void PreventiveActivityAdd(PreventiveActivity preventiveActivity);

        void PreventiveActivityDelete(PreventiveActivity preventiveActivity);

        void PreventiveActivityUpdate(PreventiveActivity preventiveActivity);
        List<PreventiveActivity> GetList();
        PreventiveActivity GetById(int id);
    }
}
