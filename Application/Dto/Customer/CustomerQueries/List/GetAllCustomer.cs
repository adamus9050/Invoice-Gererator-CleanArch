using MediatR;

namespace Application.Dto.Customer.CustomerQueries.List
{
    public class GetAllCustomer : IRequest<IEnumerable<CustomerDto>>
    {

    }
}
