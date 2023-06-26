using MediatR;
using Domain.Entities;
using Application.Dto;

namespace CustomerQueries.Search
{
    public class CustomerSearchQuerry : IRequest<IEnumerable<CustomerDto>>
    {
        public string SearchCustomer { get;}
        public CustomerSearchQuerry(string searchCust) 
        {
            SearchCustomer= searchCust;
        }
    }
}
