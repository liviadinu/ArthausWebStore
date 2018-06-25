using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceOrderItems
    {
        public byte[] Timestamp { get; set; }
        public string ServiceOrderNo { get; set; }
        public int LineNo { get; set; }
        public string ServiceItemNo { get; set; }
        public string ItemNo { get; set; }
        public decimal Quantity { get; set; }
        public int RelatedDocumentLineNo { get; set; }
        public decimal TotalWeight { get; set; }
        public decimal TotalVolume { get; set; }
        public decimal TotalNumberOfPackages { get; set; }
        public string RelatedDocumentNo { get; set; }
        public int SalesOrderLineNo { get; set; }
        public string DeletedField25 { get; set; }
        public int DeletedField26 { get; set; }
        public int ItemTransactionNo { get; set; }
        public int RelatedDocumentType { get; set; }
        public string ItemStoreNo { get; set; }
        public string ItemPosTerminalNo { get; set; }
        public int ItemTransLineNo { get; set; }
    }
}
