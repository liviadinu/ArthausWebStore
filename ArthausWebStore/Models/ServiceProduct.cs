using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceProduct
    {
        public byte[] Timestamp { get; set; }
        public string No { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string LinkedItemNo { get; set; }
        public string TypeCode { get; set; }
        public byte Enabled { get; set; }
        public string NoSeries { get; set; }
        public byte NoItemLink { get; set; }
        public int ServiceProductId { get; set; }
    }
}
