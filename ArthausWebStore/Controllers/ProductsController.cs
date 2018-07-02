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

        public IActionResult Index(string colorFilter,string searchString, string Category, 
                                   string priceRange, string brand, int? page)
        {

            Category = ViewBag.CurrentFilter;

            if (searchString != null)
            {
                page = 1;
            }

            int pageSize = 9;
            int pageNumber = (page ?? 1);

            ViewBag.CurrentFilter = searchString;
            var products = _productRepository.GetAllItems().OrderBy(i => i.No).ToList();

            if (!String.IsNullOrEmpty(brand))
            {
                products = products.Where(p => p.Brand.Contains(brand.ToUpper())).ToList();
            }
           
            var prices = _productRepository.GetAllItemPrices().ToList();

                if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.SearchDescription.Contains(searchString.ToUpper()) || p.Description2.Contains(searchString)).ToList();                                   
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
            if (pageNumber == 1)
            {
                @ViewBag.PageResult = 1;
            }
            else
            {
                @ViewBag.PageResult = (pageNumber - 1) * 9;
            }
           
            ViewBag.PageNumber = pageNumber;
            ViewBag.TotalResults = products.Count;

            var pageCount = pageNumber * 9;
            if (pageCount < products.Count)
            {
                ViewBag.PageCount = pageNumber * 9;
            }
            else
            {
                ViewBag.PageCount = products.Count;
            }
            return View();
        }

        public IActionResult ViewAccessories()
        {

            return View();
        }
    }
}