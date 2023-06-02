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
        //public string Street { get; set; }
        //public string NumberOf { get; set; }
        //public string PostCode { get; set; }
        //public string City { get; set; }
        public DetailssCustomer(int id)
        {
            Id = id;
            //Street=street;
            //NumberOf=numberOf;
            //PostCode=postCode;
            //City = city;
        }
    }
}
