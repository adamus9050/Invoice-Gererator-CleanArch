using AutoMapper;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Customer.CustomerQueries.Details
{
    public class DetailsCustomerHandler : IRequestHandler<DetailssCustomer, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public DetailsCustomerHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }
        public async Task<CustomerDto> Handle(DetailssCustomer request, CancellationToken cancellationToken)
        {
            var details = await _customerRepository.GetAddress(request.Id);
            var dtoDetails = _mapper.Map<CustomerDto>(details);
            return dtoDetails;
        }
    }
}
