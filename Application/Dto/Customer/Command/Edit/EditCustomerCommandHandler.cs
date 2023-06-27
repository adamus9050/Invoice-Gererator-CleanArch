using Application.ApplicationUser;
using Domain.Interfaces;
using MediatR;


namespace Application.Dto.Customer.Command.Edit
{
    public class EditCustomerCommandHandler : IRequestHandler<EditCustomerCommand,Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        //private readonly IUserContext _userContext;
        public EditCustomerCommandHandler(ICustomerRepository repository, IUserContext userContext)
        {
            _customerRepository = repository;
            //_userContext = userContext;
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

            //customer.CreatedById = _userContext.GetCurrentUser().Id;

            await _customerRepository.Commit();
            return Unit.Value;
        }
    }
}
