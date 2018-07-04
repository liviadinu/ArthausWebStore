using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models;
using ArthausWebStore.Models.Repositories;
using ArthausWebStore.Models.Interface;
using ArthausWebStore.Models.PageHelpers;
using ArthausWebStore.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace ArthausWebStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ArthuisWebShopContext _productRepository;

        public ProductsController(ArthuisWebShopContext productsGrid)
        {
            _productRepository = productsGrid;
        }

        public async Task<IActionResult> Index(string colorFilter,string searchString, string priceRange, string Category, 
                                   string brand, int? page)
        {
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            PagedResult<ItemAttributes> products = new PagedResult<ItemAttributes>();
            IEnumerable<ItemPrices> prices = new List<ItemPrices>();

            ViewBag.CurrentFilter = searchString;
            ViewBag.PriceRange = priceRange;

            if (!String.IsNullOrEmpty(priceRange))
            {
                priceRange = priceRange.Replace("$", "");
                priceRange = priceRange.Replace(" ", "");
                decimal[] range = priceRange.Split('-').Select(decimal.Parse).ToArray();
                prices = _productRepository.ItemPrices.Where(p => p.UnitPriceIncludingVat >= range[0] & p.UnitPriceIncludingVat <= range[1]);

                var query = from sp in _productRepository.ItemAttributes
                            join p in prices on sp.No equals p.No
                            select sp;
                if (!String.IsNullOrEmpty(searchString))
                {
                    products = await query.Where(q => q.SearchDescription.Contains(searchString.ToUpper()) || q.Description2.Contains(searchString)).
                               GetPagedAsync(pageNumber, pageSize);
                }
                else
                {
                    products = await query.GetPagedAsync(pageNumber, pageSize);
                }
            }
            else
            {
               prices = _productRepository.ItemPrices.ToList();
               products = await _productRepository.ItemAttributes.OrderBy(i => i.No).GetPagedAsync(pageNumber, pageSize);
                if (!String.IsNullOrEmpty(searchString))
                {
                    products = await _productRepository.ItemAttributes.Where
                         (p => p.SearchDescription.Contains(searchString.ToUpper()) || p.Description2.Contains(searchString)).
                         GetPagedAsync(pageNumber, pageSize);
                }
                else
                {
                    products = await _productRepository.ItemAttributes.GetPagedAsync(pageNumber, pageSize);
                }
            }
            Common.SetPricecollection(prices);
            return View(products);
        }



        public IActionResult ViewAccessories()
        {

            
            return View();
        }
    }
}