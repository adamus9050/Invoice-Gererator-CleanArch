using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Product.ProductQuerries.List
{
    public class ListProductQuerrie : IRequest<IEnumerable<ProductDto>>
    {

    }
}
