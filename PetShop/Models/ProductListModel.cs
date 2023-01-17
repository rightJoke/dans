using PetShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class ProductListModel
    {
        public Product Product { get; set; }
        public IEnumerable<Image> Images  { get; set; }
        public IEnumerable<ProductDetail> ProductDetails { get; set; }
    }
}
