using MediatR;

namespace Application.Dto.Material.MaterialCommand.Add
{
    public class MaterialSaveCommand : MaterialDto, IRequest<Unit>
    {

    }
}
