using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models;
using ArthausWebStore.Models.Interface;
using ArthausWebStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using PagedList.Mvc;

namespace ArthausWebStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsGrid _productRepository;

        public ProductsController(IProductsGrid productsGrid)
        {
            _productRepository = productsGrid;
        }

        public IActionResult Index(string sortOrder,string CurrentFilter,string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;

            var productsViewModel = new ProductsViewModel()
            {
                ItemCategoriesList = _productRepository.GetAllCategories().ToList(),
                ProductGrid = _productRepository.GetAllItems().ToList(),
                ItemPrices = _productRepository.GetAllItemPrices().ToList(),
                ColorsFilter = _productRepository.GetVariants().OrderBy(c => c.Color).ToList(),
                ItemBrandsList = _productRepository.GetAllBrands().ToList(),
                DivisionFilter = _productRepository.GetAllDivisons().ToList(),
                ItemFlags = _productRepository.GetFlags().ToList()
            };
            return View(productsViewModel);
        }

        public IActionResult ViewAccessories()
        {

            return View();
        }


    }
}