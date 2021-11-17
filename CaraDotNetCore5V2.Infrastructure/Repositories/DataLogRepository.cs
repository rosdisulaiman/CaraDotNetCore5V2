using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using CaraDotNetCore5V2.Domain.Entities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Infrastructure.Repositories
{
    public class DataLogRepository : IDataLogRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IRepositoryAsync<DataLog> _repository;


        public DataLogRepository(IDistributedCache distributedCache, IRepositoryAsync<DataLog> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }

        public IQueryable<DataLog> Datalogs => _repository.Entities;

        public async Task<List<DataLog>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<DataLog> GetByIdAsync(int logId)
        {
            return await _repository.Entities.Where(p => p.Id == logId).FirstOrDefaultAsync();
        }

        public async Task<int> InsertAsync(DataLog dataLog)
        {
            await _repository.AddAsync(dataLog);
            return dataLog.Id;
        }

        public async Task DeleteAsync(DataLog dataLog)
        {
            await _repository.DeleteAsync(dataLog);
            await _distributedCache.RemoveAsync(CacheKeys.DatalogCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.DatalogCacheKeys.GetKey(dataLog.Id));
        }


        
    }
}
