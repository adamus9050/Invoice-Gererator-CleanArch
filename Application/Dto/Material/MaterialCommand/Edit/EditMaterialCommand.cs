using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Material.MaterialCommand.Edit
{
    public class EditMaterialCommand : MaterialDto, IRequest<Unit>
    {

    }
}
