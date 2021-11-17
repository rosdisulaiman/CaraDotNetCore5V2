using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using CaraDotNetCore5V2.Domain.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Infrastructure.Repositories
{
    public class DataLogRepository : IDataLogRepository
    {

        private readonly IRepositoryAsync<DataLog> _repository;


        public DataLogRepository(IRepositoryAsync<DataLog> repository)
        {
            _repository = repository;
        }

        public IQueryable<DataLog> Datalogs => throw new NotImplementedException();

        public Task<DataLog> GetByIdAsync(int logId)
        {
            throw new NotImplementedException();
        }

        public Task<List<DataLog>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertAsync(DataLog dataLog)
        {
            await _repository.AddAsync(dataLog);
            return dataLog.Id;
        }

        public Task DeleteAsync(DataLog dataLog)
        {
            throw new NotImplementedException();
        }


        
    }
}
