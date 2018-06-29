using ArthausWebStore.Models;
using ArthausWebStore.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.ViewModels
{
    public class ProductQuickViewModel
    {
        public string SKU { get; set; }
        public string Description { get; set; }
        public ItemPrices Prices { get; set; }
        public string CollectionDetails { get; set; }
        public string LowStock { get; set; }
        public Item Flags { get; set; }
    }
}
