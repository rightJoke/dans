using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Data.Abstract
{
   public interface IGenericRepository<T>where T:class
    {
        T Get(int id);
        IQueryable<T> GetAll();

    }
}
