using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceOrderAllocation
    {
        public byte[] Timestamp { get; set; }
        public int EntryNo { get; set; }
        public int Status { get; set; }
        public string DocumentNo { get; set; }
        public DateTime AllocationDate { get; set; }
        public string ResourceNo { get; set; }
        public string ResourceGroupNo { get; set; }
        public int ServiceItemLineNo { get; set; }
        public decimal AllocatedHours { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime FinishingTime { get; set; }
        public string Description { get; set; }
        public string ReasonCode { get; set; }
        public string ServiceItemNo { get; set; }
        public byte Posted { get; set; }
        public string ServiceItemSerialNo { get; set; }
        public byte ServiceStarted { get; set; }
        public int DocumentType { get; set; }
    }
}
