using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ItemPrices
    {
        public string No { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime? EndDateSales { get; set; }
        public DateTime? SalesStartDate { get; set; }
        public decimal? UnitPriceIncludingVat { get; set; }
        public decimal? MaxDiscountAllowed { get; set; }
        public decimal? DiscountPerc { get; set; }
        public decimal? SpecialPrice { get; set; }
        public decimal? MinQtyForSpecialPrice { get; set; }
        public decimal? VatPerc { get; set; }
    }
}
