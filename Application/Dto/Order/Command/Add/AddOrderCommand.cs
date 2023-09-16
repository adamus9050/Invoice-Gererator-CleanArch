using MediatR;

namespace Application.Dto.Order.Command.Add
{
    public class AddOrderCommand : OrderDto, IRequest<Unit>
    {

    }
}
