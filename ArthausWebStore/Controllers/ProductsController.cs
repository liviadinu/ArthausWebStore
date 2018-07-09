using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models;
using ArthausWebStore.Models.PageHelpers;
using ArthausWebStore.Models.Repositories;
using ArthausWebStore.Models.Static;
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
                ViewBag.Breadcrumbs = String.Format(@"<li><a href={0}>Search {1}</a></li>", "#", searchString.ToUpper());
                var products = await _productRepository.ItemAttributes.Where(q => q.SearchDescription.Contains(searchString.ToUpper()) || q.Description2.Contains(searchString)).
                                     GetPagedAsync(pageNumber, pageSize);
                return View(products);
            }

            var products2 = await _productRepository.ItemAttributes.OrderBy(i => i.No).GetPagedAsync(pageNumber, pageSize);
            return View(products2);
        }

        public async Task<IActionResult> WidgetFilter(string color, string season, string style, int? page)
        {
            SetCommonFileds();
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            if (!String.IsNullOrEmpty(color)) // get color filter
            {
                ViewBag.ColorFilter = color;
                var itemVariants = _productRepository.ItemVariants.Where(p => p.Color.Contains(color));
                var query2 = from sp in _productRepository.ItemAttributes
                             join v in itemVariants on sp.No equals v.ItemNo
                             select sp;
                var products = await query2.GetPagedAsync(pageNumber, pageSize);
                return View("Index", products);
            }

            if (!String.IsNullOrEmpty(season))  // get season filter
            {
                ViewBag.Breadcrumbs = String.Format(@"<li><a href={0}>{1}</a></li>", "#", season.ToUpper());
                ViewBag.Season = season;
                var produtcs = await _productRepository.ItemAttributes.Where(s => s.SeasonCode == season).GetPagedAsync(pageNumber, pageSize);
                return View("Index", produtcs);
            }

            if (!String.IsNullOrEmpty(style))  // get style filter
            {
                ViewBag.Breadcrumbs = String.Format(@"<li><a href={0}>Search {1}</a></li>", "#", style.ToUpper());
                ViewBag.Style = style;
                var produtcs = await _productRepository.ItemAttributes.Where(s => s.Style == style).GetPagedAsync(pageNumber, pageSize);
                return View("Index", produtcs);
            }

            return View();
        }

        public async Task<IActionResult> CategoryWidget(string Category, int? page)
        {
            ViewBag.Breadcrumbs = String.Format(@"<li><a href={0}>{1}</a></li>", "#", Category);
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

        public async Task<IActionResult> PopularDivisions(int? page)
        {
            SetCommonFileds();
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            ViewBag.Breadcrumbs = String.Format(@"<li><a href={0}>{1}</a></li>", "#", "Popular Categories");

            var categories = _productRepository.ItemDivisions.Take(4).ToList();
            var query = from sp in _productRepository.ItemAttributes
                        join c in categories on sp.DivisionCode equals c.DivisionCode
                        select sp;
            var products = await query.GetPagedAsync(pageNumber, pageSize);
           return View("Index", products);
        }

        public async Task<IActionResult> SubCategoryLink(string subCategory, int? page)
        {
            SetCommonFileds();
            var popularCateg = String.Format(@"<li><a href={0}>{1}</a></li>", "PopularDivisions", "Popular Categories");
            var buffer = _productRepository.ItemCategory.Where(c => c.Code == subCategory).First();
            var division = _productRepository.ItemDivisions.Where(d => d.DivisionCode == buffer.DivisionCode).FirstOrDefault();
            string divisionId = division.DivisionDescription;
            divisionId = divisionId.Replace(" ", "%20");
            var category = String.Format(@"<li><a href={0}?Category={1}>{2}</a></li>", "CategoryWidget", divisionId, division.DivisionDescription);
            var thisPage = String.Format(@"<li><a href={0}>{1}</a></li>", "#", buffer.Description);

            ViewBag.Breadcrumbs = String.Format(@"{0}{1}{2}",popularCateg, category, thisPage);
            ViewBag.SubCategory = subCategory;           
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            var products = await _productRepository.ItemAttributes.Where(p => p.ItemCategoryCode == subCategory).GetPagedAsync(pageNumber,pageSize);
            return View("Index", products);
        }

        public async Task<IActionResult> BrandWidget(string myBrand, int? page)
        {
            SetCommonFileds();
            ViewBag.Brand = myBrand;        // get brand filter
            ViewBag.Breadcrumbs = String.Format(@"<li><a href={0}>{1}</a></li>", "TopBrands", "Top Brands") + 
                                  String.Format(@"<li><a href={0}>{1}</a></li>", "#", myBrand);
            
            int pageSize = 9;
            int pageNumber = (page ?? 1);

            var itemBrands = _productRepository.ItemBrands.Where(b => b.Description.Contains(myBrand));
            var query = from sp in _productRepository.ItemAttributes
                            join b in itemBrands on sp.Brand equals b.Code
                            select sp;
            var products = await query.GetPagedAsync(pageNumber, pageSize);
            return View("Index", products);
        }


        public async Task<IActionResult> TopBrands(string topBrands, int? page)
        {
            SetCommonFileds();
            ViewBag.TopBrands = "true";
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            ViewBag.Breadcrumbs = String.Format(@"<li><a href={0}>{1}</a></li>", "#", "Top Brands");
            var brands =  _productRepository.ItemBrands.Take(4);
            
            var query = from sp in _productRepository.ItemAttributes
                        join b in brands on sp.Brand equals b.Code
                        select sp;
            var products = await query.GetPagedAsync(pageNumber, pageSize);
            return View("Index", products);
        }

        public async Task<IActionResult> CollectionWidget(string Collection, int? page)
        {
            ViewBag.Breadcrumbs = String.Format(@"<li><a href={0}>{1}</a></li>", "#", Collection);
            ViewBag.Collection = Collection;        // get brand filter
            SetCommonFileds();
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            var products = await _productRepository.ItemAttributes.Where(c => c.Collection == Collection).GetPagedAsync(pageNumber, pageSize);
            return View("Index",products);
        }

        public async Task<IActionResult> ViewAccessories(string accessories, int? page)
        {
            ViewBag.Accessories = accessories;
            ViewBag.Breadcrumbs = String.Format(@"<li><a href ={0}>{1}</a ></li>", "#", "Accessories");
            SetCommonFileds();
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            var divisions = _productRepository.ItemDivisions.Where(d => d.Accessory == 1 & d.Active == 1 & d.BuyableOnline == 1);
            var query = from sp in _productRepository.ItemAttributes
                        join d in divisions on sp.DivisionCode equals d.DivisionCode
                        select sp;
            var result = await query.GetPagedAsync(pageNumber, pageSize);
            return View("Index", result);
        }

        public  async Task<IActionResult> SingleProduct(string SKU)
        {
            var category = await GetCategoryDescription(SKU);
            var item = await GetItemAttributes(SKU);
            var measure = await GetMeasurement(SKU);
            var prices = await GetPrices(SKU);
            var variant = await GetVariants(SKU);
            var product = new SingleProductViewModel
            {
                Category = category,
                 Measurement = measure,
                  Prices = prices,
                   Product = item,
                    Variants = variant
            };
            return View("SingleProduct", product);
        }

        private Task<ItemMeasurement> GetMeasurement(string SKU)
        {
            return Task.Run(() => _productRepository.ItemMeasurement.Where(m => m.No.StartsWith(SKU.ToUpper())).FirstOrDefault());
        }

        private Task<ItemAttributes> GetItemAttributes(string SKU)
        {
            return Task.Run(() => _productRepository.ItemAttributes.Where(c => c.No == SKU).FirstOrDefault());
        }

        private Task<List<ItemVariant>> GetVariants(string SKU)
        {
            return Task.Run(() => _productRepository.ItemVariants.Where(c => c.ItemNo == SKU).ToList());
        }

        private Task<ItemPrices> GetPrices(string SKU)
        {
            return Task.Run(() => _productRepository.ItemPrices.Where(p => p.No.StartsWith(SKU.ToUpper())).FirstOrDefault());
        }

        private Task<String> GetCategoryDescription(string SKU)
        {
            return Task.Run(() => _productRepository.ItemCategory.Where(p => p.DivisionCode.StartsWith(SKU.ToUpper())).FirstOrDefault().Description);
        }


        private void SetCommonFileds()
        {
            var attributes = new List<String>[6];

            attributes[0] = _productRepository.ItemAttributes.Select(c => c.Collection).Distinct().ToList();
            attributes[1] = _productRepository.ItemVariants.Select(c => c.Color).Distinct().ToList();
            attributes[2] = _productRepository.ItemAttributes.Select(s => s.Style).Distinct().ToList();
            attributes[3] = _productRepository.ItemAttributes.Select(s => s.SeasonCode).Distinct().ToList();
            attributes[4] = _productRepository.ItemBrands.Select(b => b.Description).ToList();
            attributes[5] = _productRepository.ItemDivisions.Where(d => d.BuyableOnline == 1 & d.Active == 1).Select(d => d.DivisionDescription).ToList();

            Common.SetAttributes(attributes);
            Common.SetPricecollection(_productRepository.ItemPrices.ToList());
            
        }

    }
}