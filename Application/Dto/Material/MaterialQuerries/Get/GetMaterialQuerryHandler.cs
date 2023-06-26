﻿using Application.Dto.Customer.CustomerQueries.GetCustomer;
using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Material.MaterialQuerries.Get
{
    public class GetMaterialQuerryHandler: IRequestHandler<GetMaterialQuerry, MaterialDto>
    {
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;
        public GetMaterialQuerryHandler(IHomeRepository homeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _homeRepository = homeRepository;
        }

        public async Task<MaterialDto> Handle(GetMaterialQuerry request, CancellationToken cancellationToken)
        {
            var details = await _homeRepository.GetMaterialById((request.Id));

            var dtoDetails = _mapper.Map<MaterialDto>(details);

            return dtoDetails;
        }
    }
}
