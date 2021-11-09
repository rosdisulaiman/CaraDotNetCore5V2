using CaraDotNetCore5V2.Application.Interfaces.Repositories;
using CaraDotNetCore5V2.Domain.Entities.Catalog;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;
using CaraDotNetCore5V2.Application.Features.Face.Commands.Create;
using System.Collections.Generic;

namespace CaraDotNetCore5V2.Application.Features.Products.Commands.Create
{
    public partial class CreateProductCommand : IRequest<Result<int>>
    {
        public int LogId { get; set; }
        public DateTime LoggedTime { get; set; }
        public string ScanLocation { get; set; }
        public int time { get; set; }
        public int timelocal { get; set; }
        public List<CreateFaceCommand> Faces { get; set; }
    }

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Result<int>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        private IUnitOfWork _unitOfWork { get; set; }

        public CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            await _productRepository.InsertAsync(product);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(product.Id);
        }
    }
}