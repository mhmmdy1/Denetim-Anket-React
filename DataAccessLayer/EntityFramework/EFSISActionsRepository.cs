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
    public class EFSISActionsRepository : GenericRepository<SISAction>, ISISActionsDAL
    {
        public EFSISActionsRepository(Context context) : base(context)
        {
        }
    }
}
