using CaraDotNetCore5V2.Application.Interfaces.CacheRepositories;
using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using CaraDotNetCore5V2.Infrastructure.CacheKeys;
using AspNetCoreHero.Extensions.Caching;
using AspNetCoreHero.ThrowR;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;
using CaraDotNetCore5V2.Domain.Entities.Data;


namespace CaraDotNetCore5V2.Infrastructure.CacheRepositories
{
    public class DataLogCacheRepositories : IDataLogCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IDataLogRepository _dataLogRepository;

        public DataLogCacheRepositories(IDistributedCache distributedCache, IDataLogRepository dataLogRepository)
        {
            _distributedCache = distributedCache;
            _dataLogRepository = dataLogRepository;
        }

        public async Task<DataLog> GetByIdAsync(int Id)
        {
            string cacheKey = DatalogCacheKeys.GetKey(Id);
            var datalog = await _distributedCache.GetAsync<DataLog>(cacheKey);
            if (datalog == null)
            {
                datalog = await _dataLogRepository.GetByIdAsync(Id);
                Throw.Exception.IfNull(datalog, "DataLog", "No data Found");
                await _distributedCache.SetAsync(cacheKey, datalog);
            }
            return datalog;
        }

        public async Task<List<DataLog>> GetCachedListAsync()
        {
            string cacheKey = DatalogCacheKeys.ListKey;
            var datalogList = await _distributedCache.GetAsync<List<DataLog>>(cacheKey);
            if (datalogList == null)
            {
                datalogList = await _dataLogRepository.GetListAsync();
                await _distributedCache.SetAsync(cacheKey, datalogList);
            }
            return datalogList;
        }
    }
}
