using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using CaraDotNetCore5V2.Domain.Entities.Data;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public IQueryable<ScanLogs> scanLogs => _repository.Entities;

        public async Task DeleteAsync(ScanLogs scanLog)
        {
            await _repository.DeleteAsync(scanLog);
            await _distributedCache.RemoveAsync(CacheKeys.ScanCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.ScanCacheKeys.GetKey(scanLog.Id));
        }

        public Task<ScanLogs> GetByIdAsync(int LogId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ScanLogs>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(ScanLogs scanLog)
        {
            throw new NotImplementedException();
        }
    }
}
