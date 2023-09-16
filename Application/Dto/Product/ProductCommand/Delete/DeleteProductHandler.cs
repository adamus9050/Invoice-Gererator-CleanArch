using AutoMapper;
using Domain.Interfaces;
using MaterialCommand.Delete;
using MediatR;
using ProductCommand.Delete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Product.ProductCommand.Delete
{
    public class DeleteProductHandler: IRequestHandler<DeleteProductCommand, int>
    {

            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public DeleteProductHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
            {
                var productDelete = await _productRepository.DeleteProduct(request.Id);
                return productDelete.ProductId;
            }
        
    }
}
