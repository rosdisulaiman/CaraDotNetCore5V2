using CaraDotNetCore5V2.Domain.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.Repositories
{
    public interface IDataLogRepository
    {
        Task<int> InsertAsync(DataLog dataLog);
    }
}
