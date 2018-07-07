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
        private readonly ArthuisWebShopContext _products;
        public ProductQuick(ArthuisWebShopContext priductContext)
        {
            _products = priductContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(string SKU)
        {
            List<ItemVariant> colors = await GetColorsAsync(SKU);
            ItemAttributes details = await GetItemAttributes(SKU);
            ItemPrices prices = await GetPrices(SKU);
            Item flags = await GetFlag(SKU);
            var flag = await GetFlag(SKU);
            var lowStock = await GetStock(SKU);
            
            var measures = await GetMeasurement(SKU);

            var product = new ProductQuickViewModel()
            {
                SKU = SKU,
                Description = details.Description2,
                CollectionDetails = String.Format("{0} Collection {1} - {2},  By {3}",details.SeasonCode ,details.Collection,details.CollectionYear, details.Brand ),
                LowStock = lowStock.SellableStock.ToString(),
                Prices = prices,
                Flags = flag
            };
            return View("QuickView",product);
        }

        private Task<List<ItemVariant>> GetColorsAsync(string SKU)
        {
            return Task.Run(() => _products.ItemVariants.Where(c => c.ItemNo == SKU).ToList());
        }
        private Task<ItemPrices> GetPrices(string SKU)
        {
            return Task.Run(() => _products.ItemPrices.Where(p => p.No.StartsWith(SKU.ToUpper())).FirstOrDefault());
        }

        private Task<Item> GetFlag(string SKU)
        {
            return Task.Run(() => _products.Item.Where(p => p.No.StartsWith(SKU.ToUpper())).FirstOrDefault());
        }

        private Task<ItemStockLevels> GetStock(string SKU)
        {
            return Task.Run(() => _products.ItemStockLevels.Where(c => c.ItemNo == SKU).FirstOrDefault());
        }

        private Task<ItemMeasurement> GetMeasurement(string SKU)
        {
            return Task.Run(() => _products.ItemMeasurement.Where(m => m.No.StartsWith(SKU.ToUpper())).FirstOrDefault());
        }

        private Task<ItemAttributes> GetItemAttributes(string SKU)
        {
            return Task.Run(() => _products.ItemAttributes.Where(c => c.No == SKU).FirstOrDefault());
        }
    }
}
