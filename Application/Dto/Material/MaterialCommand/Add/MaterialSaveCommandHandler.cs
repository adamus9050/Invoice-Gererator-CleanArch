using Application.Dto.Customer.Command.CustomerCommandAdd;
using AutoMapper;
using Domain.Interfaces;
using Application.Dto.Material.MaterialCommand.Add;
using MediatR;


namespace Application.Dto.Material.MaterialCommand.Add
{
    public class MaterialSaveCommandHandler : IRequestHandler<MaterialSaveCommand, Unit>
    {
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;

        public MaterialSaveCommandHandler(IHomeRepository homeRepository, IMapper mapper)
        {
            _homeRepository= homeRepository;
            _mapper= mapper;
        }
        
        public async Task<Unit> Handle(MaterialSaveCommand request, CancellationToken cancellationToken)
        {
            var material = _mapper.Map<Domain.Entities.Material>(request);
            await _homeRepository.SaveMaterials(material);

            return Unit.Value;
        }
    }
}
