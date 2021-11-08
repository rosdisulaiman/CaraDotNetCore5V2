using CaraDotNetCore5V2.Domain.Entities.Catalog;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.Repositories
{
    public interface IBrandRepository
    {
        IQueryable<Brand> Brands { get; }

        Task<List<Brand>> GetListAsync();

        Task<Brand> GetByIdAsync(int brandId);

        Task<int> InsertAsync(Brand brand);

        Task UpdateAsync(Brand brand);

        Task DeleteAsync(Brand brand);
    }
}