using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Customer.CustomerQueries.Details
{
    public class DetailssCustomer : IRequest<CustomerDto>
    {
        public int Id { get; set; }

        public DetailssCustomer(int id)
        {
            Id = id;
        }
    }
}
