using AutoMapper;
using Domain.Interfaces;
using MediatR;
using Microsoft.Build.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Commands.CreateCustomer
{
    public class CustomerCommandHandler : IRequestHandler<CustomerCommand,Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository= customerRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Domain.Entities.Customer>(request);
            await _customerRepository.Save(customer);

            return Unit.Value;
        }

    }
}
