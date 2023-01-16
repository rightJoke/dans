using Microsoft.AspNetCore.Mvc;
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


        private IPageRepository pageRepository;
        public HomeController(IPageRepository _pageRepository)
        {
            pageRepository = _pageRepository;

        }
        public IActionResult Index()
        {
            return View();
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
