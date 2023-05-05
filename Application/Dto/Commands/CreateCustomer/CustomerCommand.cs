using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Commands.CreateCustomer
{
    public class CustomerCommand : CustomerDto, IRequest<Unit>
    {

    }
}
