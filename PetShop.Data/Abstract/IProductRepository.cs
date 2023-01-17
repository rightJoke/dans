using PetShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Data.Abstract
{
    public interface IProductRepository: IGenericRepository<Product>
    {
        ProductDetail getMaxPrice(int id);
        ProductDetail getMinPrice(int id);
    }
}
