using AspNetCoreHero.Results;
using AutoMapper;
using CaraDotNetCore5V2.Application.Interfaces.CacheRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Features.DataLog.GetAllCached
{
    public class GetAllDataLogsCachedQuery : IRequest<Result<List<GetAllDataLogsCachedResponse>>>
    {
        public GetAllDataLogsCachedQuery()
        {

        }
    }

    public class GetAllDataLogsCachedQueryHandler : IRequestHandler<GetAllDataLogsCachedQuery, Result<List<GetAllDataLogsCachedResponse>>>
    {
        private readonly IDataLogCacheRepository _datalogCache;
        private readonly IMapper _mapper;

        public GetAllDataLogsCachedQueryHandler(IDataLogCacheRepository datalogCache, IMapper mapper)
        {
            _datalogCache = datalogCache;
            _mapper = mapper;
        }

        public async Task<Result<List<GetAllDataLogsCachedResponse>>> Handle(GetAllDataLogsCachedQuery request, CancellationToken cancellationToken)
        {
            var datalogList = await _datalogCache.GetCachedListAsync();
            var mappedDataLogs = _mapper.Map<List<GetAllDataLogsCachedResponse>>(datalogList);
            return Result<List<GetAllDataLogsCachedResponse>>.Success(mappedDataLogs);
        }
    }
}
