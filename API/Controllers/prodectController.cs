using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Core.Entities;
using System.Threading.Tasks;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class prodectController : ControllerBase
    {
        private readonly IprodectRepo _Repo;
        public prodectController(IprodectRepo Repo)
        {
            _Repo = Repo;

        }

        [HttpGet]
        public async Task<ActionResult<List<prodect>>> GetProdects()
        {
            var prodects = await _Repo.GetProdectsAsync();
            return Ok(prodects);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<List<prodect>>> GetProdects(int id)
        {
            var prod = await _Repo.GetProdectByIdAsync(id);
            return Ok(prod);
        }

        [HttpGet("brands")]
        public async Task<ActionResult<List<ProductBrand>>> GetProductBrands()
        {
            var productBrand = await _Repo.GetProdectBandsAsync();
            return Ok(productBrand);
        }
        [HttpGet("types")]
         public async Task<ActionResult<List<ProductType>>> GetProductTypes()
         
         {
             var productType = await _Repo.GetProdectTypeAsync();
             return Ok(productType);
         }
    }
}