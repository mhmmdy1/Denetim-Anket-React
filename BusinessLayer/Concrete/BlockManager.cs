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
    public class BlockManager : IBlockService
    {
        private readonly IUnitOfWork _unitOfWork;


        public BlockManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void BlockAdd(Block block)
        {
            _unitOfWork.BlocksDAL.Insert(block);
        }

        public void BlockDelete(Block block)
        {
            _unitOfWork.BlocksDAL.Delete(block);
        }

        public void BlockUpdate(Block block)
        {
            _unitOfWork.BlocksDAL.Update(block);
        }

        public Block GetByCode(string code)
        {
            return _unitOfWork.BlocksDAL.GetByCode(code);
        }

        public Block GetById(int id)
        {
            return _unitOfWork.BlocksDAL.GetById(id);
        }

        public Block GetByName(string name)
        {
            return _unitOfWork.BlocksDAL.GetByName(name);
        }

        public List<Block> GetList()
        {
            return _unitOfWork.BlocksDAL.GetListAll();
        }
    }
}
