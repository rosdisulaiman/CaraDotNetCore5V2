using AspNetCoreHero.Results;
using AutoMapper;
using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CaraDotNetCore5V2.Application.Features.DataLog.Commands.Create
{
    public class CreateDataLogCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        public int? LogId { get; set; }
        public string camid { get; set; }
        public string devid { get; set; }
        public string devname { get; set; }
        public string devno { get; set; }

        public DateTimeOffset time { get; set; }
        public DateTimeOffset timelocal { get; set; }

        //public int? time { get; set; }
        //public int? timelocal { get; set; }
        public DateTime LoggedTime { get; set; } = DateTime.Now;
        public string QRcode { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int? age { get; set; }
        public string cardNum { get; set; }
        public string certificateNumber { get; set; }
        public int? certificateType { get; set; }
        public string commonUuid { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string groupId { get; set; }
        public string image { get; set; }
        public string orgimg { get; set; }
        public string personId { get; set; }
        public string personUuid { get; set; }
        public string phone { get; set; }
        public float? temperature { get; set; }
        public string temperatureAlarm { get; set; }
        public int? timestamp { get; set; }
        public int? trackId { get; set; }
        public string userId { get; set; }

    }

    public class CreateDataLogCommandHandler : IRequestHandler<CreateDataLogCommand, Result<int>>
    {

        private readonly IDataLogRepository _dataLogRepository;
        private readonly IMapper _mapper;
        private IUnitOfWork _unitOfWork { get; set; }

        public CreateDataLogCommandHandler(IDataLogRepository dataLogRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _dataLogRepository = dataLogRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<int>> Handle(CreateDataLogCommand request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<CaraDotNetCore5V2.Domain.Entities.Data.DataLog>(request);
            await _dataLogRepository.InsertAsync(result);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(result.Id);
        }
    }

}
