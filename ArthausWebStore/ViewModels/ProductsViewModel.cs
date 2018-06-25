using ArthausWebStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.ViewModels
{
    public class ProductsViewModel
    {
        public string Title { get; set; }
        public List<ItemAttributes> AvailableProducts { get; set; }
        public List<ItemBrands> ItemBrands { get; set; }
        public List<ItemDivisions> ItemDivisions { get; set; }
        public List<ItemPrices> PriceRange { get; set; }
        public List<String> ColorRange { get; set; }
        public List<ItemPicture> ItemPictures { get; set; }
    }
}
