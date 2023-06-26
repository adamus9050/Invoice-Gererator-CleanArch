using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string EmailAdress { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        public ICollection<Order> Orders{ get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
