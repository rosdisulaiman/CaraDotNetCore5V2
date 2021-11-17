using AutoMapper;
using CaraDotNetCore5V2.Application.Features.DataLog.Commands.Create;
using CaraDotNetCore5V2.Domain.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Mappings
{
    internal class DataLogProfile : Profile
    {
        public DataLogProfile()
        {
            CreateMap<Root, CreateDataLogCommand>()
            .ForMember(dest => dest.time, opt => opt.MapFrom(src => DateTimeOffset.FromUnixTimeSeconds(src.time).DateTime))
            .ForMember(dest => dest.timelocal, opt => opt.MapFrom(src => DateTimeOffset.FromUnixTimeSeconds(src.timelocal).DateTime));
            CreateMap<CaraDotNetCore5V2.Application.Features.DataLog.Commands.Create.Face, CreateDataLogCommand>();
            CreateMap<CreateDataLogCommand, DataLog>().ReverseMap();

        }
    }
}
