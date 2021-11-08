using CaraDotNetCore5V2.Application.Features.Products.Commands.Create;
using CaraDotNetCore5V2.Application.Features.Products.Commands.Update;
using CaraDotNetCore5V2.Application.Features.Products.Queries.GetAllCached;
using CaraDotNetCore5V2.Application.Features.Products.Queries.GetById;
using CaraDotNetCore5V2.Web.Areas.Catalog.Models;
using AutoMapper;

namespace CaraDotNetCore5V2.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}