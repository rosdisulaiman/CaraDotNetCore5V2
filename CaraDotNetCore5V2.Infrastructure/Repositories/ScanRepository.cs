using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using CaraDotNetCore5V2.Domain.Entities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Infrastructure.Repositories
{
    public class ScanRepository : IScanRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IRepositoryAsync<ScanLogs> _repository;

        public ScanRepository(IDistributedCache distributedCache, IRepositoryAsync<ScanLogs> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }

        public IQueryable<ScanLogs> Scans => _repository.Entities;

        public async Task DeleteAsync(ScanLogs scanLog)
        {
            await _repository.DeleteAsync(scanLog);
            await _distributedCache.RemoveAsync(CacheKeys.ScanCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.ScanCacheKeys.GetKey(scanLog.Id));
        }

        public async Task<ScanLogs> GetByIdAsync(int logId)
        {
            //return await _repository.Entities.Where(s => s.LogId == logId)
            //    .Include(f => f.Faces)
            //    .FirstOrDefaultAsync(s => s.LogId == logId);

            return await _repository.Entities.AsNoTracking().Include(e => e.Faces)
                .FirstOrDefaultAsync(s => s.LogId == logId);
        }

        public async Task<List<ScanLogs>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(ScanLogs scanLog)
        {
            await _repository.AddAsync(scanLog);
            await _distributedCache.RemoveAsync(CacheKeys.ScanCacheKeys.ListKey);
            return scanLog.Id;
        }
    }
}
