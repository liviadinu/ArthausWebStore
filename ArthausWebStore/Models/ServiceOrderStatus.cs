using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceOrderStatus
    {
        public byte[] Timestamp { get; set; }
        public string ServiceOrderNo { get; set; }
        public int Status { get; set; }
        public int PreviousStatus { get; set; }
        public byte Exported { get; set; }
    }
}
