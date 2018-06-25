using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceProductType
    {
        public byte[] Timestamp { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte TransportDependent { get; set; }
    }
}
