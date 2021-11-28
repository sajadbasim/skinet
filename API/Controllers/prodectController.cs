using Microsoft.AspNetCore.Mvc;
using Infrastructuer.Data;
using System.Collections.Generic;
using Core.Entities;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class prodectController:ControllerBase
    {
        private readonly StorContext _Context ;

        public prodectController(StorContext context)
           {
            _Context = context;
           } 

        [HttpGet]
        public async Task<ActionResult<List<prodect>>> GetProdects()
        { 
           var prodects =await  _Context.prodect.ToListAsync();
           return Ok(prodects);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<List<prodect>>> GetProdect(int id)
        {
           var prod = await _Context.prodect.FindAsync(id);
           return Ok(prod);
        }
    }
}