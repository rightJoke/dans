using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entity
{
    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public Order Order { get; set; }
        public Product product { get; set; }
    }
}
