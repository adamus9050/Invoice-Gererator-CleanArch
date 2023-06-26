using Domain.Entities;
using MediatR;
using System;
using Application.Dto.Customer.Command;

namespace CustomerCommandDelete
{
    public class CustomerDeleteCommand : Address, IRequest<int>
    {
        public int Id { get; }

        public CustomerDeleteCommand(int id)
        {
            Id = id;
        }
    }
}
