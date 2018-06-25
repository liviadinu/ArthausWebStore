using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class Item
    {
        public string No { get; set; }
        public string Description { get; set; }
        public string BaseUnitOfMeasure { get; set; }
        public int StatisticsGroup { get; set; }
        public int CostingMethod { get; set; }
        public decimal UnitCost { get; set; }
        public decimal StandardCost { get; set; }
        public decimal LastDirectCost { get; set; }
        public decimal ReorderPoint { get; set; }
        public decimal ReorderQuantity { get; set; }
        public string TariffNo { get; set; }
        public int StockoutWarning { get; set; }
        public string ProductGroupCode { get; set; }
        public string ServiceItemGroup { get; set; }
        public string OriginalVendorNo { get; set; }
        public string OriginalVendorItemNo { get; set; }
        public DateTime LifecycleStartingDate { get; set; }
        public DateTime LifecycleEndingDate { get; set; }
    }
}
