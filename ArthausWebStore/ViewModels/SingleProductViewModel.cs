using ArthausWebStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.ViewModels
{
    public class SingleProductViewModel
    {
        public ItemAttributes Product {get; set;}
        public string Category { get; set; }
        public ItemMeasurement Measurement { get; set; }
        public ItemPrices Prices { get; set; }
        public string LowStock { get; set; }
        public List<ItemVariant> Variants { get; set; }
    }
}
