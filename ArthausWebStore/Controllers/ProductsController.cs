using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models;
using ArthausWebStore.Models.Interface;
using ArthausWebStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using PagedList;
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

        public IActionResult Index(string sortOrder,string currentFilter,string searchString, int? page)
        {
            
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "descript_desc" : "";
            //ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";


            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            ViewBag.CurrentFilter = searchString;
            var products = _productRepository.GetAllItems().ToPagedList(pageNumber, pageSize);
           
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.Description2.Contains(searchString) ||
                                     p.SearchDescription.Contains(searchString)).ToPagedList(pageNumber, pageSize);                                   
            }

            var productsViewModel = new ProductsViewModel()
            {
                ItemCategoriesList = _productRepository.GetAllCategories().Take(8).ToList(),
                ProductGrid = _productRepository.GetAllItems().ToList(),
                ProductPages = products,
                ItemPrices = _productRepository.GetAllItemPrices().ToList(),
                ColorsFilter = _productRepository.GetVariants().OrderBy(c => c.Color).ToList(),
                ItemBrandsList = _productRepository.GetAllBrands().ToList(),
                DivisionFilter = _productRepository.GetAllDivisons().Take(8).ToList(),
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