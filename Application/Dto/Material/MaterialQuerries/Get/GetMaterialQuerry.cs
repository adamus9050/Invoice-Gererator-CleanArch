using Application.Dto.Customer.CustomerQueries.GetCustomer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
