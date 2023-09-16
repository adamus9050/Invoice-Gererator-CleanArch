using MediatR;
using Application.Dto;

namespace MaterialQuerries.Search
{
    public class MaterialSearchQuerrie : IRequest<IEnumerable<MaterialDto>>
    {
    
        public string searchStringHandler { get;}
        public MaterialSearchQuerrie(string searchString) 
        {
            searchStringHandler=searchString;
        }
    }
}
