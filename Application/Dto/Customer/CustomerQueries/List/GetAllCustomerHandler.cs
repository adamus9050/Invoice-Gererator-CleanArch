//using Application.Services;
using Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace Application.Dto.Customer.CustomerQueries.List
{
    public class GetAllCustomerHandler : IRequestHandler<GetAllCustomer, IEnumerable<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetAllCustomerHandler(ICustomerRepository customerService, IMapper mapper)
        {
            _customerRepository = customerService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CustomerDto>> Handle(GetAllCustomer request, CancellationToken cancellationToken)
        {
            var customers = await _customerRepository.GetAll();
            var customerdto = _mapper.Map<IEnumerable<CustomerDto>>(customers);

            return customerdto;
        }
    }
}
