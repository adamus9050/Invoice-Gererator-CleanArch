using Application.Dto.Material.MaterialCommand.Edit;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Product.ProductCommand.Edit
{
    public class EditProductCommandHandler : IRequestHandler<EditProductCommand, Unit>
    {
        private readonly IProductRepository _productRepository;
        public EditProductCommandHandler(IProductRepository repository)
        {
            _productRepository = repository;
        }

        public async Task<Unit> Handle(EditProductCommand request, CancellationToken cancellationToken)
        {
            var editMaterial = await _productRepository.GetProductById(request.ProductId!);


            editMaterial.ProductName = request.ProductName;
            editMaterial.Type = request.Type;
            editMaterial.ProductPrice = request.ProductPrice;


            await _productRepository.Commit();
            return Unit.Value;
        }
    }
}
