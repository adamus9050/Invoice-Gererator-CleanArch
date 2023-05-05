using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Commands.Queries.GetCustomerQueries
{
    public class GetCustomerQuery : IRequest<IEnumerable<CustomerDto>>
    {

    }
}
