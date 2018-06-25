using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ShippingAgent
    {
        public byte[] Timestamp { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string InternetAddress { get; set; }
        public string AccountNo { get; set; }
    }
}
