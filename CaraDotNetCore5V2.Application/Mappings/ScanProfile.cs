using AutoMapper;
using CaraDotNetCore5V2.Application.Features.Face.Commands.Create;
using CaraDotNetCore5V2.Application.Features.Scan.Commands.Create;
using CaraDotNetCore5V2.Application.Features.Scan.Queries.GetAllCached;
using CaraDotNetCore5V2.Application.Features.Scan.Queries.GetAllPaged;
using CaraDotNetCore5V2.Application.Features.Scan.Queries.GetById;
using CaraDotNetCore5V2.Domain.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Mappings
{
    public class ScanProfile : Profile
    {
        public ScanProfile()
        {

            CreateMap<CreateFaceCommand, ScanLogs>();

            CreateMap<ScanLogs, CreateScanCommand>()
                .ForMember(dest => dest.time,
                        opt => opt.MapFrom(src => src.time.ToString()))
                .ForMember(dest => dest.timelocal,
                        opt => opt.MapFrom(src => src.time.ToString()))
                .ReverseMap();

            CreateMap<Face, CreateFaceCommand>().ReverseMap();

            CreateMap<GetScanByIdResponse, ScanLogs>().ReverseMap();
            CreateMap<GetAllScansCachedResponse, ScanLogs>().ReverseMap();
            CreateMap<GetAllScansResponse, ScanLogs>().ReverseMap();

            //CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            //CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            //CreateMap<GetAllProductsResponse, Product>().ReverseMap();





            CreateMap<ScanLogs, GetAllScansCachedResponse>()
                .ForMember(dest => dest.ScanLocation,
                opt => opt.MapFrom(x => string.Join("", x.devid, x.devname)))
                .ForMember(dest => dest.time,
                        opt => opt.MapFrom(src => src.time.ToString()))
                .ForMember(dest => dest.timelocal,
                        opt => opt.MapFrom(src => src.time.ToString()));

            CreateMap<ScanLogs, GetScanByIdResponse>()
                .ForMember(dest => dest.time,
                        opt => opt.MapFrom(src => src.time.ToString()))
                .ForMember(dest => dest.timelocal,
                        opt => opt.MapFrom(src => src.time.ToString()));

          
        }
    }
}
