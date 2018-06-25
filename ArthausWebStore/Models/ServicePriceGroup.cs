using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServicePriceGroup
    {
        public byte[] Timestamp { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
