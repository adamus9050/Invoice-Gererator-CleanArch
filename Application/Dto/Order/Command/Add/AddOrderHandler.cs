using Application.ApplicationUser;
using Application.Dto.Customer.Command.CustomerCommandAdd;
using AutoMapper;
using Domain.Interfaces;
using MediatR;


namespace Application.Dto.Order.Command.Add
{
    public class AddOrderHandler : IRequestHandler<AddOrderCommand, Unit>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
       // private readonly IUserContext _userContext;

        public AddOrderHandler(IOrderRepository orderRepository, IMapper mapper)// IUserContext userContext)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
           // _userContext = userContext;
        }

        public async Task<Unit> Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Domain.Entities.Order>(request);
            await _orderRepository.Save(order);
            

            return Unit.Value;
        }

    }
    
}
