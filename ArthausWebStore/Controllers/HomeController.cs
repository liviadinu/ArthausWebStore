using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArthausWebStore.Models;
using ArthausWebStore.Models.Interface;
using ArthausWebStore.ViewModels;
using System.Diagnostics;

namespace ArthausWebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISkuItemsList _itemRepository;

        public HomeController(ISkuItemsList itemRepository)
        {
            //constructor injection; we receive dbContext from Startup class
            _itemRepository = itemRepository;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to Arthuis Furniture Online Shop";

            var homeViewModel = new HomeViewModel()
            {
                NewProducts = _itemRepository.GetFlaggedList(FlagType.NewArrival, 8).OrderBy(p => p.Description2).ToList(),
                FeaturedProducts = _itemRepository.GetFlaggedList(FlagType.FeaturedProduct, 8).OrderBy(p => p.Description2).ToList(),
                DiscountedProducts = _itemRepository.GetFlaggedList(FlagType.DiscountedProduct, 8).OrderBy(p => p.Description2).ToList(),
                BestSellingProducts = _itemRepository.GetFlaggedList(FlagType.BestSeller, 8).OrderBy(p => p.Description2).ToList(),
                MostViewedProducts = _itemRepository.GetFlaggedList(FlagType.MostViewed, 8).OrderBy(p => p.Description2).ToList(),
                ItemPrices = _itemRepository.GetAllItemPrices().ToList(),
                ItemBrandsList = _itemRepository.GetAllBrands().OrderBy(b => b.Code).ToList(),
                ItemCategoriesList = _itemRepository.GetAllCategories().OrderBy(c => c.PresentationOrder).ToList(),
                ItemDivisionsList = _itemRepository.GetAllDivisons().OrderBy(d => d.DivisionCode).ToList(),
                DiscountedPrices = _itemRepository.GetDiscoutnedPrices().ToList(),
            };
            return View(homeViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        [Route("ProductQuick",Name ="productsquickvalue")]
        public IActionResult QuickView(string ItemSKU)
        {
           
            return ViewComponent("ProductQuick", new { SKU  = ItemSKU });
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
