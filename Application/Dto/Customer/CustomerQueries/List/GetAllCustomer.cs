using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Customer.CustomerQueries.List
{
    public class GetAllCustomer : IRequest<IEnumerable<CustomerDto>>
    {

    }
}
