using MediatR;
using Domain.Entities;

namespace MaterialCommand.Delete
{
    public class MaterialRemove : Material, IRequest<int>
    {
        public int Id { get;}

        public MaterialRemove(int id)
        {
            Id = id;
        }
    }
}
