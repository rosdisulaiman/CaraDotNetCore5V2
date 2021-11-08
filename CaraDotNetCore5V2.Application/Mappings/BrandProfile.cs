using CaraDotNetCore5V2.Application.Features.Brands.Commands.Create;
using CaraDotNetCore5V2.Application.Features.Brands.Queries.GetAllCached;
using CaraDotNetCore5V2.Application.Features.Brands.Queries.GetById;
using CaraDotNetCore5V2.Domain.Entities.Catalog;
using AutoMapper;

namespace CaraDotNetCore5V2.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}