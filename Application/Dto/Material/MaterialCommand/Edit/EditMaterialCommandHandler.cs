using Application.Dto.Customer.Command.Edit;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Material.MaterialCommand.Edit
{
    public class EditMaterialCommandHandler : IRequestHandler<EditMaterialCommand, Unit>
    {
        private readonly IHomeRepository _homeRepository;
        public EditMaterialCommandHandler(IHomeRepository repository)
        {
            _homeRepository = repository;
        }


        public async Task<Unit> Handle(EditMaterialCommand request, CancellationToken cancellationToken)
        {
            var editMaterial = await _homeRepository.GetMaterialById(request.Id!);


            editMaterial.Name = request.Name;
            editMaterial.Description = request.Name;
            editMaterial.Price = request.Price;


            await _homeRepository.Commit();
            return Unit.Value;
        }
    }
}
