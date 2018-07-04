using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models.Interface;
using ArthausWebStore.Models.PageHelpers;

namespace ArthausWebStore.Models.Repositories
{
    public class ProductRepository : IProductsGrid
    {
        private readonly ArthuisWebShopContext _products;
        public ProductRepository(ArthuisWebShopContext appDbContext)
        {
            _products = appDbContext;
        }


        public IEnumerable<ItemBrands> GetAllBrands()
        {
            return _products.ItemBrands.ToList();
        }

        public IEnumerable<ItemCategory> GetAllCategories()
        {
            return _products.ItemCategory.ToList();
        }

        public IEnumerable<ItemDivisions> GetAllDivisons()
        {
            return _products.ItemDivisions.ToList();
        }

        public IEnumerable<ItemPrices> GetAllItemPrices()
        {
            return _products.ItemPrices.ToList();
        }

        public IEnumerable<ItemAttributes> GetAllItems()
        {
            return _products.ItemAttributes.OrderByDescending(c => c.No).ToList();
        }

        public IEnumerable<ItemVariant> GetComponentColors(string SKU)
        {
            return _products.ItemVariants.Where(c => c.ItemNo.StartsWith(SKU)).ToList();
        }

        public Item GetComponentFlag(string SKU)
        {
            return _products.Item.Where(i => i.No.StartsWith(SKU)).FirstOrDefault();
        }

        public ItemAttributes GetComponentProduct(string SKU)
        {
            return _products.ItemAttributes.Where(i => i.No == SKU).FirstOrDefault();
        }

        public IEnumerable<Item> GetFlags()
        {
            return _products.Item.ToList();
        }

        public ItemMeasurement GetItemMeasure(string SKU)
        {
            return _products.ItemMeasurement.Where(i => i.No.StartsWith(SKU)).FirstOrDefault();
        }

        public ItemPrices GetPriceComponent(string SKU)
        {
            return _products.ItemPrices.Where(i => i.No.StartsWith(SKU)).FirstOrDefault();
        }

        public ItemStockLevels GetStockComponent(string SKU)
        {
            return _products.ItemStockLevels.Where(i => i.ItemNo.StartsWith(SKU)).FirstOrDefault();
        }

        public IEnumerable<ItemVariant> GetVariants()
        {
            return _products.ItemVariants.ToList();
        }

        
    }
}
