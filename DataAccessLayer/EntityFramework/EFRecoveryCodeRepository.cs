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
    public class EFRecoveryCodeRepository : GenericRepository<RecoveryCode>, IRecoveryCodesDAL
    {
        public EFRecoveryCodeRepository(Context context) : base(context)
        {
        }
    }
}
