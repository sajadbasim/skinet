using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IprodectRepo 
    {
        Task<prodect> GetProdectByIdAsync(int id);

        Task<IReadOnlyList<prodect>> GetProdectsAsync();
        Task<IReadOnlyList<ProductBrand>> GetProdectBandsAsync();
        Task<IReadOnlyList<ProductType>> GetProdectTypeAsync();
    }
}