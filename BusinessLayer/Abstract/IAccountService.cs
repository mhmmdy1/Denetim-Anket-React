using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAccountService
    {
        void AccountAdd(Account account);

        void AccountDelete(Account account);

        void AccountUpdate(Account account);
        List<Account> GetList();
        Account GetById(int id);
        Account GetAccountByEmail(string email);
        Account GetPersonelInformationByCompanyId(int companyid);

        bool IsEmailExist(string email);


    }
}
