using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public List<OrderLine> orderLines { get; set; }
    }
}
