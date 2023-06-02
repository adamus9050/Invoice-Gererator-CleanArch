using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dto.Customer.Command;

namespace CustomerCommandDelete
{
    public class CustomerDeleteCommand : Customer, IRequest<int>
    {
        public new int Id { get; }

        public CustomerDeleteCommand(int id)
        {
            Id = id;
        }
    }
}
