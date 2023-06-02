using AutoMapper;
using Domain.Interfaces;
using MediatR;


namespace Application.Dto.Customer.Command.CustomerCommandAdd
{
    public class CustomerSaveCommandHandler : IRequestHandler<CustomerSaveCommand, Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerSaveCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CustomerSaveCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Domain.Entities.Customer>(request);
            await _customerRepository.Save(customer);

            return Unit.Value;
        }

    }
}
