using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.api.Models.Register;

namespace DataAccessLayer.EntityFramework
{
    public class EFRegisterRepository : GenericRepository<RegisterFormModel>, IRegisterDAL
    {
        public EFRegisterRepository(Context context) : base(context)
        {
        }
        private Context Context
        {

            get { return Context as Context; }
        }
    }
}
