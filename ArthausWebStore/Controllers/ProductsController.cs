using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models;
using ArthausWebStore.Models.PageHelpers;
using ArthausWebStore.Models.Repositories;
using ArthausWebStore.Models.Static;
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

        public async Task<IActionResult> Index(string searchString, string priceRange, int? page)
        {
            SetCommonFileds();
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            decimal[] range;
            IQueryable<ItemPrices> rangePrices = _productRepository.ItemPrices.AsQueryable();
            IQueryable<ItemAttributes> query = _productRepository.ItemAttributes.AsQueryable();

            ViewBag.CurrentFilter = searchString;
            ViewBag.PriceRange = priceRange;

            var hasPrice = (!String.IsNullOrEmpty(priceRange));
            var multipleFilters = hasPrice & (!String.IsNullOrEmpty(searchString));

            if (hasPrice)
            {
                priceRange = priceRange.Replace("$", "");
                priceRange = priceRange.Replace(" ", "");
                range = priceRange.Split('-').Select(decimal.Parse).ToArray();
                rangePrices = _productRepository.ItemPrices.Where(p => p.UnitPriceIncludingVat >= range[0] & p.UnitPriceIncludingVat <= range[1]);
                query = from sp in _productRepository.ItemAttributes
                            join p in rangePrices on sp.No equals p.No
                            select sp;
            }
       
            if (multipleFilters) // get search & price filter
            {
                var products = await query.Where(q => q.SearchDescription.Contains(searchString.ToUpper()) || q.Description2.Contains(searchString)).
                               GetPagedAsync(pageNumber, pageSize);
                return View(products);
            }            

            if (!String.IsNullOrEmpty(priceRange)) // get price range
            {
               var products = await query.GetPagedAsync(pageNumber, pageSize);
               return View(products);
            }

            if (!String.IsNullOrEmpty(searchString)) // get search filter
            {
                var products = await _productRepository.ItemAttributes.GetPagedAsync(pageNumber, pageSize);
            }

            var products2 = await _productRepository.ItemAttributes.OrderBy(i => i.No).GetPagedAsync(pageNumber, pageSize);
            return View(products2);
        }


        public async Task<IActionResult> WidgetFilter(string color, string season, string style, int? page)
        {
            
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            if (!String.IsNullOrEmpty(color)) // get color filter
            {
                ViewBag.ColorFilter = color;
                var itemVariants = _productRepository.ItemVariants.Where(p => p.Color.Contains(color));
                var query2 = from sp in _productRepository.ItemAttributes
                             join v in itemVariants on sp.No equals v.ItemNo
                             select sp;
                var products = query2.GetPagedAsync(pageNumber, pageSize);
                return View("Index", products);
            }

            if (!String.IsNullOrEmpty(season))  // get season filter
            {
                ViewBag.Season = season;
                var produtcs = await _productRepository.ItemAttributes.Where(s => s.SeasonCode == season).GetPagedAsync(pageNumber, pageSize);
                return View("Index", produtcs);
            }

            if (!String.IsNullOrEmpty(style))  // get style filter
            {
                ViewBag.Style = style;
                var produtcs = await _productRepository.ItemAttributes.Where(s => s.Style == style).GetPagedAsync(pageNumber, pageSize);
                return View("Index", produtcs);
            }

            return View();
        }

        public async Task<IActionResult> CategoryWidget(string Category, int? page)
        {
            ViewBag.Category = Category;
            SetCommonFileds();  // get division filter
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            var divisions = _productRepository.ItemDivisions.Where(d => d.DivisionDescription == Category);
            var query = from sp in _productRepository.ItemAttributes
                        join d in divisions on sp.DivisionCode equals d.DivisionCode
                        select sp;
            var produtcs = await query.GetPagedAsync(pageNumber, pageSize);
            return View("Index", produtcs);
        }

        public async Task<IActionResult> BrandWidget(string Brand, int? page)
        {
            ViewBag.Brand = Brand;        // get brand filter
            SetCommonFileds();
            int pageSize = 9;
            int pageNumber = (page ?? 1);

            var itemBrands = _productRepository.ItemBrands.Where(b => b.Description.Contains(Brand));
            var query = from sp in _productRepository.ItemAttributes
                            join b in itemBrands on sp.Brand equals b.Code
                            select sp;
            var products = await query.GetPagedAsync(pageNumber, pageSize);
            return View("Index", products);
        }

        public async Task<IActionResult> CollectionWidget(string Collection, int? page)
        {
            ViewBag.Collection = Collection;        // get brand filter
            SetCommonFileds();
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            var products = await _productRepository.ItemAttributes.Where(c => c.Collection == Collection).GetPagedAsync(pageNumber, pageSize);
            return View("Index",products);
        }

        private void SetCommonFileds()
        {
            var attributes = new List<String>[6];

            attributes[0] = _productRepository.ItemAttributes.Select(c => c.Collection).Distinct().ToList();
            attributes[1] = _productRepository.ItemVariants.Select(c => c.Color).Distinct().ToList();
            attributes[2] = _productRepository.ItemAttributes.Select(s => s.Style).Distinct().ToList();
            attributes[3] = _productRepository.ItemAttributes.Select(s => s.SeasonCode).Distinct().ToList();
            attributes[4] = _productRepository.ItemBrands.Select(b => b.Description).ToList();
            attributes[5] = _productRepository.ItemDivisions.Where(d => d.BuyableOnline == 1).Select(d => d.DivisionDescription).ToList();

            Common.SetAttributes(attributes);
            Common.SetPricecollection(_productRepository.ItemPrices.ToList());
            
        }

    }
}