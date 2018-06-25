using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models.Interface
{
    public interface ISkuItemsList
    {
        IEnumerable<ItemAttributes> GetAllItems();
        ItemAttributes GetItemAtributeBySKU(string SKU);
        ItemAttributes GetItemAttributeByDescription(string Description);
        ItemPrices GetItemPriceBySku(string SKU);
        ItemMeasurement GetItemMeasure(string SKU);
        IEnumerable<ItemPrices> GetAllItemPrices();
        IEnumerable<ItemPrices> GetDiscoutnedPrices();
        IEnumerable<ItemBrands> GetAllBrands();
        IEnumerable<ItemCategory> GetAllCategories();
        IEnumerable<ItemDivisions> GetAllDivisons();
        IEnumerable<ItemAttributes> GetAllItemsOnSale();
        IEnumerable<ItemAttributes> GetFlaggedList(FlagType flag, int group);
        IEnumerable<ItemPicture> GetPictures();
    }
}

