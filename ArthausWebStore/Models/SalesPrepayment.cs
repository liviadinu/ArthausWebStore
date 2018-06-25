using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class SalesPrepayment
    {
        public byte[] Timestamp { get; set; }
        public string ItemNo { get; set; }
        public int SalesType { get; set; }
        public string SalesCode { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public decimal Prepayment { get; set; }
    }
}
