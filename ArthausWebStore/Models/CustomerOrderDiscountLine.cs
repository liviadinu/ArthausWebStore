using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class CustomerOrderDiscountLine
    {
        public byte[] Timestamp { get; set; }
        public string DocumentId { get; set; }
        public int LineNo { get; set; }
        public int EntryNo { get; set; }
        public int DiscountType { get; set; }
        public string OfferNo { get; set; }
        public int PeriodicDiscType { get; set; }
        public string PeriodicDiscGroup { get; set; }
        public string Description { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
    }
}
