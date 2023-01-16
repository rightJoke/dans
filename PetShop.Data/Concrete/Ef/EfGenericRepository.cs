using Microsoft.EntityFrameworkCore;
using PetShop.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Data.Concrete.Ef
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext context;
        public EfGenericRepository(DbContext ctx)
        {
            context = ctx;
        }
        public T Get(int Id)
        {
            
            return context.Set<T>().Find(Id);
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
