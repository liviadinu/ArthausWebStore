using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ItemStockLevels
    {
        public string ItemNo { get; set; }
        public decimal SellableStock { get; set; }
        public decimal? StockOnSalesOrder { get; set; }
        public decimal? StockInPicking { get; set; }
        public decimal? ExpectedStock { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
    }
}
