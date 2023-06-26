using Application.Dto.Material.MaterialCommand.Add;
using MediatR;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Application.Dto.Product.ProductCommand.Add
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public AddProductHandler(IMapper mapper, IProductRepository homeRepository) { 
            _mapper = mapper;
            _productRepository = homeRepository;
        }
        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Domain.Entities.Product>(request);
            await _productRepository.AddProduct(product);

            return Unit.Value;
        }
    }
}
