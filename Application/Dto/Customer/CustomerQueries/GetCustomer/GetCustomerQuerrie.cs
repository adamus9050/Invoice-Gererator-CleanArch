using MediatR;

namespace Application.Dto.Customer.CustomerQueries.GetCustomer
{
    public class GetCustomerQuerrie : IRequest<CustomerDto>
    {
        public int Id { get; set; }
        public GetCustomerQuerrie(int id)
        {
            Id= id;
        }

    }
}
