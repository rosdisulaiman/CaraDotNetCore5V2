using CaraDotNetCore5V2.Application.Features.Products.Commands.Create;
using CaraDotNetCore5V2.Application.Features.Products.Queries.GetAllCached;
using CaraDotNetCore5V2.Application.Features.Products.Queries.GetAllPaged;
using CaraDotNetCore5V2.Application.Features.Products.Queries.GetById;
using CaraDotNetCore5V2.Domain.Entities.Catalog;
using AutoMapper;

namespace CaraDotNetCore5V2.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}