using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dto.Material;
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
