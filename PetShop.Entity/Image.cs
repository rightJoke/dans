using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entity
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string SmallImageUrl { get; set; }
        public bool IsActive { get; set; }
        public Product Product { get; set; }
    }
}
