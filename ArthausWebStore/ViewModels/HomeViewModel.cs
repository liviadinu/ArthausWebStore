using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArthausWebStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArthausWebStore.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<ItemAttributes> NewProducts { get; set; }
        public List<ItemAttributes> FeaturedProducts { get; set; }
        public List<ItemAttributes> DiscountedProducts { get; set; }
        public List<ItemAttributes> BestSellingProducts { get; set; }
        public List<ItemAttributes> MostViewedProducts { get; set; }
        public List<ItemPrices> ItemPrices { get; set; }
        public List<ItemBrands> ItemBrandsList { get; set; }
        public List<ItemDivisions> ItemDivisionsList { get; set; }     
        public List<ItemCategory> ItemCategoriesList { get; set; }
        public List<ItemPrices> DiscountedPrices { get; set; }
    }
}

