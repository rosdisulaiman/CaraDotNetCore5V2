﻿using AspNetCoreHero.Results;
using CaraDotNetCore5V2.Application.Extensions;
using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using CaraDotNetCore5V2.Domain.Entities.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Features.Scan.Queries.GetAllPaged
{
    public class GetAllScansQuery : IRequest<PaginatedResult<GetAllScansResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllScansQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }

    public class GGetAllScansQueryHandler : IRequestHandler<GetAllScansQuery, PaginatedResult<GetAllScansResponse>>
    {
        private readonly IScanRepository _repository;

        public GGetAllScansQueryHandler(IScanRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaginatedResult<GetAllScansResponse>> Handle(GetAllScansQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<ScanLogs, GetAllScansResponse>> expression = e => new GetAllScansResponse
            {
                LogId = e.LogId,
                LoggedTime = e.LoggedTime,
                time = e.time,
                timelocal = e.timelocal
                
            };
            var paginatedList = await _repository.Scans
                .Select(expression)
                .ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return paginatedList;
        }
    }
}
