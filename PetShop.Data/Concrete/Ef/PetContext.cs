using Microsoft.EntityFrameworkCore;
using PetShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Data.Concrete.Ef
{
    public class PetContext:DbContext
    {
        public PetContext(DbContextOptions<PetContext> options)
            : base(options)
        {

        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
