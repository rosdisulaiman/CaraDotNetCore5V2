using CaraDotNetCore5V2.Domain.Entities.Catalog;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }

        Task<List<Product>> GetListAsync();

        Task<Product> GetByIdAsync(int productId);

        Task<int> InsertAsync(Product product);

        Task UpdateAsync(Product product);

        Task DeleteAsync(Product product);
    }
}