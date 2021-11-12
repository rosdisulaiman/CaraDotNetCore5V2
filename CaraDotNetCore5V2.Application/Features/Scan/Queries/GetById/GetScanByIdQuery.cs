using AspNetCoreHero.Results;
using AutoMapper;
using CaraDotNetCore5V2.Application.Interfaces.CacheRepositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Features.Scan.Queries.GetById
{
    public class GetScanByIdQuery : IRequest<Result<GetScanByIdResponse>>
    {
        public int LogId { get; set; }

        public class GetScanByIdQueryHandler : IRequestHandler<GetScanByIdQuery, Result<GetScanByIdResponse>>
        {
            private readonly IScanCacheRepository _scanCache;
            private readonly IMapper _mapper;

            public GetScanByIdQueryHandler(IScanCacheRepository scanCache, IMapper mapper)
            {
                _scanCache = scanCache;
                _mapper = mapper;
            }

            public async Task<Result<GetScanByIdResponse>> Handle(GetScanByIdQuery query, CancellationToken cancellationToken)
            {
                var scan = await _scanCache.GetByIdAsync(query.LogId);
                var mappedScan = _mapper.Map<GetScanByIdResponse>(scan);
                return Result<GetScanByIdResponse>.Success(mappedScan);
            }
        }
    }
}
