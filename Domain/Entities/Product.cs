using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public int ProductPrice { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        public ICollection<Order> Orders { get; set; }

    }
}
