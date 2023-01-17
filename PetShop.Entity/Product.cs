using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public Genre Genre { get; set; }
        public List<Image> Images { get; set; }
        public List<OrderLine> orderLines { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }
        public DateTime Date { get; set; }
        public bool IsHome { get; set; }
    }
}
