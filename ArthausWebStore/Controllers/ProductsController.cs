using ArthausWebStore.Models;
using ArthausWebStore.Models.Interface;
using ArthausWebStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Controllers
{
    public class ProductsController : Controller
    {
     
        private readonly IProductsGrid _pictureRepository;

        public ProductsController(IProductsGrid productRepostiory)
        {
            //constructor injection; we receive dbContext from Startup class
            _pictureRepository = productRepostiory;
        }

        public IActionResult ProductGrid()
        {
            ViewData["Message"] = "Welcome to Arthuis Furniture Online Shop";

            var productModelView = new ProductsViewModel()
            {
                //NewProducts = _pictureRepository.GetFlaggedList(FlagType.NewArrival, 8).OrderBy(p => p.Description2).ToList(),
                //FeaturedProducts = _pictureRepository.GetFlaggedList(FlagType.FeaturedProduct, 8).OrderBy(p => p.Description2).ToList(),
                //DiscountedProducts = _pictureRepository.GetFlaggedList(FlagType.DiscountedProduct, 8).OrderBy(p => p.Description2).ToList(),
                //BestSellingProducts = _pictureRepository.GetFlaggedList(FlagType.BestSeller, 8).OrderBy(p => p.Description2).ToList(),
                //MostViewedProducts = _pictureRepository.GetFlaggedList(FlagType.MostViewed, 8).OrderBy(p => p.Description2).ToList(),
                //ItemPrices = _pictureRepository.GetAllItemPrices().ToList(),
                //ItemBrandsList = _pictureRepository.GetAllBrands().OrderBy(b => b.Code).ToList(),
                //ItemCategoriesList = _pictureRepository.GetAllCategories().OrderBy(c => c.PresentationOrder).ToList(),
                //ItemDivisionsList = _pictureRepository.GetAllDivisons().OrderBy(d => d.DivisionCode).ToList(),
                //DiscountedPrices = _pictureRepository.GetDiscoutnedPrices().ToList()
            };
            return View(productModelView);
        }



        //public ActionResult GetImage()
        //{


        //}


    }
}
