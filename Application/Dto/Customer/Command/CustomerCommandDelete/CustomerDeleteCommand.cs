using Domain.Entities;
using MediatR;

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
