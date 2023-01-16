using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entity
{
    public class Page
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string Description { get; set; }
        public List<PageImage> Images { get; set; }
    }
    public class PageImage
    {
        public int PageImageId { get; set; }
        public string Url { get; set; }
        public List<Page> Pages { get; set; }
    }
}
