using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using Domain.Interfaces;

namespace Application.Dto.Customer.CustomerQueries.GetCustomer
{
    public class GetCustomerHandler : IRequestHandler<GetCustomerQuerrie, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public GetCustomerHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }
        public async Task<CustomerDto> Handle(GetCustomerQuerrie request, CancellationToken cancellationToken)
        {
            var details = await _customerRepository.GetCustomer(request.Id);
            var detailsAdres = await _customerRepository.GetAddress(request.Id);
         
            var dtoDetails = _mapper.Map<CustomerDto>(details);
            var dtoDetailsAdres = _mapper.Map<CustomerDto>(detailsAdres);
            return dtoDetailsAdres;
        }
    }
}
