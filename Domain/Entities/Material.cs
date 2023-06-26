using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Entities
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        [Column(TypeName = "decimal(6,2)")]
        public double Price { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
