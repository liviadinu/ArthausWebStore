using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class Visitors
    {
        public byte[] Timestamp { get; set; }
        public string StoreNo { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfVisitors { get; set; }
        public decimal RestaurantSales { get; set; }
        public decimal ExitCafeSales { get; set; }
        public int RestaurantCustomers { get; set; }
    }
}
