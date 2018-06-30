using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models;
using PagedList;

namespace ArthausWebStore.ViewModels
{
    public class ProductsViewModel
    {
        public string Title { get; set; }
        public string ProductNo { get; set; }
        public string Description { get; set; }
        public string NormalPrice { get; set; }
        public string AppliedPrice { get; set; }
        public string SeasonCode { get; set; }
        public string Collection { get; set; }
        public string CollectionYear { get; set; }
        public bool OnSale { get; set; }
        public List<ItemBrands> ItemBrandsList { get; set; }
        public List<ItemDivisions> ItemDivisionsList { get; set; }
        public List<ItemCategory> ItemCategoriesList { get; set; }

    }
}
