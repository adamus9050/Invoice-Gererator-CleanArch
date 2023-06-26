using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Customer.Command.Edit
{
    public class EditCustomerCommandHandler : IRequestHandler<EditCustomerCommand,Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        public EditCustomerCommandHandler(ICustomerRepository repository)
        {
            _customerRepository = repository;
        }
        public async Task<Unit> Handle(EditCustomerCommand request, CancellationToken cancellationToken)
        {
            var editCustomer = await _customerRepository.GetAddress(request.Id!);


            editCustomer.CurrentCustomer.Name = request.Name;
            editCustomer.CurrentCustomer.Surname = request.Surname;
            editCustomer.CurrentCustomer.PhoneNumber = request.PhoneNumber;
            editCustomer.CurrentCustomer.EmailAdress = request.EmailAdres;
            editCustomer.Street = request.Street;
            editCustomer.PostCode = request.PostCode;
            editCustomer.NumberOf = request.NumberOf;
            editCustomer.City = request.City;

            await _customerRepository.Commit();
            return Unit.Value;
        }
    }
}
