using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Dto.Product.ProductQuerries.Get
{
    public class GetProductQuerry : IRequest<ProductDto>
    {
        public int Id { get; set; }

        public GetProductQuerry(int id)
        {
            this.Id = id;
        }

    }
}
