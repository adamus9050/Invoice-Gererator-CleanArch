using Application.Dto.Material.MaterialQuerries.Get;
using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Product.ProductQuerries.Get
{
    public class GetProductQuerryHandler : IRequestHandler<GetProductQuerry, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public GetProductQuerryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<ProductDto> Handle(GetProductQuerry request, CancellationToken cancellationToken)
        {
            var details = await _productRepository.GetProductById((request.Id));

            var dtoDetails = _mapper.Map<ProductDto>(details);

            return dtoDetails;
        }
    }
   
}
