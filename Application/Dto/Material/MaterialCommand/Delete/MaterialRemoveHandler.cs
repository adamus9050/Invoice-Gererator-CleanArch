﻿using AutoMapper;
using Domain.Interfaces;
using MaterialCommand.Delete;
using MediatR;

namespace Application.Dto.Material.MaterialCommand.Delete
{
    public class MaterialRemoveHandler : IRequestHandler<MaterialRemove,int>
    {
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;

        public MaterialRemoveHandler(IHomeRepository homeRepository, IMapper mapper)
        {
            _homeRepository= homeRepository;
            _mapper= mapper;
        }

        public async Task<int> Handle(MaterialRemove request, CancellationToken cancellationToken)
        {
            var materialDelete = await _homeRepository.DeleteMaterial(request.Id);
            return materialDelete.MaterialId;
        }
    }
}
