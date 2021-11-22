using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IImportanceLevelService
    {
        void ImportanceLevelAdd(ImportanceLevel ımportanceLevel);

        void ImportanceLevelDelete(ImportanceLevel ımportanceLevel);

        void ImportanceLevelUpdate(ImportanceLevel ımportanceLevel);
        List<ImportanceLevel> GetList();
        ImportanceLevel GetById(int id);
    }
}
