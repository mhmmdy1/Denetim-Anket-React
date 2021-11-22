using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImportanceLevelManager : IImportanceLevelService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ImportanceLevelManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public ImportanceLevel GetById(int id)
        {
          return _unitOfWork.ImportanceLevelsDAL.GetById(id);
        }

        public List<ImportanceLevel> GetList()
        {
            return _unitOfWork.ImportanceLevelsDAL.GetListAll();
        }

        public void ImportanceLevelAdd(ImportanceLevel ımportanceLevel)
        {
            _unitOfWork.ImportanceLevelsDAL.Insert(ımportanceLevel);
        }

        public void ImportanceLevelDelete(ImportanceLevel ımportanceLevel)
        {
            _unitOfWork.ImportanceLevelsDAL.Delete(ımportanceLevel);
        }

        public void ImportanceLevelUpdate(ImportanceLevel ımportanceLevel)
        {
            _unitOfWork.ImportanceLevelsDAL.Update(ımportanceLevel);
        }
    }
}
