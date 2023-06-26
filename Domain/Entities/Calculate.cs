using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Calculate
    {
        public int CalculateId { get; set; }


        public int OrderId { get; set; }
        public Order Orders { get; set; }

    }
}
