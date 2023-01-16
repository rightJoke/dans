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
        public Animal Animal { get; set; }
        public List<Animal> Animals { get; set; }
    }
}
