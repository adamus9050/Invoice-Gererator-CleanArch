using AutoMapper;
using CustomerQueries.Search;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Customer.CustomerQueries.Search
{
    public class SearchCustomerHandler : IRequestHandler<CustomerSearchQuerry, IEnumerable<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public SearchCustomerHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CustomerDto>> Handle(CustomerSearchQuerry request, CancellationToken cancellationToken)
        {

                var result = await _customerRepository.Search(request.SearchCustomer);
                var customer = _mapper.Map<IEnumerable<CustomerDto>>(result);
                return customer;

        }
    }
}
