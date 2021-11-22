using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFAccountRepository : GenericRepository<Account>, IAccountDAL
    {
        public EFAccountRepository(Context context ) : base(context)
        {
        }
        private Context Context
        {

            get { return Context as Context; }
        }
    }
}
