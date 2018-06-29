using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models.Interface;

namespace ArthausWebStore.Models
{
    public class ItemRepository : ISkuItemsList
    {
        private readonly ArthuisWebShopContext _appDbContext;

        public ItemRepository(ArthuisWebShopContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ItemBrands> GetAllBrands()
        {
            return _appDbContext.ItemBrands.ToList();
        }

        public IEnumerable<ItemCategory> GetAllCategories()
        {
            return _appDbContext.ItemCategory.ToList();
        }

        public IEnumerable<ItemDivisions> GetAllDivisons()
        {
            return _appDbContext.ItemDivisions.ToList();
        }

        public IEnumerable<ItemAttributes> GetAllItems()
        {
            return _appDbContext.ItemAttributes.OrderBy(item => item.No).ToList();
        }

        public IEnumerable<ItemAttributes> GetAllItemsOnSale()
        {
            var promotions = _appDbContext.ItemPrices.Where(i => 
                                  i.DiscountPerc != 0
                                  & i.SalesStartDate.Value.Date <= System.DateTime.Today 
                                  & i.EndDateSales.Value.Date >= System.DateTime.Today).ToList();

            List<ItemAttributes> promos = new List<ItemAttributes>();
            foreach (var item in promotions)
            {
                promos.Add(_appDbContext.ItemAttributes.First(i => i.No == item.No));
            }
            return promos;
        }

        private IEnumerable<ItemAttributes> GetNewArrivals()
        {
            var newItems = _appDbContext.Item.Where(i => i.LifecycleEndingDate.Date >= System.DateTime.Today 
                                 & System.DateTime.Today <= i.LifecycleStartingDate.AddDays(30));
            List<ItemAttributes> news = new List<ItemAttributes>();
            foreach (var item in newItems)
            {
                news.Add(_appDbContext.ItemAttributes.First(i => i.No == item.No));
            }
            return news;
        }

        public ItemAttributes GetItemAtributeBySKU(string SKU)
        {
            return _appDbContext.ItemAttributes.FirstOrDefault(item => item.No == SKU);
        }

        public ItemAttributes GetItemAttributeByDescription(string Description)
        {
            var filteredItems = _appDbContext.ItemAttributes.Where(item => item.Description2.StartsWith(Description)).OrderBy(item => item.SearchDescription);
            return filteredItems.FirstOrDefault();
        }

        public ItemMeasurement GetItemMeasure(string SKU)
        {
            return _appDbContext.ItemMeasurement.FirstOrDefault(i => i.No == SKU);
        }

        public ItemPrices GetItemPriceBySku(string SKU)
        {
            return _appDbContext.ItemPrices.FirstOrDefault(i => i.No == SKU);
        }

        public IEnumerable<ItemAttributes> GetFlaggedList(FlagType flag, int group)
        {
            switch (flag)
            {
                case FlagType.BestSeller:
                    return _appDbContext.ItemAttributes.Where(item => item.BestSeller == true).Take(group);
                case FlagType.DiscountedProduct:
                    return GetAllItemsOnSale().OrderBy(i => i.Description2).Take(group);
                case FlagType.FeaturedProduct:
                    return _appDbContext.ItemAttributes.Where(item => item.Featured == true).Take(group);
                case FlagType.MostViewed:
                    return _appDbContext.ItemAttributes.Where(item => item.MostViewed == true).Take(group);
                case FlagType.AvailableToReserve:
                    return _appDbContext.ItemAttributes.Where(item => item.Reserve == 1).Take(group);
                case FlagType.NewArrival:
                    return _appDbContext.ItemAttributes.Take(group);
                default:
                    return _appDbContext.ItemAttributes.OrderBy(p => p.Description2).Take(group);
            }
        }

        public IEnumerable<ItemPrices> GetAllItemPrices()
        {
            return _appDbContext.ItemPrices.ToList();
        }

        public IEnumerable<ItemPrices> GetDiscoutnedPrices()
        {
            var promotions = _appDbContext.ItemPrices.Where(i => i.DiscountPerc != null &&
                                  i.DiscountPerc != 0 && i.SalesStartDate != null
                                  && i.SalesStartDate.Value.Date <= System.DateTime.Today && i.EndDateSales.Value.Date >= System.DateTime.Today).ToList();
            return promotions;


        }

    }
}
