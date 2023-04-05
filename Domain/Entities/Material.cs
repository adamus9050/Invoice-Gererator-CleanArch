﻿using System.ComponentModel.DataAnnotations.Schema;
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
        public int Id { get; set; }
        [Required(ErrorMessage = "Nazwa materiału jest polem obowiązkowym")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Cena jest polem obowiazkowym")]
        [Column(TypeName = "decimal(6,2)")]
        public double Price { get; set; }
    }
}
