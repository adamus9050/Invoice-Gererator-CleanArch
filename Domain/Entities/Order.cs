using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        [Key]

        public int OrderId { get; set; }

        public int CustomersId { get; set; }
        public Customer Customers { get; set; }

        public int MaterialsId { get; set; }
        public Material Materials { get; set; }

        public int ProductId { get; set; }
        public Product Products { get; set; }


        public Calculate Calculates { get; set; }

    }
}
