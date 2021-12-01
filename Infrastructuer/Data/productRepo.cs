using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructuer.Data
{
    public class productRepo : IprodectRepo
    {
        
        private readonly StorContext _context;
        public productRepo(StorContext context)
        {
            _context = context ;            
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProdectBandsAsync()
        {
            return await _context.ProductBrand.ToListAsync();
        }

        public async Task<prodect> GetProdectByIdAsync(int id)
        {
             return await _context.prodect
                .Include(p => p.ProductType)
                .Include(p => p.ProductBrand)
                .FirstOrDefaultAsync(p => p.Id == id);
         
        }

        public async Task<IReadOnlyList<prodect>> GetProdectsAsync()
        {
            return await _context.prodect
                .Include(p => p.ProductType)
                .Include(p => p.ProductBrand)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<ProductType>> GetProdectTypeAsync()
        {
            return await _context.ProductType.ToListAsync(); 
        }
    }
}