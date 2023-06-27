using MediatR;

namespace Application.Dto.Customer.Command.CustomerCommandAdd
{
    public class CustomerSaveCommand : CustomerDto, IRequest<Unit>
    {

    }
}
