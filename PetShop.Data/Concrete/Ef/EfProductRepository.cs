using PetShop.Data.Abstract;
using PetShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Data.Concrete.Ef
{
    public class EfProductRepository: EfGenericRepository<Product>,IProductRepository
    {
        public EfProductRepository(PetContext context): base(context)
        {

        }
        public PetContext petContext
        {
            get
            {
                return context as PetContext;
            }
        }
        public ProductDetail getMaxPrice(int id)
        {
            return petContext.ProductDetails.Where(i => i.Product.ProductId == id).OrderByDescending(i=>i.Price).FirstOrDefault();
        }
        public ProductDetail getMinPrice(int id)
        {
            return petContext.ProductDetails.Where(i => i.Product.ProductId == id).OrderBy(i => i.Price).FirstOrDefault();
        }
    }
}
