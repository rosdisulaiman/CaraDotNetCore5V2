using AspNetCoreHero.ThrowR;
using CaraDotNetCore5V2.Application.Interfaces.CacheRepositories;
using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using CaraDotNetCore5V2.Domain.Entities.Data;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreHero.Extensions.Caching;
using CaraDotNetCore5V2.Infrastructure.CacheKeys;

namespace CaraDotNetCore5V2.Infrastructure.CacheRepositories
{
    public class ScanCacheRepository : IScanCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IScanRepository _scanRepository;

        public ScanCacheRepository(IDistributedCache distributedCache, IScanRepository scanRepository)
        {
            _distributedCache = distributedCache;
            _scanRepository = scanRepository;
        }

        public async Task<ScanLogs> GetByIdAsync(int LogId)
        {

            string cacheKey = ScanCacheKeys.GetKey(LogId);
            var scan = await _distributedCache.GetAsync<ScanLogs>(cacheKey);
            if (scan == null)
            {
                scan = await _scanRepository.GetByIdAsync(LogId);
                Throw.Exception.IfNull(scan, "Scan", "No Scan Found");
                await _distributedCache.SetAsync(cacheKey, scan);
            }
            return scan;
        }

        public async Task<List<ScanLogs>> GetCachedListAsync()
        {
            string cacheKey = ScanCacheKeys.ListKey;
            var scanList = await _distributedCache.GetAsync<List<ScanLogs>>(cacheKey);
            if (scanList == null)
            {
                scanList = await _scanRepository.GetListAsync();
                await _distributedCache.SetAsync(cacheKey, scanList);
            }
            return scanList;
        }
    }
}