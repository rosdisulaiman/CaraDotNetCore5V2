using AutoMapper;
using CaraDotNetCore5V2.Application.Features.Face.Commands.Create;
using CaraDotNetCore5V2.Application.Features.Scan.Commands.Create;
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
            CreateMap<ScanLogs, CreateScanCommand>()
                .ForMember(c => c.ScanLocation,
                        opt => opt.MapFrom(x => string.Join(' ', x.devid, x.devname)))
                .ReverseMap();
            CreateMap<Face, CreateFaceCommand>().ReverseMap();

            //CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            //CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            //CreateMap<GetAllProductsResponse, Product>().ReverseMap();

        }
    }
}
