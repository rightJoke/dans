using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entity
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public int Age { get; set; }
        public bool hasIssue { get; set; }
        public string PhotoUrl { get; set; }
        public string TinyPhotoUrl { get; set; }
        public Genre Genre { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
