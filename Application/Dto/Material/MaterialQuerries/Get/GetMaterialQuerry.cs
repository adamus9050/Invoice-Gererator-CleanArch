using MediatR;

namespace Application.Dto.Material.MaterialQuerries.Get
{
    public class GetMaterialQuerry: IRequest<MaterialDto>
    {
        public int Id { get; set; }

        public GetMaterialQuerry(int id)
        {
            this.Id = id;
        }
    }
}
