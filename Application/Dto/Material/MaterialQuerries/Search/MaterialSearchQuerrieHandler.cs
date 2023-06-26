using Domain.Interfaces;
using AutoMapper;
using MediatR;
using MaterialQuerries.Search;
using Domain.Entities;

namespace Application.Dto.Material.MaterialQuerries.Search
{
    public class MaterialSearchQuerrieHandler : IRequestHandler<MaterialSearchQuerrie, IEnumerable<MaterialDto>>
    {
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;

        public MaterialSearchQuerrieHandler(IHomeRepository homeRepository, IMapper mapper)
        {
            _homeRepository = homeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MaterialDto>> Handle(MaterialSearchQuerrie request, CancellationToken cancellationToken)
        {
            var materialSearch = await _homeRepository.SearchMaterial(request.searchStringHandler);
            var list = _mapper.Map<IEnumerable<MaterialDto>>(materialSearch);
            return list;
            
        }

    }
}
