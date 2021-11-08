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
    public class FaceCacheRepository : IFaceCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IFaceRepository _faceRepository;

        public FaceCacheRepository(IDistributedCache distributedCache, IFaceRepository faceRepository)
        {
            _distributedCache = distributedCache;
            _faceRepository = faceRepository;
        }

        public Task<ScanLogs> GetByIdAsync(int faceId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ScanLogs>> GetCachedListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
