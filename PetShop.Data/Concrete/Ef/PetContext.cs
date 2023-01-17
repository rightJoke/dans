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
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryDetail> CategoryDetails { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
    }
}
