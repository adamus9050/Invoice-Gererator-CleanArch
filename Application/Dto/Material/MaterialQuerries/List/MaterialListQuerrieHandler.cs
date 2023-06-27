using AutoMapper;
using Domain.Interfaces;
using MediatR;


namespace Application.Dto.Material.MaterialQuerries.List
{
    public class MaterialListQuerrieHandler : IRequestHandler<MaterialListQuerrie, IEnumerable<MaterialDto>>
    {
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;
        public MaterialListQuerrieHandler(IHomeRepository homeRepository, IMapper mapper)
        {
            _homeRepository = homeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MaterialDto>> Handle(MaterialListQuerrie request, CancellationToken cancellationToken)
        {
            var materials = await _homeRepository.GetAllMaterials();
            var list = _mapper.Map<IEnumerable<MaterialDto>>(materials);
            return list;
        }
    }
}
