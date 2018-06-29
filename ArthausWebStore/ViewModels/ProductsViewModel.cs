using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models;

namespace ArthausWebStore.ViewModels
{
    public class ProductsViewModel
    {
        public string Title { get; set; }
        public List<Item> ItemFlags { get; set; }
        public List<ItemAttributes> ProductGrid { get; set; }
        public List<ItemPrices> ItemPrices { get; set; }
        public List<ItemBrands> ItemBrandsList { get; set; }
        public List<ItemDivisions> DivisionFilter { get; set; }
        public List<ItemCategory> ItemCategoriesList { get; set; }
        public List<ItemVariant> ColorsFilter { get; set; }

    }
}
