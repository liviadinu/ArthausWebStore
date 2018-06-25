using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class PayableVendorLedgerEntry
    {
        public byte[] Timestamp { get; set; }
        public int Priority { get; set; }
        public string VendorNo { get; set; }
        public string CurrencyCode { get; set; }
        public byte Positive { get; set; }
        public byte Future { get; set; }
        public int EntryNo { get; set; }
        public int VendorLedgEntryNo { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountLcy { get; set; }
    }
}
