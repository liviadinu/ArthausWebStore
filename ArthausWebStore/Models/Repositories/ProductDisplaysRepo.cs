using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models.Interface;


namespace ArthausWebStore.Models.Repositories
{
    public class ProductDisplaysRepo : IProductsGrid
    {
        public IEnumerable<ItemBrands> GetAllBrands()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemCategory> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemDivisions> GetAllDivisons()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemPrices> GetAllItemPrices()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemAttributes> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemAttributes> GetAllItemsOnSale()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemPicture> GetAllPictures()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemPrices> GetDiscoutnedPrices()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemAttributes> GetFlaggedList(FlagType flag, int group)
        {
            throw new NotImplementedException();
        }

        public ItemAttributes GetItemAtributeBySKU(string SKU)
        {
            throw new NotImplementedException();
        }

        public ItemAttributes GetItemAttributeByDescription(string Description)
        {
            throw new NotImplementedException();
        }

        public ItemMeasurement GetItemMeasure(string SKU)
        {
            throw new NotImplementedException();
        }

        public ItemPrices GetItemPriceBySku(string SKU)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemPicture> GetPictures()
        {
            throw new NotImplementedException();
        }
    }
}
