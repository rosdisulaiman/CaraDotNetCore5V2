using CaraDotNetCore5V2.Application.Interfaces.CacheRepositories;
using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using CaraDotNetCore5V2.Domain.Entities.Data;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
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

        Task<Face> GetByIdAsync(int faceId)
        {
            throw new NotImplementedException();
        }

        Task<Face> IFaceCacheRepository.GetByIdAsync(int faceId)
        {
            throw new NotImplementedException();
        }

        Task<List<Face>> GetCachedListAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<Face>> IFaceCacheRepository.GetCachedListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
