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
    public class FaceRepository : IFaceRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IRepositoryAsync<Face> _repository;

        public FaceRepository(IDistributedCache distributedCache, IRepositoryAsync<Face> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }

        public IQueryable<Face> Faces => _repository.Entities;

        public async Task DeleteAsync(Face face)
        {
            await _repository.DeleteAsync(face);
            await _distributedCache.RemoveAsync(CacheKeys.FaceCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.FaceCacheKeys.GetKey(face.Id));
        }

        public async Task<Face> GetByIdAsync(int faceId)
        {
            return await _repository.Entities.Where(p => p.Id == faceId).FirstOrDefaultAsync();
        }

        public async Task<List<Face>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(Face face)
        {
            await _repository.AddAsync(face);
            await _distributedCache.RemoveAsync(CacheKeys.FaceCacheKeys.ListKey);
            return face.Id;
        }
    }
}
