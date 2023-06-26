using AutoMapper;
using Domain.Interfaces;
using MaterialQuerries.Search;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Product.ProductQuerries.Search
{
    public class ProductSearchQuerryHandler : IRequestHandler<ProductSearchQuerry, IEnumerable<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductSearchQuerryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> Handle(ProductSearchQuerry request, CancellationToken cancellationToken)
        {
            var materialSearch = await _productRepository.SearchProduct(request.searchStringHandler);
            var list = _mapper.Map<IEnumerable<ProductDto>>(materialSearch);
            return list;

        }
    
    }
}
