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

        public Task DeleteAsync(Face face)
        {
            throw new NotImplementedException();
        }

        public Task<Face> GetByIdAsync(int faceId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Face>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Face face)
        {
            throw new NotImplementedException();
        }
    }
}
