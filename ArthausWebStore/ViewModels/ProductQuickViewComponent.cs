using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models.Interface;
using ArthausWebStore.ViewModels;
using ArthausWebStore.Models;

namespace ArthausWebStore.ViewModels
{
    public class ProductQuick : ViewComponent
    {
        private readonly IProductsGrid _products;
        public ProductQuick(IProductsGrid priductContext)
        {
            _products = priductContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(string SKU)
        {
            List<ItemVariant> colors = await GetColorsAsync(SKU);
            ItemAttributes details = await GetItemAttributes(SKU);
            ItemPrices prices = await GetPrices(SKU);
            Item flags = await GetItemForFlags(SKU);
            var flag = await GetFlag(SKU);
            var lowStock = await GetStock(SKU);
            var measures = await GetMeasurement(SKU);
            var stock = await GetLowItemStock(SKU);

            var product = new ProductQuickViewModel()
            {
                SKU = SKU,
                Description = details.Description2,
                CollectionDetails = String.Format("{0} Collection {1} - {2},  By {3}",details.SeasonCode ,details.Collection,details.CollectionYear, details.Brand ),
                LowStock = stock.ToString(),
                Prices = prices,
                Flags = flag
            };
            return View("QuickView",product);
        }

        private Task<List<ItemVariant>> GetColorsAsync(string SKU)
        {
            return Task.Run(() => _products.GetVariants().Where(c => c.ItemNo == SKU).ToList());
        }
        private Task<ItemPrices> GetPrices(string SKU)
        {
            return Task.Run(() => _products.GetPriceComponent(SKU));
        }

        private Task<Item> GetFlag(string SKU)
        {
            return Task.Run(() => _products.GetComponentFlag(SKU));
        }

        private Task<ItemStockLevels> GetStock(string SKU)
        {
            return Task.Run(() => _products.GetStockComponent(SKU));
        }

        private Task<ItemMeasurement> GetMeasurement(string SKU)
        {
            return Task.Run(() => _products.GetItemMeasure(SKU));
        }

        private Task<ItemAttributes> GetItemAttributes(string SKU)
        {
            return Task.Run(() => _products.GetComponentProduct(SKU));
        }

        private Task<ItemStockLevels> GetLowItemStock(string SKU)
        {
            return Task.Run(() => _products.GetStockComponent(SKU));
        }
        
        private Task<Item> GetItemForFlags(string SKU)
        {
            return Task.Run(() => _products.GetComponentFlag(SKU));
        }

    }
}
