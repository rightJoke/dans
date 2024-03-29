﻿using PetShop.Data.Abstract;
using PetShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Data.Concrete.Ef
{
    public class EfPageRepository : EfGenericRepository<Page>, IPageRepository
    {
        public EfPageRepository(PetContext context) : base(context)
        {

        }
        public PetContext petContext
        {
            get
            {
                return context as PetContext; 
            }
        }
    }
}
