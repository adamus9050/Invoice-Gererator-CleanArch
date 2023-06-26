using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
