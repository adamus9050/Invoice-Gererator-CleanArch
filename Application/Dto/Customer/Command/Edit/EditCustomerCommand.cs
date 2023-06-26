using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Customer.Command.Edit
{
    public class EditCustomerCommand : CustomerDto, IRequest<Unit>//<int>
    {
        //public int Id { get; set; }

        //public EditCustomerCommand(int id)
        //{
        //    Id = id;
        //}
    }
}
