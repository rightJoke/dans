using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entity
{
    public class ProductDetail
    {
        [Key]
        public int ProductDetailId { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public string Details { get; set; }
        public string IngredientsAndAnalysis { get; set; }
        public string ShippingAndReturns { get; set; }
        public Product Product { get; set; }
    }
}
