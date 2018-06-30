using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models;
using ArthausWebStore.Models.Repositories;
using ArthausWebStore.Models.Interface;
using ArthausWebStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using X.PagedList.Mvc;

namespace ArthausWebStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsGrid _productRepository;

        public ProductsController(IProductsGrid productsGrid)
        {
            _productRepository = productsGrid;
        }

        public IActionResult Index(string colorFilter,string searchString, string Category, decimal?[] priceRange, int? page)
        {            
            //ViewBag.CurrentSort = sortOrder;
            //ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "descript_desc" : "";
            //ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            if (searchString != null)
            {
                page = 1;
            }

            int pageSize = 9;
            int pageNumber = (page ?? 1);

            ViewBag.ColorFilter = colorFilter;
            //ViewBag.PriceRange = priceRange[];
            ViewBag.CurrentFilter = searchString;

            var products = _productRepository.GetAllItems().OrderBy(i => i.No).ToList();
            var prices = _productRepository.GetAllItemPrices().ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.Description2.Contains(searchString) ||
                                     p.SearchDescription.Contains(searchString)).ToList();                                   
            }

            var productGrid = new List<ProductsViewModel>();

            foreach (var item in products)
            {
                productGrid.Add(new ProductsViewModel
                {
                    ProductNo = item.No,
                    Description = item.Description2,
                    NormalPrice = Common.ReturnNormalPrice(item.No,prices),
                    AppliedPrice = Common.ReturnAppliedPrice(item.No,prices),
                    OnSale = Common.ShowDiscounted(item.No,prices),
                    Collection = item.Collection,
                    CollectionYear = item.CollectionYear.ToString(),
                    SeasonCode =item.SeasonCode,
                });
            };

            var onePageProducts = productGrid.ToPagedList(pageNumber, pageSize);
            ViewBag.OnePageOfProducts = onePageProducts;
            ViewBag.PageCount = productGrid.Count * pageNumber;
            ViewBag.PageNumber = pageNumber;
            ViewBag.TotalResults = products.Count;
            return View();
        }

        public IActionResult ViewAccessories()
        {

            return View();
        }
    }
}