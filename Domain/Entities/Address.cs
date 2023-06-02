using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string NumberOf { get; set; } = null!;
        public string PostCode { get; set; }
        public string City { get; set; }
    }
}
