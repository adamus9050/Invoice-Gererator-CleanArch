using Application.Dto.Material.MaterialCommand.Edit;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Product.ProductCommand.Edit
{
    public class EditProductCommand : ProductDto, IRequest<Unit>
    {

    }        
}
