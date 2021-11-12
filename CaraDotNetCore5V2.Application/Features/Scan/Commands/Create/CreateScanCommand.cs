using AspNetCoreHero.Results;
using AutoMapper;
using CaraDotNetCore5V2.Application.Features.Face.Commands.Create;
using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using CaraDotNetCore5V2.Domain.Entities.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Features.Scan.Commands.Create
{
    public class CreateScanCommand : IRequest<Result<int>>
    {
        public int LogId { get; set; }
        public DateTime LoggedTime { get; set; } = DateTime.Now;
        public string devid { get; set; }
        public string devname { get; set; }
        public int time { get; set; }
        public int timelocal { get; set; }
        public List<CreateFaceCommand> Faces { get; set; }
    }

    public class CreateScanCommandHandler : IRequestHandler<CreateScanCommand, Result<int>>
    {
        private readonly IScanRepository _scanRepository;
        private readonly IMapper _mapper;

        private IUnitOfWork _unitOfWork { get; set; }

        public CreateScanCommandHandler(IScanRepository scanRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _scanRepository = scanRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateScanCommand request, CancellationToken cancellationToken)
        {
            var Scan = _mapper.Map<ScanLogs>(request);
            await _scanRepository.InsertAsync(Scan);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(Scan.LogId);
        }
    }
}
