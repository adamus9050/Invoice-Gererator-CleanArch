using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Product.ProductQuerries.Search
{
    public class ProductSearchQuerry : IRequest<IEnumerable<ProductDto>>
    {

        public string searchStringHandler { get; }
        public ProductSearchQuerry(string searchString)
        {
            searchStringHandler = searchString;
        }
    
    }
}
