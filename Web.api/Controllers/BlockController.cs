using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class BlockController : ControllerBase
    {
        private readonly IBlockService _blockService;

        public BlockController(IBlockService blockService)
        {
            this._blockService = blockService;
        }
        [HttpGet]
        public List<Block> GetList()
        {
            return _blockService.GetList();
        }

        [HttpGet("{id:int}")]
        public Block GetById(int id)
        {
            return _blockService.GetById(id);
        }
        [HttpDelete]
        public void BlockDelete(Block block)
        {
            _blockService.BlockDelete(block);
        }
        [HttpPost]
        public void BlockAdd(Block block)
        {
            _blockService.BlockAdd(block);
        }
        [HttpPut]
        public void BlockUpdate(Block block)
        {
            _blockService.BlockUpdate(block);
        }
    }
}
