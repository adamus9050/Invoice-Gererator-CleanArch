using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Product.ProductQuerries.List
{
    public class ListProductOrderHandler : IRequestHandler<ListProductQuerrie, IEnumerable<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ListProductOrderHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> Handle(ListProductQuerrie request, CancellationToken cancellationToken)
        {
            var productList = await _productRepository.ProducList();
            var productMap = _mapper.Map<IEnumerable<ProductDto>>(productList);
            return productMap;
        }
    }
}
