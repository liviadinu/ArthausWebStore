using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models.Interface
{
    public interface IProductsGrid
    {
        IEnumerable<ItemAttributes> GetAllItems();
        IEnumerable<ItemVariant> GetVariants();
        ItemMeasurement GetItemMeasure(string SKU);
        IEnumerable<ItemPrices> GetAllItemPrices();
        IEnumerable<ItemBrands> GetAllBrands();
        IEnumerable<ItemCategory> GetAllCategories();
        IEnumerable<ItemDivisions> GetAllDivisons();
        ItemStockLevels GetStockComponent(string SKU);
        IEnumerable<ItemVariant> GetComponentColors(string SKU);
        ItemAttributes GetComponentProduct(string SKU);
        ItemPrices GetPriceComponent(string SKU);
        IEnumerable<Item> GetFlags();
        Item GetComponentFlag(string SKU);

    }
}
