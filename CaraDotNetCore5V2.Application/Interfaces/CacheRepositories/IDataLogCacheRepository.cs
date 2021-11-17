﻿using CaraDotNetCore5V2.Domain.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.CacheRepositories
{
    public interface IDataLogCacheRepository
    {
        Task<List<DataLog>> GetCachedListAsync();

        Task<DataLog> GetByIdAsync(int Id);
    }
}
