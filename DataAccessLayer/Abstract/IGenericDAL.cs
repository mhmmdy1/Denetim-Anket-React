using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetById(int id);
        T GetAccountByEmail(string email);
        T GetPersonelInformationByCompanyId(int companyid);
        bool IsEmailExist(string email);
        // T CheckCredentials(string email, string password);
        bool IsBlockCodeExist(int facilityId, string code, int blockId = 0);
        bool IsCompanyExist(string name);
        T GetByName(string name);
        T GetByCode(string code);
        List<T> GetListByRank();
    //    T CheckCredentials(string email, string password);
     
    }
}
