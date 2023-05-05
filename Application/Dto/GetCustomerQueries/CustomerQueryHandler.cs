using Application.Dto.Commands.Queries.GetCustomerQueries;
using Application.Services;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.GetCustomerQueries
{
    public class CustomerQueryHandler : IRequestHandler<GetCustomerQuery, IEnumerable<CustomerDto>>
    {
        private readonly IMapper _mapper;
        private readonly IDataCustomerService _customerService;
        public CustomerQueryHandler(IDataCustomerService customerService,IMapper mapper)
        {
             _customerService=customerService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CustomerDto>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customers = await _customerService.GetAll();
            var customerdto = _mapper.Map<IEnumerable<CustomerDto>>(customers);

            return customerdto;
        }
    }
}
