using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ItemVendor
    {
        public byte[] Timestamp { get; set; }
        public string VendorNo { get; set; }
        public string ItemNo { get; set; }
        public string VariantCode { get; set; }
        public string LeadTimeCalculation { get; set; }
        public string VendorItemNo { get; set; }
        public int PriceType { get; set; }
        public int FinancialYear { get; set; }
    }
}
