using CaraDotNetCore5V2.Domain.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.CacheRepositories
{
    public interface IScanCacheRepository
    {
        Task<List<ScanLogs>> GetCachedListAsync();

        Task<ScanLogs> GetByIdAsync(int LogId);
    }
}
