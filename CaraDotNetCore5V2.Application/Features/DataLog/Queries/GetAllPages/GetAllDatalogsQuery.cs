using AspNetCoreHero.Results;
using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CaraDotNetCore5V2.Domain.Entities.Data;
using CaraDotNetCore5V2.Application.Extensions;

namespace CaraDotNetCore5V2.Application.Features.DataLog.Queries.GetAllPages
{
    public class GetAllDatalogsQuery : IRequest<PaginatedResult<GetAllDatalogsResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllDatalogsQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }

    public class GetAllDatalogsQueryHandler : IRequestHandler<GetAllDatalogsQuery, PaginatedResult<GetAllDatalogsResponse>>
    {
        private readonly IDataLogRepository _repository;

        public GetAllDatalogsQueryHandler(IDataLogRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaginatedResult<GetAllDatalogsResponse>> Handle(GetAllDatalogsQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<CaraDotNetCore5V2.Domain.Entities.Data.DataLog, GetAllDatalogsResponse>> expression = e => new GetAllDatalogsResponse
            {
                Id = e.Id,
                name = e.name,
                timelocal = e.timelocal,
                temperature = e.temperature,
                devname = e.devname,
            };
            var paginatedList = await _repository.Datalogs
                .Select(expression)
                .ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return paginatedList;
        }
    }
}
