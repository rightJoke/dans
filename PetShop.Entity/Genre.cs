using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entity
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public List<Animal> Animals { get; set; }
        public List<Category> categories { get; set; }
        public List<Product> products { get; set; }
    }
}
