using CaraDotNetCore5V2.Application.Features.Brands.Commands.Create;
using CaraDotNetCore5V2.Application.Features.Brands.Commands.Update;
using CaraDotNetCore5V2.Application.Features.Brands.Queries.GetAllCached;
using CaraDotNetCore5V2.Application.Features.Brands.Queries.GetById;
using CaraDotNetCore5V2.Web.Areas.Catalog.Models;
using AutoMapper;

namespace CaraDotNetCore5V2.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}