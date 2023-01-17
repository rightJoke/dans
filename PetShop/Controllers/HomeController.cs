using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PetShop.Data.Abstract;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class HomeController : Controller
    {

        private IProductRepository ProductRepository;
        private IPageRepository pageRepository;
        public HomeController(IPageRepository _pageRepository, IProductRepository _ProductRepository)
        {
            pageRepository = _pageRepository;
            ProductRepository = _ProductRepository;
        }
        public IActionResult Index()
        {
            return View(ProductRepository.GetAll().Where(i=>i.IsHome)
                .Include(i=>i.Images)
                .Include(i=>i.ProductDetails)
                .Include(i=>i.Genre)
                .Select(i=>new ProductListModel()
                {
                    Product = i,
                    ProductDetails=i.ProductDetails,
                    Images=i.Images,
                    Genre=i.Genre
                }).ToList()
                );



        }

        public IActionResult About(int id=1)
        {
            var entity = pageRepository.Get(id);
            if (entity != null)
            {
                return View(entity);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
