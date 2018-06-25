using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ShippingAgentServices
    {
        public byte[] Timestamp { get; set; }
        public string ShippingAgentCode { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ShippingTime { get; set; }
        public string BaseCalendarCode { get; set; }
    }
}
