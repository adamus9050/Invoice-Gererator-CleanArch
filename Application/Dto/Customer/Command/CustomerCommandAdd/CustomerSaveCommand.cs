using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Customer.Command.CustomerCommandAdd
{
    public class CustomerSaveCommand : CustomerDto, IRequest<Unit>
    {

    }
}
