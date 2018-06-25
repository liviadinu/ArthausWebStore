using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class CustomerOrderLine
    {
        public byte[] Timestamp { get; set; }
        public string DocumentId { get; set; }
        public int LineNo { get; set; }
        public int Status { get; set; }
        public int LineType { get; set; }
        public string Number { get; set; }
        public string VariantCode { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public decimal NetPrice { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal NetAmount { get; set; }
        public decimal VatAmount { get; set; }
        public decimal Amount { get; set; }
        public string VatProdPostingGroup { get; set; }
        public string ItemDescription { get; set; }
        public string VariantDescription { get; set; }
        public string UoMDescription { get; set; }
        public int OriginalLineNo { get; set; }
        public byte InternalSelection { get; set; }
        public decimal InternalAvailableQty { get; set; }
        public string SourcingLocation { get; set; }
        public string OrderReference { get; set; }
        public byte InventoryTransfer { get; set; }
    }
}
