using MediatR;
using Domain.Entities;
using Application.Dto.Material;

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
