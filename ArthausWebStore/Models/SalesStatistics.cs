using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class SalesStatistics
    {
        public byte[] Timestamp { get; set; }
        public string StoreNo { get; set; }
        public int EntryNo { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public decimal ItemsSold { get; set; }
        public decimal ItemsScanned { get; set; }
        public decimal NoOfDepartmentSales { get; set; }
        public decimal NoOfReturns { get; set; }
        public decimal VoidedAmount { get; set; }
        public decimal SalesAmount { get; set; }
        public decimal VatAmount { get; set; }
        public decimal CostAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NoOfSalesTransEntries { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal AddCurrSalesAmount { get; set; }
        public decimal AddCurrVatAmount { get; set; }
        public decimal AddCurrCostAmount { get; set; }
        public decimal AddCurrDiscountAmount { get; set; }
        public decimal AddCurrTotalDiscount { get; set; }
    }
}
