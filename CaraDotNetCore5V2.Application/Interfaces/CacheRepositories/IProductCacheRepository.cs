using CaraDotNetCore5V2.Domain.Entities.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.CacheRepositories
{
    public interface IBrandCacheRepository
    {
        Task<List<Brand>> GetCachedListAsync();

        Task<Brand> GetByIdAsync(int brandId);
    }
}