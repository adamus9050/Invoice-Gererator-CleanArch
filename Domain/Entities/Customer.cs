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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }

        //public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
