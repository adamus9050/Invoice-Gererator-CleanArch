using MediatR;


namespace Application.Dto.Material.MaterialCommand.Edit
{
    public class EditMaterialCommand : MaterialDto, IRequest<Unit>
    {

    }
}
