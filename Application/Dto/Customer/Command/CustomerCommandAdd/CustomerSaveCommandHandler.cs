using Application.ApplicationUser;
using AutoMapper;
using Domain.Interfaces;
using MediatR;


namespace Application.Dto.Customer.Command.CustomerCommandAdd
{
    public class CustomerSaveCommandHandler : IRequestHandler<CustomerSaveCommand, Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly IUserContext _userContext;

        public CustomerSaveCommandHandler(ICustomerRepository customerRepository, IMapper mapper, IUserContext userContext)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _userContext = userContext;
        }

        public async Task<Unit> Handle(CustomerSaveCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Domain.Entities.Address>(request);
            customer.CreatedById = _userContext.GetCurrentUser().Id;
            await _customerRepository.Save(customer);

            return Unit.Value;
        }

    }
}
