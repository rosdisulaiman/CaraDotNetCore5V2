using CaraDotNetCore5V2.Application.Interfaces.CacheRepositories;
using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using CaraDotNetCore5V2.Domain.Entities.Data;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task<Face> GetByIdAsync(int faceId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Face>> GetCachedListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
