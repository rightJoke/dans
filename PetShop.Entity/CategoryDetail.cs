using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entity
{
    public class CategoryDetail
    {
        public int CategoryDetailId { get; set; }
        public string CategoryDetailName { get; set; }
        public Category Category { get; set; }
    }
}
