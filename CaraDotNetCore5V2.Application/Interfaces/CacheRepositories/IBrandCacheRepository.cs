using CaraDotNetCore5V2.Domain.Entities.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.CacheRepositories
{
    public interface IProductCacheRepository
    {
        Task<List<Product>> GetCachedListAsync();

        Task<Product> GetByIdAsync(int brandId);
    }
}