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

namespace CaraDotNetCore5V2.Application.Features.Scan.Queries.GetAllCached
{
    public class GetAllScansCachedQuery : IRequest<Result<List<GetAllScansCachedResponse>>>
    {
        public GetAllScansCachedQuery()
        {
        }
    }

    public class GetAllScansCachedQueryHandler : IRequestHandler<GetAllScansCachedQuery, Result<List<GetAllScansCachedResponse>>>
    {
        private readonly IScanCacheRepository _ScanCache;
        private readonly IMapper _mapper;

        public GetAllScansCachedQueryHandler(IScanCacheRepository scanCache, IMapper mapper)
        {
            _ScanCache = scanCache;
            _mapper = mapper;
        }

        public async Task<Result<List<GetAllScansCachedResponse>>> Handle(GetAllScansCachedQuery request, CancellationToken cancellationToken)
        {
            var ScanList = await _ScanCache.GetCachedListAsync();
            var mappedScans = _mapper.Map<List<GetAllScansCachedResponse>>(ScanList);
            return Result<List<GetAllScansCachedResponse>>.Success(mappedScans);
        }
    }
}
