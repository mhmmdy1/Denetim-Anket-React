using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IBlockService
    {
        void BlockAdd(Block block);

        void BlockDelete(Block block);

        void BlockUpdate(Block block);
        List<Block> GetList();
        Block GetById(int id);
        Block GetByName(string name);
        Block GetByCode(string code);
    }
}
