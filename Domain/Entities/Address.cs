using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Address
    {
     
        public int AddressId { get; set; }
        public string Street { get; set; } = default!;
        public string NumberOf { get; set; } = null!;
        public string PostCode { get; set; } = default!;
        public string City { get; set; } = default!;
        public int CurrentCustomerId { get; set; }
        public Customer CurrentCustomer { get; set; }

    }
}
