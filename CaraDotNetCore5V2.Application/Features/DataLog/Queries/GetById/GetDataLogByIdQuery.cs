using AspNetCoreHero.Results;
using AutoMapper;
using CaraDotNetCore5V2.Application.Interfaces.CacheRepositories;
using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Features.DataLog.Queries.GetById
{
    public class GetDatalogByIdQuery : IRequest<Result<GetDatalogByIdResponse>>
    {
        public int Id { get; set; }

        public class GetDatalogByIdQueryHandler : IRequestHandler<GetDatalogByIdQuery, Result<GetDatalogByIdResponse>>
        {
            private readonly IDataLogCacheRepository _datalogCache;
            private readonly IMapper _mapper;

            public GetDatalogByIdQueryHandler(IDataLogCacheRepository datalogCache, IMapper mapper)
            {
                _datalogCache = datalogCache;
                _mapper = mapper;
            }

            public async Task<Result<GetDatalogByIdResponse>> Handle(GetDatalogByIdQuery query, CancellationToken cancellationToken)
            {
                var datalog = await _datalogCache.GetByIdAsync(query.Id);
                var mappedDatalog = _mapper.Map<GetDatalogByIdResponse>(datalog);
                return Result<GetDatalogByIdResponse>.Success(mappedDatalog);
            }
        }

        
    }
}