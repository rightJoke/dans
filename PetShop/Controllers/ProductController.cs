using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShop.Data.Abstract;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository ProductRepository;
        public ProductController(IProductRepository _ProductRepository)
        {
            ProductRepository = _ProductRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int? id)
        {
            if(id!=null)
            {
                var product = ProductRepository.GetAll().Where(i => i.ProductId == id)
                .Include(i => i.Images)
                .Include(i => i.ProductDetails)
                .Select(i => new ProductListModel()
                {
                    Product = i,
                    ProductDetails = i.ProductDetails,
                    Images = i.Images
                }).ToList();
                ViewBag.minPrice = ProductRepository.getMinPrice((int)id).Price;
                ViewBag.maxPrice = ProductRepository.getMaxPrice((int)id).Price;
               
                return View(product);
            }
            return RedirectToAction("Index");
        }
    }
}
