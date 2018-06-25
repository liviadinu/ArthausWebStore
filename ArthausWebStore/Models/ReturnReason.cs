using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ReturnReason
    {
        public byte[] Timestamp { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DefaultLocationCode { get; set; }
        public byte InventoryValueZero { get; set; }
    }
}
