using CaraDotNetCore5V2.Domain.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.Repositories
{
    public interface IDataLogRepository
    {
        IQueryable<DataLog> Datalogs { get; }
        Task<List<DataLog>> GetListAsync();
        Task<DataLog> GetByIdAsync(int logId);
        Task<int> InsertAsync(DataLog dataLog);
        Task DeleteAsync(DataLog dataLog);
    }
}
