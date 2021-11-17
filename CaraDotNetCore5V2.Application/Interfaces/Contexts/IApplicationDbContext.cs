using CaraDotNetCore5V2.Domain.Entities.Catalog;
using CaraDotNetCore5V2.Domain.Entities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.Contexts
{
    public interface IApplicationDbContext
    {
        IDbConnection Connection { get; }
        bool HasChanges { get; }

        EntityEntry Entry(object entity);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        DbSet<Product> Products { get; set; }
        DbSet<ScanLogs> ScanLogs { get; set; }
        DbSet<DataLog> DataLogs { get; set; }

       

        
    }
}