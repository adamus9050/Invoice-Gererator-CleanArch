using AutoMapper;
using CustomerCommandDelete;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.Dto.Customer.Command.CustomerCommandDelete
{
    public class CustomerDeleteCommandHandler : IRequestHandler<CustomerDeleteCommand, int>
    {
        ICustomerRepository _customerRepository;
        IMapper _mapper;
        public CustomerDeleteCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CustomerDeleteCommand request, CancellationToken cancellationToken)
        {
            var customerDelete = await _customerRepository.DeleteCustomers(request.Id);
            return customerDelete.CustomerId;
        }
    }
}
